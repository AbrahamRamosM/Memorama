using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Memorama
{
    public partial class Memorama : Form
    {
        int counter = 0;
        int selectedCards = 0;
        int selectedCard1 = 0;
        int selectedCard2 = 0;
        public Memorama()
        {
            InitializeComponent();
        }


        public Boolean resetCards(int card)
        {
            Boolean isCard = false;
            if (card == 1)
            {   
                flash1.Visible = false;
                flash1_cover.Visible = true;
                return isCard = true;
            } else if (card == 2)
            {
                flash2.Visible = false;
                flash2_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 3)
            {
                batman1.Visible = false;
                batman1_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 4)
            {
                batman2.Visible = false;
                batman2_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 5)
            {
                cyborg1.Visible = false;
                cyborg1_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 6)
            {
                cyborg2.Visible = false;
                cyborg2_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 7)
            {
                superman1.Visible = false;
                superman1_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 8)
            {
                superman2.Visible = false;
                superman2_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 9)
            {
                wonderwoman1.Visible = false;
                wonderwoman1_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 10)
            {
                wonderwoman2.Visible = false;
                wonderwoman2_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 11)
            {
                aquaman1.Visible = false;
                aquaman1_cover.Visible = true;
                return isCard = true;
            }
            else if (card == 12)
            {
                aquaman2.Visible = false;
                aquaman2_cover.Visible = true;
                return  isCard = true;
            } else
            {
                return isCard = false;
            }
        }

        public bool validateCard(int card1, int card2)
        {
            Boolean cardState;
            if (card1 == 1 && card2 == 2 || card1 == 2 && card2 == 1)
            {
                return cardState = true;
            } else if (card1 == 3 && card2 == 4 || card1 == 4 && card2 == 3)
            {
                return cardState = true;
            }
            else if (card1 == 5 && card2 == 6 || card1 == 6 && card2 == 5)
            {
                return cardState = true;
            }
            else if (card1 == 7 && card2 == 8 || card1 == 8 && card2 == 7)
            {
                return cardState = true;
            }
            else if (card1 == 9 && card2 == 10 || card1 == 10 && card2 == 9)
            {
                return cardState = true;
            }
            else if (card1 == 11 && card2 == 12 || card1 == 12 && card2 == 11)
            {
                return cardState = true;
            }
            else
            {
                return cardState = false;
            }

            /*
            // 1 y 2
            flash1.Visible = true;
            flash2.Visible = true;
            // 3 y 4
            batman1.Visible = true;
            batman2.Visible = true;
            // 5 y 6
            cyborg1.Visible = true;
            cyborg2.Visible = true;
            // 7 y 8
            superman1.Visible = true;
            superman2.Visible = true;
            // 9 y 10
            wonderwoman1.Visible = true;
            wonderwoman2.Visible = true;
            // 11 y 12
            aquaman1.Visible = true;
            aquaman2.Visible = true;
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cyborg1_cover_Click(object sender, EventArgs e)
        {
            cyborg1_cover.Visible = false;
            cyborg1.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 5;
            } else if (selectedCards == 1)
            {
                Task.Delay(5000);
                selectedCard2 = 5;
                selectedCards = 2;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                } else
                {
                    selectedCards = 0;
                }
            }
        }

        private void wonderwoman1_cover_Click(object sender, EventArgs e)
        {
            wonderwoman1_cover.Visible = false;
            wonderwoman1.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 9;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 9;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void batman1_cover_Click(object sender, EventArgs e)
        {
            batman1_cover.Visible = false;
            batman1.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 3;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 3;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void superman1_cover_Click(object sender, EventArgs e)
        {
            superman1_cover.Visible = false;
            superman1.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 7;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 7;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void cyborg2_cover_Click(object sender, EventArgs e)
        {
            cyborg2_cover.Visible = false;
            cyborg2.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 6;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 6;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void flash2_cover_Click(object sender, EventArgs e)
        {
            flash2_cover.Visible = false;
            flash2.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 2;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 2;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void superman2_cover_Click(object sender, EventArgs e)
        {
            superman2_cover.Visible = false;
            superman2.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 8;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 8;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void aquaman1_cover_Click(object sender, EventArgs e)
        {
            aquaman1_cover.Visible = false;
            aquaman1.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 11;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 11;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void wonderwoman2_cover_Click(object sender, EventArgs e)
        {
            wonderwoman2_cover.Visible = false;
            wonderwoman2.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 10;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 10;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void batman2_cover_Click(object sender, EventArgs e)
        {
            batman2_cover.Visible = false;
            batman2.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 4;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 4;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void flash1_cover_Click(object sender, EventArgs e)
        {
            flash1_cover.Visible = false;
            flash1.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 1;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 1;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void aquaman2_cover_Click(object sender, EventArgs e)
        {
            aquaman2_cover.Visible = false;
            aquaman2.Visible = true;
            counter++;
            intentos_num.Text = counter.ToString();
            if (selectedCards == 0)
            {
                selectedCards = 1;
                selectedCard1 = 12;
            }
            else if (selectedCards == 1)
            {
                selectedCards = 2;
                selectedCard2 = 12;
                
                if (validateCard(selectedCard1, selectedCard2) == false)
                {
                    resetCards(selectedCard1);
                    resetCards(selectedCard2);
                    selectedCards = 0;
                }
                else
                {
                    selectedCards = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wonderwoman1_cover.Visible = true;
            wonderwoman2_cover.Visible = true;
            cyborg1_cover.Visible = true;
            cyborg2_cover.Visible = true;
            flash1_cover.Visible = true;
            flash2_cover.Visible = true;
            superman1_cover.Visible = true;
            superman2_cover.Visible = true;
            aquaman1_cover.Visible = true;
            aquaman2_cover.Visible = true;
            batman1_cover.Visible = true;
            batman2_cover.Visible = true;

            aquaman1.Visible = false;
            aquaman2.Visible = false;
            flash1.Visible = false;
            flash2.Visible = false;
            batman1.Visible = false;
            batman2.Visible = false;
            cyborg1.Visible = false;
            cyborg2.Visible = false;
            superman1.Visible = false;
            superman2.Visible = false;
            wonderwoman1.Visible = false;
            wonderwoman2.Visible = false;
            selectedCards = 0;
            selectedCard1 = 0;
            selectedCard2 = 0;
            counter = 0;
            intentos_num.Text = counter.ToString();
        }

        private void Memorama_Load(object sender, EventArgs e)
        {

        }
    }
}
