using PoniLCU;
using static PoniLCU.LeagueClient;

namespace LeagueSettings
{
    public partial class MainForm : Form
    {
        const string GameSettingsFilePath = "gameSettings.json";
        const string InputSettingsFilePath = "inputSettings.json";
        LeagueClient _leagueClient;
        string _gameSettings;
        string _inputSettings;

        public MainForm()
        {
            InitializeComponent();

            DisableInteractions();
            _leagueClient = new LeagueClient(LeagueClient.credentials.cmd);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSettingsFromDisk();
            } catch (Exception)
            {
                MessageBox.Show("Could not get stored settings. Maybe its the first time running the app?");
                GetButton.Enabled = true;
                return;
            }

            EnableInteractions();
        }

        private void DisableInteractions()
        {
            GetButton.Enabled = false;
            SetButton.Enabled = false;
        }

        private void EnableInteractions()
        {
            GetButton.Enabled = true;
            SetButton.Enabled = true;
        }

        private async void GetButton_Click(object sender, EventArgs e)
        {
            DisableInteractions();

            _gameSettings = await FetchGameSettings();
            _inputSettings = await FetchInputSettings();

            SaveSettingsToDisk();

            MessageBox.Show("Game Settings: " + _gameSettings + "\nInput Settings: " + _inputSettings, "Received settings");

            EnableInteractions();
        }

        private async void SetButton_Click(object sender, EventArgs e)
        {
            DisableInteractions();

            await PatchGameSettings(_gameSettings);
            await PatchInputSettings(_inputSettings);

            MessageBox.Show("Successfully patched settings", "Success");

            EnableInteractions();
        }

        private async Task<string> FetchGameSettings()
        {
            return await _leagueClient.Request(LeagueClient.requestMethod.GET, "/lol-game-settings/v1/game-settings");
        }

        private async Task<string> FetchInputSettings()
        {
            return await _leagueClient.Request(LeagueClient.requestMethod.GET, "/lol-game-settings/v1/input-settings");
        }

        private async Task PatchGameSettings(String data)
        {
            await _leagueClient.Request(LeagueClient.requestMethod.PATCH, "/lol-game-settings/v1/game-settings", data);
        }

        private async Task PatchInputSettings(String data)
        {
            await _leagueClient.Request(LeagueClient.requestMethod.PATCH, "/lol-game-settings/v1/input-settings", data);
        }

        private void SaveSettingsToDisk()
        {
            File.WriteAllText(GameSettingsFilePath, _gameSettings);
            File.WriteAllText(InputSettingsFilePath, _inputSettings);
        }

        private void LoadSettingsFromDisk()
        {
            _gameSettings = File.ReadAllText(GameSettingsFilePath);
            _inputSettings = File.ReadAllText(InputSettingsFilePath);
        }
    }
}