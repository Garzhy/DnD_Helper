using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Helper
{
    public partial class DnD_Helper : Form
    {
        public DnD_Helper()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        /// <summary>
        /// Clears all form inputs on the roller page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Roll_Page(object sender, EventArgs e)
        {
            txtDiceNumber.Clear();
            cboDieSize.SelectedIndex = -1;
            txtModifier.Clear();
            rdoNone.Checked = true;
            txtResult.Clear();
        }


        /// <summary>
        /// Clear the history page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_History_Page(object sender, EventArgs e)
        {
            lboHistory.Items.Clear();
        }

        /// <summary>
        /// Clears either an individual tracker count or all tracker counts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Tracker(object sender, EventArgs e)
        {
            if (sender == btnClearTracker1)
            {
                txtTracker1Count.Clear();
            }
            else if (sender == btnClearTracker2)
            {
                txtTracker2Count.Clear();
            }
            else if (sender == btnClearTracker3)
            {
                txtTracker3Count.Clear();
            }
            else if (sender == btnClearTracker4)
            {
                txtTracker4Count.Clear();
            }
            else
            {
                txtTracker1Count.Clear();
                txtTracker2Count.Clear();
                txtTracker3Count.Clear();
                txtTracker4Count.Clear();
            }
        }

        /// <summary>
        /// Rolls the dice specified by the elements on the form, displaying the result in the result textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Roll_Dice(object sender, EventArgs e)
        {
            // Initializes the total value, dice amount, and modifier integers
            int intTotal = 0;
            int intDiceAmount;
            int intModifier;

            // Initializes success booleans for parsing the dice count and modifier fields
            bool bolCanParseDiceCount = true;
            bool bolCanParseModifier = true;

            // If the dice count field is empty...
            if (txtDiceNumber.Text.Trim() == "")
            {
                // ...the amount of dice to roll is 1
                intDiceAmount = 1;
            }
            // If the dice count field is not empty...
            else
            {
                // ...attempt to parse the dice count field to an int, setting the can parse boolean to false if it can't
                if (!int.TryParse(txtDiceNumber.Text, out intDiceAmount))
                {
                    bolCanParseDiceCount = false;
                }
            }

            // If the modifier field is empty...
            if (txtModifier.Text.Trim() == "")
            {
                // ...the roll modifier is 0
                intModifier = 0;
            }
            // If the modifier field is not empty...
            else
            {
                // ...attempt to parse the modifier field to an int, setting the can parse boolean to false if it can't
                if (!int.TryParse(txtModifier.Text, out intModifier))
                {
                    bolCanParseModifier = false;
                }
            }

            // If the dice count is parsable and a die size is selected...
            if (bolCanParseDiceCount && cboDieSize.SelectedIndex != -1 && bolCanParseModifier)
            {
                int intDieSize = Convert.ToInt32(cboDieSize.Text.Substring(1));

                // ...for the amount of dice specified...
                for (int i = 0; i < intDiceAmount; i++)
                {
                    // ...if the advantage radio button is selected...
                    if (rdoAdvantage.Checked)
                    {
                        // ...rolls twice, recording both values
                        int intRoll1 = rand.Next(1, intDieSize + 1);
                        int intRoll2 = rand.Next(1, intDieSize + 1);

                        // If roll 1 is greater than or equal to roll 2...
                        if (intRoll1 >= intRoll2)
                        {
                            // ...add roll 1 to the total value
                            intTotal += intRoll1;
                        }
                        // If roll 2 is greater than roll 1...
                        else
                        {
                            // ...add roll 2 to the total value
                            intTotal += intRoll2;
                        }
                    }
                    // ...if the disadvantage radiobutton is selected...
                    else if (rdoDisadvantage.Checked)
                    {
                        // ...rolls twice, recording both values
                        int intRoll1 = rand.Next(1, intDieSize + 1);
                        int intRoll2 = rand.Next(1, intDieSize + 1);

                        // If roll 1 is less than or equal to roll 2...
                        if (intRoll1 <= intRoll2)
                        {
                            // ...add roll 1 to the total value
                            intTotal += intRoll1;
                        }
                        // If roll 2 is less than roll 1...
                        else
                        {
                            // ...add roll 2 to the total value
                            intTotal += intRoll2;
                        }
                    }
                    // ...if neither the advantage nor disadvantage radio buttons are selected...
                    else
                    {
                        // ...roll a random number within the die size and add it to the total value
                        intTotal += rand.Next(1, intDieSize + 1);
                    }
                }

                // Adds the modifier to the total roll
                intTotal += intModifier;

                // Displays the total in the result textbox
                txtResult.Text = intTotal.ToString();

                // Calls the Add Roll to History method
                Add_Roll_To_History(intDiceAmount, intDieSize, intModifier, intTotal, rdoAdvantage.Checked, rdoDisadvantage.Checked);
            }
            // If either the dice count is not parsable or no die size is selected...
            else
            {
                // ...if the dice count is not parsable...
                if (!bolCanParseDiceCount)
                {
                    // ...show a message box telling the error
                    MessageBox.Show("Input an integer amount of dice to roll", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // ...if no die size is selected...
                if (cboDieSize.SelectedIndex == -1)
                {
                    // ...show a message box telling the error
                    MessageBox.Show("Choose a die size to roll", "Missig Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // ...if the modifier is not parsable...
                if (!bolCanParseModifier)
                {
                    // ...show a message box telling the error
                    MessageBox.Show("Input an integer modifier to add", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Adds the roll to the history listbox, using the given data
        /// </summary>
        /// <param name="intDiceAmount"></param>
        /// <param name="intDieSize"></param>
        /// <param name="intTotal"></param>
        /// <param name="bolAdvantage"></param>
        /// <param name="bolDisadvantage"></param>
        private void Add_Roll_To_History(int intDiceAmount, int intDieSize, int intModifier, int intTotal, bool bolAdvantage, bool bolDisadvantage)
        {
            // initializes a string to display the current modifiers
            string strModifier;

            if (bolAdvantage)
            {
                strModifier = "A";
            }
            else if (bolDisadvantage)
            {
                strModifier = "D";
            }
            else
            {
                strModifier = "-";
            }
            // Creates the display string based on the given inputs and adds it to the history listbox
            lboHistory.Items.Add(string.Format("{0}d{1} + {2}  |  [{3}]  -->  {4}", intDiceAmount, intDieSize, intModifier, strModifier, intTotal));
        }

        private void Increment_Decrement(object sender, EventArgs e)
        {
            // If the sender is related to tracker 1...
            if (sender == btnIncrementTracker1 || sender == btnDecrementTracker1)
            {
                bool bolCanParse = int.TryParse(txtTracker1Count.Text, out int intTracker1);

                if (txtTracker1Count.Text.Trim() == "")
                {
                    intTracker1 = 0;
                    bolCanParse = true;
                }

                // ...if the tracker 1 count text can be parsed to an int...
                if (bolCanParse)
                {
                    // ...if the sender is the incrementer...
                    if (sender == btnIncrementTracker1)
                    {
                        // ...set the text of the tracker 1 count to its current value +1
                        intTracker1++;
                        txtTracker1Count.Text = intTracker1.ToString();
                    }
                    // ...if the sender is the decrementer...
                    else
                    {
                        // ...set the text of the tracker 1 count to its current value -1 if it is greater than 0
                        if (intTracker1 > 0)
                        {
                            intTracker1--;
                        }

                        txtTracker1Count.Text = intTracker1.ToString();
                    }
                }
            }
            // If the sender is related to tracker 2...
            else if (sender == btnIncrementTracker2 || sender == btnDecrementTracker2)
            {
                bool bolCanParse = int.TryParse(txtTracker2Count.Text, out int intTracker2);

                if (txtTracker2Count.Text.Trim() == "")
                {
                    intTracker2 = 0;
                    bolCanParse = true;
                }

                // ...if the tracker 2 count text can be parsed to an int...
                if (bolCanParse)
                {
                    // ...if the sender is the incrementer...
                    if (sender == btnIncrementTracker2)
                    {
                        // ...set the text of the tracker 2 count to its current value +1
                        intTracker2++;
                        txtTracker2Count.Text = intTracker2.ToString();
                    }
                    // ...if the sender is the decrementer...
                    else
                    {
                        // ...set the text of the tracker 2 count to its current value -1 if it is greater than 0
                        if (intTracker2 > 0)
                        {
                            intTracker2--;
                        }
                        txtTracker2Count.Text = intTracker2.ToString();
                    }
                }
            }
            // If the sender is related to tracker 3...
            else if (sender == btnIncrementTracker3 || sender == btnDecrementTracker3)
            {
                bool bolCanParse = int.TryParse(txtTracker3Count.Text, out int intTracker3);

                if (txtTracker3Count.Text.Trim() == "")
                {
                    intTracker3 = 0;
                    bolCanParse = true;
                }

                // ...if the tracker 3 count text can be parsed to an int...
                if (bolCanParse)
                {
                    // ...if the sender is the incrementer...
                    if (sender == btnIncrementTracker3)
                    {
                        // ...set the text of the tracker 3 count to its current value +1
                        intTracker3++;
                        txtTracker3Count.Text = intTracker3.ToString();
                    }
                    // ...if the sender is the decrementer...
                    else
                    {
                        // ...set the text of the tracker 3 count to its current value -1 if it is greater than 0
                        if (intTracker3 > 0)
                        {
                            intTracker3--;
                        }
                        txtTracker3Count.Text = intTracker3.ToString();
                    }
                }
            }
            // If the sender is related to tracker 4...
            else if (sender == btnIncrementTracker4 || sender == btnDecrementTracker4)
            {
                bool bolCanParse = int.TryParse(txtTracker4Count.Text, out int intTracker4);

                if (txtTracker4Count.Text.Trim() == "")
                {
                    intTracker4 = 0;
                    bolCanParse = true;
                }

                // ...if the tracker 4 count text can be parsed to an int...
                if (bolCanParse)
                {
                    // ...if the sender is the incrementer...
                    if (sender == btnIncrementTracker4)
                    {
                        // ...set the text of the tracker 4 count to its current value +1
                        intTracker4++;
                        txtTracker4Count.Text = intTracker4.ToString();
                    }
                    // ...if the sender is the decrementer...
                    else
                    {
                        // ...set the text of the tracker 4 count to its current value -1 if it is greater than 0
                        if (intTracker4 > 0)
                        {
                            intTracker4--;
                        }
                        txtTracker4Count.Text = intTracker4.ToString();
                    }
                }
            }
        }
    }
}