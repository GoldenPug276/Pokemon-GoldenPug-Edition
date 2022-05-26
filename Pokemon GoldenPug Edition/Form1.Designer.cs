namespace Pokemon_GoldenPug_Edition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Game = new System.Windows.Forms.Panel();
            this.EnemyHealthBar = new System.Windows.Forms.Panel();
            this.EnemyHP = new System.Windows.Forms.ProgressBar();
            this.EnemyMonName = new System.Windows.Forms.Label();
            this.EnemyLevel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PlayerHealthBar = new System.Windows.Forms.Panel();
            this.PlayerHP = new System.Windows.Forms.ProgressBar();
            this.PlayerMonName = new System.Windows.Forms.Label();
            this.PlayerMHP = new System.Windows.Forms.Label();
            this.PlayerCHP = new System.Windows.Forms.Label();
            this.PlayerLevel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BattleGUI = new System.Windows.Forms.Panel();
            this.Bag_Holder = new System.Windows.Forms.Panel();
            this.BagMoveName = new System.Windows.Forms.Label();
            this.BagMaxPP = new System.Windows.Forms.Label();
            this.BagShownPP = new System.Windows.Forms.Label();
            this.Bag = new System.Windows.Forms.Button();
            this.Pokemon_Holder = new System.Windows.Forms.Panel();
            this.PokemonMaxPP = new System.Windows.Forms.Label();
            this.PokemonShownPP = new System.Windows.Forms.Label();
            this.PokemonMoveName = new System.Windows.Forms.Label();
            this.Pokemon = new System.Windows.Forms.Button();
            this.Run_Holder = new System.Windows.Forms.Panel();
            this.RunMaxPP = new System.Windows.Forms.Label();
            this.RunShownPP = new System.Windows.Forms.Label();
            this.RunMoveName = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.Fight_Holder = new System.Windows.Forms.Panel();
            this.FightMoveName = new System.Windows.Forms.Label();
            this.FightMaxPP = new System.Windows.Forms.Label();
            this.FightShownPP = new System.Windows.Forms.Label();
            this.Fight = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PlayerPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnemyPic = new System.Windows.Forms.PictureBox();
            this.GameText = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Game.SuspendLayout();
            this.EnemyHealthBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PlayerHealthBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BattleGUI.SuspendLayout();
            this.Bag_Holder.SuspendLayout();
            this.Pokemon_Holder.SuspendLayout();
            this.Run_Holder.SuspendLayout();
            this.Fight_Holder.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPic)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Game
            // 
            this.Game.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.PBC__5_;
            this.Game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Game.Controls.Add(this.EnemyHealthBar);
            this.Game.Controls.Add(this.PlayerHealthBar);
            this.Game.Controls.Add(this.BattleGUI);
            this.Game.Controls.Add(this.panel3);
            this.Game.Controls.Add(this.panel1);
            this.Game.Controls.Add(this.GameText);
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Location = new System.Drawing.Point(0, 0);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(1225, 775);
            this.Game.TabIndex = 3;
            this.Game.Visible = false;
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealthBar.Controls.Add(this.EnemyHP);
            this.EnemyHealthBar.Controls.Add(this.EnemyMonName);
            this.EnemyHealthBar.Controls.Add(this.EnemyLevel);
            this.EnemyHealthBar.Controls.Add(this.pictureBox3);
            this.EnemyHealthBar.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealthBar.Location = new System.Drawing.Point(0, 21);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(380, 118);
            this.EnemyHealthBar.TabIndex = 7;
            // 
            // EnemyHP
            // 
            this.EnemyHP.BackColor = System.Drawing.Color.White;
            this.EnemyHP.ForeColor = System.Drawing.Color.HotPink;
            this.EnemyHP.Location = new System.Drawing.Point(156, 76);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(163, 19);
            this.EnemyHP.TabIndex = 5;
            this.EnemyHP.Value = 100;
            // 
            // EnemyMonName
            // 
            this.EnemyMonName.AutoSize = true;
            this.EnemyMonName.BackColor = System.Drawing.Color.White;
            this.EnemyMonName.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyMonName.Location = new System.Drawing.Point(30, 35);
            this.EnemyMonName.Name = "EnemyMonName";
            this.EnemyMonName.Size = new System.Drawing.Size(72, 25);
            this.EnemyMonName.TabIndex = 4;
            this.EnemyMonName.Text = "label3";
            // 
            // EnemyLevel
            // 
            this.EnemyLevel.AutoSize = true;
            this.EnemyLevel.BackColor = System.Drawing.Color.White;
            this.EnemyLevel.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLevel.Location = new System.Drawing.Point(263, 35);
            this.EnemyLevel.Name = "EnemyLevel";
            this.EnemyLevel.Size = new System.Drawing.Size(72, 25);
            this.EnemyLevel.TabIndex = 1;
            this.EnemyLevel.Text = "label3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Pokemon_GoldenPug_Edition.Properties.Resources.Empty_Enemy_Health_Bar;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(380, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealthBar.Controls.Add(this.PlayerHP);
            this.PlayerHealthBar.Controls.Add(this.PlayerMonName);
            this.PlayerHealthBar.Controls.Add(this.PlayerMHP);
            this.PlayerHealthBar.Controls.Add(this.PlayerCHP);
            this.PlayerHealthBar.Controls.Add(this.PlayerLevel);
            this.PlayerHealthBar.Controls.Add(this.pictureBox2);
            this.PlayerHealthBar.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHealthBar.Location = new System.Drawing.Point(828, 439);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(397, 151);
            this.PlayerHealthBar.TabIndex = 6;
            // 
            // PlayerHP
            // 
            this.PlayerHP.BackColor = System.Drawing.Color.White;
            this.PlayerHP.ForeColor = System.Drawing.Color.HotPink;
            this.PlayerHP.Location = new System.Drawing.Point(201, 72);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(163, 15);
            this.PlayerHP.TabIndex = 5;
            this.PlayerHP.Value = 100;
            // 
            // PlayerMonName
            // 
            this.PlayerMonName.AutoSize = true;
            this.PlayerMonName.BackColor = System.Drawing.Color.White;
            this.PlayerMonName.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMonName.Location = new System.Drawing.Point(99, 28);
            this.PlayerMonName.Name = "PlayerMonName";
            this.PlayerMonName.Size = new System.Drawing.Size(72, 25);
            this.PlayerMonName.TabIndex = 4;
            this.PlayerMonName.Text = "label3";
            // 
            // PlayerMHP
            // 
            this.PlayerMHP.AutoSize = true;
            this.PlayerMHP.BackColor = System.Drawing.Color.White;
            this.PlayerMHP.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMHP.Location = new System.Drawing.Point(313, 101);
            this.PlayerMHP.Name = "PlayerMHP";
            this.PlayerMHP.Size = new System.Drawing.Size(72, 25);
            this.PlayerMHP.TabIndex = 3;
            this.PlayerMHP.Text = "label3";
            // 
            // PlayerCHP
            // 
            this.PlayerCHP.AutoSize = true;
            this.PlayerCHP.BackColor = System.Drawing.Color.White;
            this.PlayerCHP.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCHP.Location = new System.Drawing.Point(209, 97);
            this.PlayerCHP.Name = "PlayerCHP";
            this.PlayerCHP.Size = new System.Drawing.Size(72, 25);
            this.PlayerCHP.TabIndex = 2;
            this.PlayerCHP.Text = "label3";
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.AutoSize = true;
            this.PlayerLevel.BackColor = System.Drawing.Color.White;
            this.PlayerLevel.Font = new System.Drawing.Font("Pokemon Pixel Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLevel.Location = new System.Drawing.Point(322, 28);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(72, 25);
            this.PlayerLevel.TabIndex = 1;
            this.PlayerLevel.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Pokemon_GoldenPug_Edition.Properties.Resources.Empty_Player_Health_Bar;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(397, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BattleGUI
            // 
            this.BattleGUI.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.Fight_GUI;
            this.BattleGUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BattleGUI.Controls.Add(this.Bag_Holder);
            this.BattleGUI.Controls.Add(this.Pokemon_Holder);
            this.BattleGUI.Controls.Add(this.Run_Holder);
            this.BattleGUI.Controls.Add(this.Fight_Holder);
            this.BattleGUI.Location = new System.Drawing.Point(793, 612);
            this.BattleGUI.Name = "BattleGUI";
            this.BattleGUI.Size = new System.Drawing.Size(324, 140);
            this.BattleGUI.TabIndex = 5;
            // 
            // Bag_Holder
            // 
            this.Bag_Holder.BackColor = System.Drawing.Color.Transparent;
            this.Bag_Holder.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.BAG;
            this.Bag_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bag_Holder.Controls.Add(this.BagMoveName);
            this.Bag_Holder.Controls.Add(this.BagMaxPP);
            this.Bag_Holder.Controls.Add(this.BagShownPP);
            this.Bag_Holder.Controls.Add(this.Bag);
            this.Bag_Holder.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bag_Holder.Location = new System.Drawing.Point(165, 2);
            this.Bag_Holder.Name = "Bag_Holder";
            this.Bag_Holder.Size = new System.Drawing.Size(156, 65);
            this.Bag_Holder.TabIndex = 9;
            // 
            // BagMoveName
            // 
            this.BagMoveName.AutoSize = true;
            this.BagMoveName.BackColor = System.Drawing.Color.Transparent;
            this.BagMoveName.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagMoveName.Location = new System.Drawing.Point(20, 17);
            this.BagMoveName.Name = "BagMoveName";
            this.BagMoveName.Size = new System.Drawing.Size(43, 14);
            this.BagMoveName.TabIndex = 8;
            this.BagMoveName.Text = "label3";
            this.BagMoveName.Visible = false;
            // 
            // BagMaxPP
            // 
            this.BagMaxPP.AutoSize = true;
            this.BagMaxPP.Location = new System.Drawing.Point(113, 36);
            this.BagMaxPP.Name = "BagMaxPP";
            this.BagMaxPP.Size = new System.Drawing.Size(43, 14);
            this.BagMaxPP.TabIndex = 2;
            this.BagMaxPP.Text = "label3";
            this.BagMaxPP.Visible = false;
            // 
            // BagShownPP
            // 
            this.BagShownPP.AutoSize = true;
            this.BagShownPP.Location = new System.Drawing.Point(90, 34);
            this.BagShownPP.Name = "BagShownPP";
            this.BagShownPP.Size = new System.Drawing.Size(43, 14);
            this.BagShownPP.TabIndex = 1;
            this.BagShownPP.Text = "label3";
            this.BagShownPP.Visible = false;
            // 
            // Bag
            // 
            this.Bag.BackColor = System.Drawing.Color.Transparent;
            this.Bag.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.BAG;
            this.Bag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bag.Location = new System.Drawing.Point(0, 0);
            this.Bag.Name = "Bag";
            this.Bag.Size = new System.Drawing.Size(156, 65);
            this.Bag.TabIndex = 0;
            this.Bag.UseVisualStyleBackColor = false;
            this.Bag.Click += new System.EventHandler(this.Bag_Click);
            // 
            // Pokemon_Holder
            // 
            this.Pokemon_Holder.BackColor = System.Drawing.Color.Transparent;
            this.Pokemon_Holder.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.POKEMON;
            this.Pokemon_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pokemon_Holder.Controls.Add(this.PokemonMaxPP);
            this.Pokemon_Holder.Controls.Add(this.PokemonShownPP);
            this.Pokemon_Holder.Controls.Add(this.PokemonMoveName);
            this.Pokemon_Holder.Controls.Add(this.Pokemon);
            this.Pokemon_Holder.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pokemon_Holder.Location = new System.Drawing.Point(4, 74);
            this.Pokemon_Holder.Name = "Pokemon_Holder";
            this.Pokemon_Holder.Size = new System.Drawing.Size(156, 65);
            this.Pokemon_Holder.TabIndex = 6;
            // 
            // PokemonMaxPP
            // 
            this.PokemonMaxPP.AutoSize = true;
            this.PokemonMaxPP.Location = new System.Drawing.Point(111, 34);
            this.PokemonMaxPP.Name = "PokemonMaxPP";
            this.PokemonMaxPP.Size = new System.Drawing.Size(43, 14);
            this.PokemonMaxPP.TabIndex = 3;
            this.PokemonMaxPP.Text = "label3";
            this.PokemonMaxPP.Visible = false;
            // 
            // PokemonShownPP
            // 
            this.PokemonShownPP.AutoSize = true;
            this.PokemonShownPP.Location = new System.Drawing.Point(85, 32);
            this.PokemonShownPP.Name = "PokemonShownPP";
            this.PokemonShownPP.Size = new System.Drawing.Size(43, 14);
            this.PokemonShownPP.TabIndex = 2;
            this.PokemonShownPP.Text = "label3";
            this.PokemonShownPP.Visible = false;
            // 
            // PokemonMoveName
            // 
            this.PokemonMoveName.AutoSize = true;
            this.PokemonMoveName.Location = new System.Drawing.Point(17, 18);
            this.PokemonMoveName.Name = "PokemonMoveName";
            this.PokemonMoveName.Size = new System.Drawing.Size(43, 14);
            this.PokemonMoveName.TabIndex = 1;
            this.PokemonMoveName.Text = "label3";
            this.PokemonMoveName.Visible = false;
            // 
            // Pokemon
            // 
            this.Pokemon.BackColor = System.Drawing.Color.Transparent;
            this.Pokemon.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.POKEMON;
            this.Pokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pokemon.Location = new System.Drawing.Point(0, 0);
            this.Pokemon.Name = "Pokemon";
            this.Pokemon.Size = new System.Drawing.Size(156, 65);
            this.Pokemon.TabIndex = 0;
            this.Pokemon.UseVisualStyleBackColor = false;
            this.Pokemon.Click += new System.EventHandler(this.Pokemon_Click);
            // 
            // Run_Holder
            // 
            this.Run_Holder.BackColor = System.Drawing.Color.Transparent;
            this.Run_Holder.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.RUN;
            this.Run_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Run_Holder.Controls.Add(this.RunMaxPP);
            this.Run_Holder.Controls.Add(this.RunShownPP);
            this.Run_Holder.Controls.Add(this.RunMoveName);
            this.Run_Holder.Controls.Add(this.Run);
            this.Run_Holder.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_Holder.Location = new System.Drawing.Point(166, 74);
            this.Run_Holder.Name = "Run_Holder";
            this.Run_Holder.Size = new System.Drawing.Size(156, 65);
            this.Run_Holder.TabIndex = 7;
            // 
            // RunMaxPP
            // 
            this.RunMaxPP.AutoSize = true;
            this.RunMaxPP.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunMaxPP.Location = new System.Drawing.Point(112, 37);
            this.RunMaxPP.Name = "RunMaxPP";
            this.RunMaxPP.Size = new System.Drawing.Size(43, 14);
            this.RunMaxPP.TabIndex = 3;
            this.RunMaxPP.Text = "label3";
            this.RunMaxPP.Visible = false;
            // 
            // RunShownPP
            // 
            this.RunShownPP.AutoSize = true;
            this.RunShownPP.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunShownPP.Location = new System.Drawing.Point(82, 36);
            this.RunShownPP.Name = "RunShownPP";
            this.RunShownPP.Size = new System.Drawing.Size(43, 14);
            this.RunShownPP.TabIndex = 2;
            this.RunShownPP.Text = "label3";
            this.RunShownPP.Visible = false;
            // 
            // RunMoveName
            // 
            this.RunMoveName.AutoSize = true;
            this.RunMoveName.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunMoveName.Location = new System.Drawing.Point(13, 19);
            this.RunMoveName.Name = "RunMoveName";
            this.RunMoveName.Size = new System.Drawing.Size(43, 14);
            this.RunMoveName.TabIndex = 1;
            this.RunMoveName.Text = "label3";
            this.RunMoveName.Visible = false;
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.Transparent;
            this.Run.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.RUN;
            this.Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Run.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(0, 0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(156, 65);
            this.Run.TabIndex = 0;
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Fight_Holder
            // 
            this.Fight_Holder.BackColor = System.Drawing.Color.Transparent;
            this.Fight_Holder.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.FIGHT;
            this.Fight_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fight_Holder.Controls.Add(this.FightMoveName);
            this.Fight_Holder.Controls.Add(this.FightMaxPP);
            this.Fight_Holder.Controls.Add(this.FightShownPP);
            this.Fight_Holder.Controls.Add(this.Fight);
            this.Fight_Holder.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fight_Holder.Location = new System.Drawing.Point(4, 1);
            this.Fight_Holder.Name = "Fight_Holder";
            this.Fight_Holder.Size = new System.Drawing.Size(156, 65);
            this.Fight_Holder.TabIndex = 4;
            // 
            // FightMoveName
            // 
            this.FightMoveName.AutoSize = true;
            this.FightMoveName.BackColor = System.Drawing.Color.Transparent;
            this.FightMoveName.Font = new System.Drawing.Font("Pokemon Pixel Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FightMoveName.Location = new System.Drawing.Point(20, 17);
            this.FightMoveName.Name = "FightMoveName";
            this.FightMoveName.Size = new System.Drawing.Size(43, 14);
            this.FightMoveName.TabIndex = 8;
            this.FightMoveName.Text = "label3";
            this.FightMoveName.Visible = false;
            // 
            // FightMaxPP
            // 
            this.FightMaxPP.AutoSize = true;
            this.FightMaxPP.Location = new System.Drawing.Point(113, 36);
            this.FightMaxPP.Name = "FightMaxPP";
            this.FightMaxPP.Size = new System.Drawing.Size(43, 14);
            this.FightMaxPP.TabIndex = 2;
            this.FightMaxPP.Text = "label3";
            this.FightMaxPP.Visible = false;
            // 
            // FightShownPP
            // 
            this.FightShownPP.AutoSize = true;
            this.FightShownPP.Location = new System.Drawing.Point(90, 34);
            this.FightShownPP.Name = "FightShownPP";
            this.FightShownPP.Size = new System.Drawing.Size(43, 14);
            this.FightShownPP.TabIndex = 1;
            this.FightShownPP.Text = "label3";
            this.FightShownPP.Visible = false;
            // 
            // Fight
            // 
            this.Fight.BackColor = System.Drawing.Color.Transparent;
            this.Fight.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.FIGHT;
            this.Fight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fight.Location = new System.Drawing.Point(0, 0);
            this.Fight.Name = "Fight";
            this.Fight.Size = new System.Drawing.Size(156, 65);
            this.Fight.TabIndex = 0;
            this.Fight.UseVisualStyleBackColor = false;
            this.Fight.Click += new System.EventHandler(this.Fight_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, -138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 703);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.PlayerPic);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(-15, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 703);
            this.panel4.TabIndex = 0;
            // 
            // PlayerPic
            // 
            this.PlayerPic.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerPic.Location = new System.Drawing.Point(0, 305);
            this.PlayerPic.Name = "PlayerPic";
            this.PlayerPic.Size = new System.Drawing.Size(508, 398);
            this.PlayerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPic.TabIndex = 1;
            this.PlayerPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(555, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 371);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.EnemyPic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(-33, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 371);
            this.panel2.TabIndex = 0;
            // 
            // EnemyPic
            // 
            this.EnemyPic.BackColor = System.Drawing.Color.Transparent;
            this.EnemyPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EnemyPic.Location = new System.Drawing.Point(0, 3);
            this.EnemyPic.Name = "EnemyPic";
            this.EnemyPic.Size = new System.Drawing.Size(501, 368);
            this.EnemyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyPic.TabIndex = 1;
            this.EnemyPic.TabStop = false;
            // 
            // GameText
            // 
            this.GameText.AutoSize = true;
            this.GameText.BackColor = System.Drawing.Color.Transparent;
            this.GameText.Font = new System.Drawing.Font("Pokemon Pixel Font", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameText.Location = new System.Drawing.Point(50, 612);
            this.GameText.MaximumSize = new System.Drawing.Size(1075, 0);
            this.GameText.Name = "GameText";
            this.GameText.Size = new System.Drawing.Size(504, 42);
            this.GameText.TabIndex = 0;
            this.GameText.Text = "Instructor Stan wants to battle!";
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImage = global::Pokemon_GoldenPug_Edition.Properties.Resources.Background;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenu.Controls.Add(this.label2);
            this.MainMenu.Controls.Add(this.label1);
            this.MainMenu.Controls.Add(this.pictureBox1);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1225, 775);
            this.MainMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "-PRESS ENTER-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(350, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "GoldenPug Edition";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pokemon_GoldenPug_Edition.Properties.Resources.Pokemon_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(283, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 775);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1241, 814);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1241, 814);
            this.Name = "Form1";
            this.Text = "Pokemon: GoldenPug Edition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.EnemyHealthBar.ResumeLayout(false);
            this.EnemyHealthBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PlayerHealthBar.ResumeLayout(false);
            this.PlayerHealthBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BattleGUI.ResumeLayout(false);
            this.Bag_Holder.ResumeLayout(false);
            this.Bag_Holder.PerformLayout();
            this.Pokemon_Holder.ResumeLayout(false);
            this.Pokemon_Holder.PerformLayout();
            this.Run_Holder.ResumeLayout(false);
            this.Run_Holder.PerformLayout();
            this.Fight_Holder.ResumeLayout(false);
            this.Fight_Holder.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPic)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Game;
        private System.Windows.Forms.Label GameText;
        private System.Windows.Forms.PictureBox EnemyPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PlayerPic;
        private System.Windows.Forms.Panel BattleGUI;
        private System.Windows.Forms.Button Fight;
        private System.Windows.Forms.Panel PlayerHealthBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PlayerLevel;
        private System.Windows.Forms.Label PlayerMonName;
        private System.Windows.Forms.Label PlayerMHP;
        private System.Windows.Forms.Label PlayerCHP;
        private System.Windows.Forms.ProgressBar PlayerHP;
        private System.Windows.Forms.Panel EnemyHealthBar;
        private System.Windows.Forms.ProgressBar EnemyHP;
        private System.Windows.Forms.Label EnemyMonName;
        private System.Windows.Forms.Label EnemyLevel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Fight_Holder;
        private System.Windows.Forms.Panel Pokemon_Holder;
        private System.Windows.Forms.Button Pokemon;
        private System.Windows.Forms.Panel Run_Holder;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label FightMoveName;
        private System.Windows.Forms.Label FightMaxPP;
        private System.Windows.Forms.Label FightShownPP;
        private System.Windows.Forms.Panel Bag_Holder;
        private System.Windows.Forms.Label BagMoveName;
        private System.Windows.Forms.Label BagMaxPP;
        private System.Windows.Forms.Label BagShownPP;
        private System.Windows.Forms.Button Bag;
        private System.Windows.Forms.Label PokemonMaxPP;
        private System.Windows.Forms.Label PokemonShownPP;
        private System.Windows.Forms.Label PokemonMoveName;
        private System.Windows.Forms.Label RunMaxPP;
        private System.Windows.Forms.Label RunShownPP;
        private System.Windows.Forms.Label RunMoveName;
    }
}

