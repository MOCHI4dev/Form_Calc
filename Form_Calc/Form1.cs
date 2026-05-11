namespace Form_Calc
{
    public partial class Form1 : Form
    {
        double resultValue = 0;       // 現在の計算結果を保存
        string operation = "";        // どの演算子が押されたか保存
        bool isOperationPerformed = false; // 演算子が押された直後かどうか

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*暇なので一発芸します
             *小籠包と小論文のハーフ
             *ショウロンぷぅぁん*/
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            // 修正：旗が立っているか、0なら上書き
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "8";

            System.Diagnostics.Debug.WriteLine($"--- 8 押下 --- 表示: {label1.Text}");
        }

        private void ButtonSlash_Click(object sender, EventArgs e)
        {
            if (resultValue != 0 && operation != "")
            {
                double secondValue = double.Parse(label1.Text);
                if (operation == "/")
                {
                    resultValue = resultValue / secondValue;
                    label1.Text = resultValue.ToString();
                }
            }
            else
            {
                // まだ何も計算してないなら、今の数字を保存するだけ
                resultValue = double.Parse(label1.Text);
            }

            operation = "/";
            isOperationPerformed = true;
        }

        private void ButtonMPlied_Click(object sender, EventArgs e)
        {
            if (resultValue != 0 && operation != "")
            {
                double secondValue = double.Parse(label1.Text);
                if (operation == "*")
                {
                    resultValue = resultValue * secondValue;
                    label1.Text = resultValue.ToString();
                }
            }
            else
            {
                // 以下ry
                resultValue = double.Parse(label1.Text);
            }

            operation = "*";
            isOperationPerformed = true;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(label1.Text);
            operation = "-";
            isOperationPerformed = true;
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            // もしすでに1つ目の数字が入っていてかつ演算子も決まっているなら
            // 次の数字を打つ前に、今までの分を一旦計算しちゃう！
            if (resultValue != 0 && operation != "")
            {
                double secondValue = double.Parse(label1.Text);
                if (operation == "+")
                {
                    resultValue = resultValue + secondValue;
                    label1.Text = resultValue.ToString();
                }
            }
            else
            {
                // まだ何も計算してないなら、今の数字を保存するだけ
                resultValue = double.Parse(label1.Text);
            }

            operation = "+";
            isOperationPerformed = true;

            // System.Diagnostics.Debug.WriteLine($"途中経過: {resultValue}");
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "9";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "6";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "3";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            // 修正：計算を実行する
            double secondValue = double.Parse(label1.Text);

            switch (operation)
            {
                case "+":
                    label1.Text = (resultValue + secondValue).ToString();
                    break;
                case "-":
                    label1.Text = (resultValue - secondValue).ToString();
                    break;
                case "*":
                    label1.Text = (resultValue * secondValue).ToString();
                    break;
                case "/":
                    label1.Text = (resultValue / secondValue).ToString();
                    break;

            }

            resultValue = double.Parse(label1.Text);
            operation = "";
            isOperationPerformed = true;

            System.Diagnostics.Debug.WriteLine($"--- = 押下 --- 結果: {label1.Text}");
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "5";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "2";
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                label1.Text = "0";
                isOperationPerformed = false;
                return;
            }

            if (!label1.Text.Contains(".")) //理解してこれ書いてますか？未来の僕。なんとなくじゃだめですよ　教養を得なさい
            {
                label1.Text += ".";
            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "7";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            // 8の時と同じ処理を入れる！
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "4"; 
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || label1.Text == "0")
            {
                label1.Text = "";
                isOperationPerformed = false;
            }
            label1.Text += "1";
        }

        private void ButtonZeroZero_Click(object sender, EventArgs e)
        {
            // 旗がああああああ
            if (isOperationPerformed)
            {
                label1.Text = "0";
                isOperationPerformed = false;
                return;
            }

          
            if (label1.Text != "0")
            {
                label1.Text += "00";
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            //実装の仕方がわかりません助けて下さいmicrosoftさん
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            //ここもわからないんですよね　リセットとACの違いもわからないし　誰か教えてください
        }

        private void ButtonAClear_Click(object sender, EventArgs e)
        {
            // 修正：リセット
            label1.Text = "0";
            resultValue = 0;
            operation = "";
            isOperationPerformed = false;
            System.Diagnostics.Debug.WriteLine("--- AC 押下 ---");
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                label1.Text = "0";
                isOperationPerformed = false;
                return;
            }

            if (label1.Text != "0")
            {
                label1.Text += "0";
            }
        }
    }
}