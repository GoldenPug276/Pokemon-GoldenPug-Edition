using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pokemon_GoldenPug_Edition
{

    public partial class Form1 : Form
    {
        Move[] moves = new Move[40];
        Pokemon[] pokemons = new Pokemon[10];
        Random rand = new Random();
        int releaseStage = 1;
        int postAttack = 1;
        bool action = false;
        int playerMon = 999999999;
        int enemyMon = 999999999;
        bool fighting = false;
        int end = 0;
        bool endBool = false;

        bool isCrit = false;
        bool isMiss = false;
        bool PlayerAttacked = false;
        bool EnemyAttacked = false;
        int PotentialPlayerMove = 0;

        public static Font PokeFont1;
        public static Font PokeFont2;
        /*TO-DO:
         * Sell my Soul to Satan
         * Make it Look Good
         * Code the Darn Thing
         *PLAN:
         * Title Screen
         * Each person gets a random Pokemon that they can have
         * Have variables for most others that change during the game
         * Make it look like a Pokemon Game
           Have move and stat mechanics like in a Pokemon Game*/
        public Form1()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/PokemonSolidNormal-xyWR.ttf");
            PokeFont1 = new Font(pfc.Families[0], 40);
            pfc.AddFontFile("../../Resources/BwSatellite-K5Ye.ttf");
            PokeFont2 = new Font(pfc.Families[0], 30);
            label1.Font = PokeFont1;
            label2.Font = PokeFont2;
            label1.Padding = new Padding(-10);
            /*Move Resource Bank
             * Properties.Resources.Fight_Move
             * Properties.Resources.Normal_Move
             * Properties.Resources.Dark_Move
             * Properties.Resources.Ice_Move
             * Properties.Resources.Flying_Move
             * Properties.Resources.Water_Move
             * Properties.Resources.Bug_Move
             * Properties.Resources.Fire_Move
             * Properties.Resources.Ghost_Move
             * Properties.Resources.Grass_Move
             * Properties.Resources.Ground_Move
             * Properties.Resources.Dragon_Move
             * Properties.Resources.Electric_Move
             * Properties.Resources.Poison_Move
             */
            //Use other program I made
            moves[0] = new Move("Superpower", "Fighting", "Physical", 120, 100, 5, 5, Properties.Resources.Fighting_Move, 0);
            moves[1] = new Move("Hyper Fang", "Normal", "Physical", 80, 90, 15, 15, Properties.Resources.Normal_Move, 1);
            moves[2] = new Move("Crunch", "Dark", "Physical", 80, 100, 15, 15, Properties.Resources.Dark_Move, 2);
            moves[3] = new Move("Ice Beam", "Ice", "Special", 90, 100, 10, 10, Properties.Resources.Ice_Move, 3);
            moves[4] = new Move("Bounce", "Flying", "Physical", 85, 85, 5, 5, Properties.Resources.Flying_Move, 4);
            moves[5] = new Move("Tackle", "Normal", "Physical", 40, 100, 35, 35, Properties.Resources.Normal_Move, 5);
            moves[6] = new Move("Hydro Pump", "Water", "Special", 110, 80, 5, 5, Properties.Resources.Water_Move, 6);
            moves[7] = new Move("Splash", "Normal", "Physical", 0, 0, 40, 40, Properties.Resources.Normal_Move, 7);
            moves[8] = new Move("Dark Pulse", "Dark", "Special", 80, 100, 15, 15, Properties.Resources.Dark_Move, 8);
            moves[9] = new Move("Shadow Ball", "Ghost", "Special", 80, 100, 15, 15, Properties.Resources.Ghost_Move, 9);
            moves[10] = new Move("Thunder Punch", "Electric", "Physical", 75, 100, 15, 15, Properties.Resources.Electric_Move, 10);
            moves[11] = new Move("Brick Break", "Fighting", "Physical", 75, 100, 15, 15, Properties.Resources.Fighting_Move, 11);
            moves[12] = new Move("Aura Sphere", "Fighting", "Special", 80, 100, 20, 20, Properties.Resources.Fighting_Move, 12);
            moves[13] = new Move("Quick Attack", "Normal", "Physical", 40, 100, 30, 30, Properties.Resources.Normal_Move, 13);
            moves[14] = new Move("Dragon Pulse", "Dragon", "Special", 85, 100, 10, 10, Properties.Resources.Dragon_Move, 14);
            moves[15] = new Move("Meteor Mash", "Steel", "Physical", 90, 90, 10, 10, Properties.Resources.Steel_Move, 15);
            moves[16] = new Move("Roar of Time", "Dragon", "Special", 150, 90, 5, 5, Properties.Resources.Dragon_Move, 16);
            moves[17] = new Move("Breaking Swipe", "Dragon", "Physical", 60, 100, 15, 15, Properties.Resources.Dragon_Move, 17);
            moves[18] = new Move("Body Press", "Fighting", "Physical", 80, 100, 10, 10, Properties.Resources.Fighting_Move, 18);
            moves[19] = new Move("Flash Cannon", "Steel", "Special", 80, 100, 10, 10, Properties.Resources.Steel_Move, 19);
            moves[20] = new Move("Dragon Claw", "Dragon", "Physical", 80, 100, 15, 15, Properties.Resources.Dragon_Move, 20);
            moves[21] = new Move("Bulldoze", "Ground", "Physical", 60, 100, 20, 20, Properties.Resources.Ground_Move, 21);
            moves[22] = new Move("Hyper Voice", "Normal", "Special", 90, 100, 10, 10, Properties.Resources.Normal_Move, 22);
            moves[23] = new Move("Horn Drill", "Normal", "Physical", 99999, 30, 5, 5, Properties.Resources.Normal_Move, 23);
            moves[24] = new Move("Stone Edge", "Rock", "Physical", 100, 80, 5, 5, Properties.Resources.Rock_Move, 24);
            moves[25] = new Move("Hurricane", "Flying", "Special", 110, 70, 10, 10, Properties.Resources.Flying_Move, 25);
            moves[26] = new Move("Iron Tail", "Steel", "Physical", 100, 75, 15, 15, Properties.Resources.Steel_Move, 26);
            moves[27] = new Move("Rock Slide", "Rock", "Physical", 75, 90, 10, 10, Properties.Resources.Rock_Move, 27);
            moves[28] = new Move("Flare Blitz", "Fire", "Physical", 120, 100, 15, 15, Properties.Resources.Fire_Move, 28);
            moves[29] = new Move("Inferno", "Fire", "Special", 100, 50, 5, 5, Properties.Resources.Fire_Move, 29);
            moves[30] = new Move("Blaze Kick", "Fire", "Physical", 85, 90, 10, 10, Properties.Resources.Fire_Move, 30);
            moves[31] = new Move("Overheat", "Fire", "Special", 130, 90, 5, 5, Properties.Resources.Fire_Move, 31);
            moves[32] = new Move("Psychic", "Psychic", "Special", 90, 100, 10, 10, Properties.Resources.Psychic_Move, 32);
            moves[33] = new Move("Psycho Cut", "Psychic", "Physical", 70, 100, 20, 20, Properties.Resources.Psychic_Move, 33);
            moves[34] = new Move("Zen Headbutt", "Psychic", "Physical", 80, 90, 15, 15, Properties.Resources.Psychic_Move, 34);
            moves[35] = new Move("Earthquake", "Ground", "Physical", 100, 100, 10, 10, Properties.Resources.Ground_Move, 35);
            moves[36] = new Move("Psyshock", "Psychic", "Special", 80, 100, 10, 10, Properties.Resources.Psychic_Move, 36);
            moves[37] = new Move("Focus Blast", "Fighting", "Special", 120, 70, 5, 5, Properties.Resources.Fighting_Move, 37);
            moves[38] = new Move("Shadow Ball", "Ghost", "Special", 80, 100, 15, 15, Properties.Resources.Ghost_Move, 38);
            moves[39] = new Move("Mega Kick", "Normal", "Physical", 120, 75, 5, 5, Properties.Resources.Normal_Move, 39);
            pokemons[0] = new Pokemon("Bidoof", HPCalculation(59), AttackCalculation(45), DefenseCalculation(40), SpAttackCalculation(35), SpDefenseCalculation(40), SpeedCalculation(31),
                100, "Normal", "Normal", Properties.Resources.bidoof_front, Properties.Resources.bidoof_back, moves[0], moves[1], moves[2], moves[3], 100);
            pokemons[1] = new Pokemon("Magikarp", HPCalculation(20), AttackCalculation(10), DefenseCalculation(55), SpAttackCalculation(15), SpDefenseCalculation(20), SpeedCalculation(80),
                100, "Water", "Water", Properties.Resources.magikarp_front, Properties.Resources.magikarp_back, moves[4], moves[5], moves[6], moves[7], 150);
            pokemons[2] = new Pokemon("Mega Gengar", HPCalculation(60), AttackCalculation(65), DefenseCalculation(80), SpAttackCalculation(170), SpDefenseCalculation(95), SpeedCalculation(130),
                100, "Ghost", "Poison", Properties.Resources.gengar_mega_front, Properties.Resources.gengar_mega_back, moves[8], moves[9], moves[10], moves[11], 300);
            pokemons[3] = new Pokemon("Mega Lucario", HPCalculation(70), AttackCalculation(145), DefenseCalculation(88), SpAttackCalculation(140), SpDefenseCalculation(70), SpeedCalculation(112),
                100, "Fighting", "Steel", Properties.Resources.lucario_mega_front, Properties.Resources.lucario_mega_back, moves[12], moves[13], moves[14], moves[15], 275);

            pokemons[4] = new Pokemon("Dialga", HPCalculation(100), AttackCalculation(120), DefenseCalculation(120), SpAttackCalculation(150), SpDefenseCalculation(100), SpeedCalculation(90), 100,
                "Steel", "Dragon", Properties.Resources.dialga_front, Properties.Resources.dialga_back, moves[16], moves[17], moves[18], moves[19], 400);

            pokemons[5] = new Pokemon("Tyrantrum", HPCalculation(82), AttackCalculation(121), DefenseCalculation(119), SpAttackCalculation(69), SpDefenseCalculation(59), SpeedCalculation(71),
                100, "Rock", "Dragon", Properties.Resources.tyrantrum_front, Properties.Resources.tyrantrum_back, moves[20], moves[21], moves[22], moves[23], 425);
            pokemons[6] = new Pokemon("Mega Aerodactyl", HPCalculation(80), AttackCalculation(135), DefenseCalculation(85), SpAttackCalculation(70), SpDefenseCalculation(95), SpeedCalculation(150),
                100, "Rock", "Flying", Properties.Resources.aerodactyl_mega_front, Properties.Resources.aerodactyl_mega_back, moves[24], moves[25], moves[26], moves[27], 400);
            pokemons[7] = new Pokemon("Mega Charizard X", HPCalculation(78), AttackCalculation(130), DefenseCalculation(111), SpAttackCalculation(130), SpDefenseCalculation(85), SpeedCalculation(100),
                100, "Fire", "Dragon", Properties.Resources.charizard_megax_front, Properties.Resources.charizard_megax_back, moves[28], moves[29], moves[30], moves[31], 400);

            pokemons[8] = new Pokemon("Mewtwo", HPCalculation(106), AttackCalculation(110), DefenseCalculation(90), SpAttackCalculation(154), SpDefenseCalculation(90), SpeedCalculation(130),
                100, "Psychic", "Psychic", Properties.Resources.mewtwo_front, Properties.Resources.mewtwo_back, moves[32], moves[33], moves[34], moves[35], 250);

            pokemons[9] = new Pokemon("Gardevoir", HPCalculation(68), AttackCalculation(65), DefenseCalculation(65), SpAttackCalculation(125), SpDefenseCalculation(115), SpeedCalculation(80),
                100, "Psychic", "Fairy", Properties.Resources.gardevoir_front, Properties.Resources.gardevoir_back, moves[36], moves[37], moves[38], moves[39], 250);
        }
        public int HPCalculation(int stat)
        {
            int EV=rand.Next(0, 253);
            int IV = rand.Next(0, 32);
            int final = ((((2 * stat + IV + (EV / 4)) * 100) / 100) + 100 + 10);
            return final;
        }
        public int AttackCalculation(int stat)
        {
            int EV = rand.Next(0, 253);
            int IV = rand.Next(0, 32);
            int final = ((((2 * stat + IV + (EV / 4)) * 100) / 100) + 5);
            return final;
        }
        public int DefenseCalculation(int stat)
        {
            int EV = rand.Next(0, 253);
            int IV = rand.Next(0, 32);
            int final = ((((2 * stat + IV + (EV / 4)) * 100) / 100) + 5);
            return final;
        }
        public int SpAttackCalculation(int stat)
        {
            int EV = rand.Next(0, 253);
            int IV = rand.Next(0, 32);
            int final = ((((2 * stat + IV + (EV / 4)) * 100) / 100) + 5);
            return final;
        }
        public int SpDefenseCalculation(int stat)
        {
            int EV = rand.Next(0, 253);
            int IV = rand.Next(0, 32);
            int final = ((((2 * stat + IV + (EV / 4)) * 100) / 100) + 5);
            return final;
        }
        public int SpeedCalculation(int stat)
        {
            int EV = rand.Next(0, 253);
            int IV = rand.Next(0, 32);
            int final = ((((2 * stat + IV + (EV / 4)) * 100) / 100) + 5);
            return final;
        }


        public int DamageCalculation(int attacker, int defender, int moveNumber, string HPDefender, out bool isCrit)
        {
            int critChance = rand.Next(1, 17);
            int crit = 1;
            isCrit = false;
            if (critChance==6)
            {
                crit = 2;
                isCrit = true;
            }
            int STAB = 1;
            if (pokemons[attacker].GetPokemonType1()==moves[moveNumber].GetMoveType()||pokemons[attacker].GetPokemonType2()==moves[moveNumber].GetMoveType())
            {
                STAB = 2;
            }
            int type = 1;
            double randome=rand.NextDouble() % .16 + .85;
            double modifier = (1*1*1*crit*randome*STAB*type*1*1);
            int attack = 0;
            int defense = 0;
            if (moves[moveNumber].GetCategory()=="Physical")
            {
                attack = pokemons[attacker].GetAttack();
                defense = pokemons[defender].GetDefense();
            }
            else if (moves[moveNumber].GetCategory()=="Special")
            {
                attack = pokemons[attacker].GetSpecialAttack();
                defense = pokemons[defender].GetSpecialDefense();
            }
            double final = ((((((2*pokemons[attacker].GetLevel()/5)+2)*moves[moveNumber].GetPower()*(attack/defense))/50)+2)*modifier);
            int final2 = (int)Math.Floor(final);
            if (final2>=EnemyHP.Value && HPDefender=="Enemy")
            {
                final2 = EnemyHP.Value;
            }
            if (final2>=PlayerHP.Value && HPDefender=="Player")
            {
                final2 = PlayerHP.Value;
            }
            return final2;
        }
        public void PlayerAttack(int moveNumber, out bool isCrit, out bool isMiss)
        {
            PlayerAttacked = true;
            BattleGUI.Visible = false;
            BattleGUI.Enabled = false;
            postAttack = 1;
            isCrit = false;
            isMiss = false;
            GameText.Text = $"{pokemons[playerMon].GetName()} used {moves[moveNumber].GetName()}!";
            if (rand.Next(1, 101)>moves[moveNumber].GetAccuracy() && moves[moveNumber].GetAccuracy()!=100)
            {
                isMiss = true;
            }
            else
            {
                EnemyHP.Value = EnemyHP.Value - DamageCalculation(playerMon, enemyMon, moveNumber, "Enemy", out isCrit);
            }
            moves[moveNumber].PPModifier();
        }

        public void EnemyAttack(out bool isCrit, out bool isMiss)
        {
            EnemyAttacked = true;
            BattleGUI.Visible = false;
            BattleGUI.Enabled = false;
            postAttack = 1;
            isCrit = false;
            isMiss = false;
            int moveNumber = rand.Next(enemyMon*4, (enemyMon+1)*4);
            GameText.Text = $"{pokemons[enemyMon].GetName()} used {moves[moveNumber].GetName()}!";
            if (rand.Next(1, 101) > moves[moveNumber].GetAccuracy() && moves[moveNumber].GetAccuracy()!=100)
            {
                isMiss = true;
            }
            else
            {
                PlayerHP.Value = PlayerHP.Value - DamageCalculation(enemyMon, playerMon, moveNumber, "Player", out isCrit);
                PlayerCHP.Text = $"{PlayerHP.Value}";
            }
            moves[moveNumber].PPModifier();
        }

        public void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {

            }
        }
        public void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && MainMenu.Visible==true)
            {
                MainMenu.Visible = false;
                Game.Visible = true;
                GameText.Text = "Instructor Stan wants to battle!";
                BattleGUI.Enabled = false;
                BattleGUI.Visible = false;
                PlayerHealthBar.Visible = false;
                EnemyHealthBar.Visible = false;
                int phil = rand.Next(0, 6);
                playerMon = phil;
                phil = rand.Next(0, 10);
                while (phil != 0 && phil != 1 && phil != 6 && phil != 7 && phil != 8 && phil != 9)
                {
                    phil = rand.Next(0, 10);
                }
                enemyMon = phil;
            }
            else if (e.KeyCode==Keys.Enter)
            {
                switch (releaseStage)
                {
                    case 1:

                        GameText.Text = $"Instructor Stan sent out {pokemons[enemyMon].GetName()}.";
                        Game.BackgroundImage = Properties.Resources.PBC__1_;
                        EnemyPic.Width = pokemons[enemyMon].GetAssSize();
                        EnemyPic.Height = pokemons[enemyMon].GetAssSize();
                        panel2.Width = pokemons[enemyMon].GetAssSize();
                        EnemyPic.Image = pokemons[enemyMon].GetSprite();
                        EnemyHealthBar.Visible = true;
                        EnemyHP.Maximum = pokemons[enemyMon].GetHealth();
                        EnemyHP.Value = EnemyHP.Maximum;
                        EnemyLevel.Text = pokemons[enemyMon].GetLevel().ToString();
                        EnemyMonName.Text = pokemons[enemyMon].GetName().ToString();
                        releaseStage++;
                        break;
                    case 2:
                        GameText.Text = $"Badass Daniel sent out {pokemons[playerMon].GetName()}.";
                        Game.BackgroundImage = Properties.Resources.PBC__2_;
                        PlayerPic.Width = pokemons[playerMon].GetAssSize();
                        PlayerPic.Height = pokemons[playerMon].GetAssSize();
                        panel4.Width = pokemons[playerMon].GetAssSize();
                        PlayerPic.Image = pokemons[playerMon].GetAssPic();
                        PlayerHealthBar.Visible = true;
                        PlayerHP.Maximum = pokemons[playerMon].GetHealth();
                        PlayerHP.Value = PlayerHP.Maximum;
                        PlayerCHP.Text = PlayerHP.Maximum.ToString();
                        PlayerMHP.Text = PlayerHP.Maximum.ToString();
                        PlayerLevel.Text = pokemons[playerMon].GetLevel().ToString();
                        PlayerMonName.Text = pokemons[playerMon].GetName().ToString();
                        releaseStage++;
                        break;
                    case 3:
                        BattleGUI.Visible = true;
                        BattleGUI.Enabled = true;
                        GameText.Text = "What will you do?";
                        releaseStage = 0;
                        break;
                }
                if (action==true && fighting==false)
                {
                    BattleGUI.Visible = true;
                    BattleGUI.Enabled = true;
                    GameText.Text = "What will you do?";
                    action = false;
                }
                else if (fighting==true)
                {
                    switch (postAttack)
                    {
                        case 1:
                            if (isMiss==false)
                            {
                                GameText.Text = "The move was effective! If it was Splash, nothing happened!";
                                postAttack++;
                            }
                            else
                            {
                                GameText.Text = ("The attack missed!");
                                postAttack = 3;
                            }
                            break;

                        case 2:
                            if (isCrit==true)
                            {
                                GameText.Text = "Critial hit!";
                            }
                            postAttack++;
                            break;

                        case 3:
                            if (EnemyHP.Value == 0 || PlayerHP.Value == 0)
                            {
                                if (PlayerHP.Value==0)
                                {
                                    GameText.Text = ($"{pokemons[playerMon].GetName()} fainted.");
                                    PlayerPic.Image = null;
                                }
                                else if (EnemyHP.Value==0)
                                {
                                    GameText.Text = ($"The opposing {pokemons[enemyMon].GetName()} fainted.");
                                    EnemyPic.Image = null;
                                }
                                fighting = false;
                                endBool = true;
                                end = 1;
                                break;
                            }
                            else if (EnemyAttacked==false||PlayerAttacked==false)
                            {
                                if (EnemyAttacked==false)
                                {
                                    EnemyAttack(out isCrit, out isMiss);
                                    postAttack = 1;
                                    break;
                                }
                                else if (PlayerAttacked==false)
                                {
                                    PlayerAttack(PotentialPlayerMove, out isCrit, out isMiss);
                                    postAttack = 1;
                                    break;
                                }
                            }
                            else
                            {
                                PotentialPlayerMove = 0;
                                EnemyAttacked = false;
                                PlayerAttacked = false;
                                BattleGUI.Visible = true;
                                BattleGUI.Enabled = true;
                                BattleGUI.BackgroundImage = Properties.Resources.Fight_GUI;

                                Bag.BackgroundImage = Properties.Resources.BAG;
                                Bag_Holder.BackgroundImage = Bag.BackgroundImage;
                                Bag.BackgroundImage = Properties.Resources.BAG;
                                Bag_Holder.BackgroundImage = Bag.BackgroundImage;
                                BagMaxPP.Visible = false;
                                BagShownPP.Visible = false;
                                BagMoveName.Visible = false;

                                Fight.BackgroundImage = Properties.Resources.FIGHT;
                                Fight_Holder.BackgroundImage = Fight.BackgroundImage;
                                FightMaxPP.Visible = false;
                                FightShownPP.Visible = false;
                                FightMoveName.Visible = false;

                                Pokemon.BackgroundImage = Properties.Resources.POKEMON;
                                Pokemon_Holder.BackgroundImage = Pokemon.BackgroundImage;
                                PokemonMaxPP.Visible = false;
                                PokemonShownPP.Visible = false;
                                PokemonMoveName.Visible = false;

                                Run.BackgroundImage = Properties.Resources.RUN;
                                Run_Holder.BackgroundImage = Run.BackgroundImage;
                                RunMaxPP.Visible = false;
                                RunShownPP.Visible = false;
                                RunMoveName.Visible = false;

                                GameText.Text = "What will you do?";

                                action = false;
                                fighting = false;
                            }
                            postAttack = 1;
                            break;
                    }
                    
                }
                if (endBool==true)
                {
                    switch(end)
                    {
                        case 1:
                            end = 2;
                            break;

                        case 2:
                            if (PlayerHP.Value==0)
                            {
                                Game.BackgroundImage = Properties.Resources.PBC__1_;
                                GameText.Text = "I can't believe I lost to this geezer...";
                            }
                            else if (EnemyHP.Value==0)
                            {
                                Game.BackgroundImage = Properties.Resources.PBC;
                                GameText.Text = "Impossible! How did I lose to this ametuer(coder)!?";
                            }
                            end = 3;
                            break;

                        case 3:
                            if (PlayerHP.Value == 0)
                            {
                                GameText.Text = "You gave 2 BTC to Instructor Stan and blacked out.";
                            }
                            else if (EnemyHP.Value == 0)
                            {
                                GameText.Text = "You got 10 BTC for winning and also reccieved bragging rights!";
                            }
                            end = 4;
                            break;

                        case 4:
                                if (PlayerHP.Value == 0)
                                {
                                    GameText.Text = "You lost...";
                                }
                                else if (EnemyHP.Value == 0)
                                {
                                    GameText.Text = "YOU WIN!!!";
                                }
                            break;
                    }
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Fight_Click(object sender, EventArgs e)
        {
            if (fighting==true && moves[pokemons[playerMon].GetFirstMove().GetMoveNumber()].GetCurrentPP()>0)
            {
                PotentialPlayerMove = pokemons[playerMon].GetFirstMove().GetMoveNumber();
                if (pokemons[playerMon].GetSpeed()>pokemons[enemyMon].GetSpeed())
                {
                    PlayerAttack(pokemons[playerMon].GetFirstMove().GetMoveNumber(), out isCrit, out isMiss);
                }
                else
                {
                    EnemyAttack(out bool isCrit, out isMiss);
                }
            }
            else if(fighting==false)
            {
                Fight.BackgroundImage = pokemons[playerMon].GetFirstMove().GetButtonImage();
                Fight_Holder.BackgroundImage = Fight.BackgroundImage;
                FightMaxPP.Text = $"{pokemons[playerMon].GetFirstMove().GetDatPP()}";
                FightShownPP.Text = $"{pokemons[playerMon].GetFirstMove().GetCurrentPP()}";
                FightMoveName.Text = $"{pokemons[playerMon].GetFirstMove().GetName()}";
                FightMaxPP.Visible = true;
                FightShownPP.Visible = true;
                FightMoveName.Visible = true;

                Bag.BackgroundImage = pokemons[playerMon].GetSecondMove().GetButtonImage();
                Bag_Holder.BackgroundImage = Bag.BackgroundImage;
                BagMaxPP.Text = $"{pokemons[playerMon].GetSecondMove().GetDatPP()}";
                BagShownPP.Text = $"{pokemons[playerMon].GetSecondMove().GetCurrentPP()}";
                BagMoveName.Text = $"{pokemons[playerMon].GetSecondMove().GetName()}";
                BagMaxPP.Visible = true;
                BagShownPP.Visible = true;
                BagMoveName.Visible = true;

                Pokemon.BackgroundImage = pokemons[playerMon].GetThirdMove().GetButtonImage();
                Pokemon_Holder.BackgroundImage = Pokemon.BackgroundImage;
                PokemonMaxPP.Text = $"{pokemons[playerMon].GetThirdMove().GetDatPP()}";
                PokemonShownPP.Text = $"{pokemons[playerMon].GetThirdMove().GetCurrentPP()}";
                PokemonMoveName.Text = $"{pokemons[playerMon].GetThirdMove().GetName()}";
                PokemonMaxPP.Visible = true;
                PokemonShownPP.Visible = true;
                PokemonMoveName.Visible = true;

                Run.BackgroundImage = pokemons[playerMon].GetFourthMove().GetButtonImage();
                Run_Holder.BackgroundImage = Run.BackgroundImage;
                RunMaxPP.Text = $"{pokemons[playerMon].GetFourthMove().GetDatPP()}";
                RunShownPP.Text = $"{pokemons[playerMon].GetFourthMove().GetCurrentPP()}";
                RunMoveName.Text = $"{pokemons[playerMon].GetFourthMove().GetName()}";
                RunMaxPP.Visible = true;
                RunShownPP.Visible = true;
                RunMoveName.Visible = true;

                BattleGUI.BackgroundImage = Properties.Resources.Fight_GUI;


                fighting = true;
            }
        }

        private void Bag_Click(object sender, EventArgs e)
        {
            if (fighting==true && moves[pokemons[playerMon].GetSecondMove().GetMoveNumber()].GetCurrentPP() > 0)
            {
                PotentialPlayerMove = pokemons[playerMon].GetSecondMove().GetMoveNumber();
                if (pokemons[playerMon].GetSpeed() > pokemons[enemyMon].GetSpeed())
                {
                    PlayerAttack(pokemons[playerMon].GetSecondMove().GetMoveNumber(), out isCrit, out isMiss);
                }
                else
                {
                    EnemyAttack(out bool isCrit, out isMiss);
                }
            }
            else if(fighting==false)
            {
                this.Focus();
                BattleGUI.Enabled = false;
                action = true;
                BattleGUI.Visible = false;
                GameText.Text = "You have no useable items (I'm lazy).";
            }
        }

        private void Pokemon_Click(object sender, EventArgs e)
        {
            if (fighting==true && moves[pokemons[playerMon].GetThirdMove().GetMoveNumber()].GetCurrentPP() > 0)
            {
                PotentialPlayerMove = pokemons[playerMon].GetThirdMove().GetMoveNumber();
                if (pokemons[playerMon].GetSpeed() > pokemons[enemyMon].GetSpeed())
                {
                    PlayerAttack(pokemons[playerMon].GetThirdMove().GetMoveNumber(), out isCrit, out isMiss);
                }
                else
                {
                    EnemyAttack(out bool isCrit, out isMiss);
                }
            }
            else if(fighting==false)
            {
                this.Focus();
                BattleGUI.Enabled = false;
                action = true;
                BattleGUI.Visible = false;
                GameText.Text = "You have no other Pokemon that can fight (I'm lazy).";
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (fighting==true && moves[pokemons[playerMon].GetFourthMove().GetMoveNumber()].GetCurrentPP() > 0)
            {
                PotentialPlayerMove = pokemons[playerMon].GetFourthMove().GetMoveNumber();
                if (pokemons[playerMon].GetSpeed() > pokemons[enemyMon].GetSpeed())
                {
                    PlayerAttack(pokemons[playerMon].GetFourthMove().GetMoveNumber(), out isCrit, out isMiss);
                }
                else
                {
                    EnemyAttack(out bool isCrit, out isMiss);
                }
            }
            else if(fighting==false)
            {
                this.Focus();
                BattleGUI.Enabled = false;
                action = true;
                BattleGUI.Visible = false;
                GameText.Text = "You can't run from a trainer battle!";
            }
        }
    }
}
