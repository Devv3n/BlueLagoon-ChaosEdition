﻿namespace Blue_Lagoon___Chaos_Edition {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
            Game.mainMenu = this;
        }

        private void QuitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void StatisticsButton_Click(object sender, EventArgs e) {
            StatisticsMenu statisticsMenu = new StatisticsMenu();
            statisticsMenu.Show();
            this.Hide();
        }
    }
}