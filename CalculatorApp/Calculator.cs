using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public class Calculator : Form
    {
        TextBox aBox = new TextBox();
        TextBox bBox = new TextBox();
        Button addButton = new Button();
        Label resultLabel = new Label();

        public Calculator()
        {
            this.Text = "Simple Calculator";
            this.Width = 250;
            this.Height = 200;

            aBox.Top = 20;
            aBox.Left = 20;
            aBox.Width = 180;

            bBox.Top = 50;
            bBox.Left = 20;
            bBox.Width = 180;

            addButton.Text = "Add";
            addButton.Top = 80;
            addButton.Left = 20;
            addButton.Width = 180;
            addButton.Click += (s, e) =>
            {
                if (double.TryParse(aBox.Text, out double a) && double.TryParse(bBox.Text, out double b))
                    resultLabel.Text = "Sum: " + (a + b);
                else
                    resultLabel.Text = "Enter valid numbers";
            };

            resultLabel.Top = 110;
            resultLabel.Left = 20;
            resultLabel.Width = 180;

            Controls.Add(aBox);
            Controls.Add(bBox);
            Controls.Add(addButton);
            Controls.Add(resultLabel);
        }
    }
}