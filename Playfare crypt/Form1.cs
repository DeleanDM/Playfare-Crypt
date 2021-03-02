using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Playfare_crypt
{
    public partial class Form1 : Form
    {
        Label[,] matrix = new Label[5, 5];
        bool actionEncrypt = true; // true = encrypt | false = decrypt 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actionEncrypt = true;
            actionLabel.Text = "Зашифровать";
            label1.Text = "Текст";
            label1.Location = new Point(200, 35);

            actionLabel.Text = "Зашифровать";
            createMatrix();
            fillMatrix(keyArea.Text);
        }
        void fillMatrix(string keyString)
        {
            char[] alphabet = new char[25] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; // i = j
            keyString = Regex.Replace(keyString, @"\s", ""); // remove all whitespaces from string via regex
            keyString = keyString.Replace('j', 'i');

            string suitableKey = string.Empty;
            for (int i = 0; i < keyString.Length; i++)
            {
                if (!suitableKey.Contains(keyString[i]))
                {
                    suitableKey += keyString[i];
                }
            }
            // MessageBox.Show(suitableKey);
            char[] key = suitableKey.ToCharArray();

            int alphabetCounter = 0;
            int keyCharCounter = 0;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (keyCharCounter != key.Length)
                        {
                            matrix[i, j].Text = key[keyCharCounter].ToString();
                            int letterIndex = Array.IndexOf(alphabet, Convert.ToChar(matrix[i, j].Text)); // find in the alphabet the letter we`ve just add 
                            alphabet[letterIndex] = '-';
                            keyCharCounter++;
                        }
                        else
                        {
                            while (alphabet[alphabetCounter] == '-')
                            {
                                alphabetCounter++;
                            }
                            matrix[i, j].Text = alphabet[alphabetCounter].ToString();
                            alphabetCounter++;
                        }
                    }
                }
            }
            catch
            {
                keyArea.Text = string.Empty;
                MessageBox.Show("Только маленькие латинские буквы");
            }
        }
        void createMatrix()
        {
            int xLocation = 0; // start X location
            int yLocation = 0; // start Y location
            int xAmount = 5; // кол-во клеточек по Х
            int yAmount = 5; // кол-во клеточек по У
            for (int i = 0; i < yAmount; i++)
            {
                xLocation = 0; // возвращаем значение по умолчанию для новой строки
                for (int j = 0; j < xAmount; j++)
                {
                    matrix[i, j] = new Label();
                    matrix[i, j].Text = "X";
                    matrix[i, j].Parent = matrixPanel;
                    matrix[i, j].Location = new Point(xLocation, yLocation);
                    matrix[i, j].Size = new Size(25, 25);
                    xLocation += 35;
                }
                yLocation += 35;
            }
        }

        private void keyArea_TextChanged(object sender, EventArgs e)
        {
            fillMatrix(keyArea.Text);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            List<string> bigrams = createBigrams(textArea.Text);
            string result = string.Empty;
            if (actionEncrypt)
            {
                try
                {
                    result = encrypt(bigrams);
                }
                catch
                {
                    textArea.Text = string.Empty;
                    MessageBox.Show("Только маленькие латинские буквы");
                }
            }
            else
            {
                try
                {
                    result = decrypt(bigrams);
                }
                catch 
                {

                    throw;
                }
            }
            resArea.Text = result;
        }
        string decrypt(List<string> bigrams)
        {
            string result = string.Empty;
            return result;
        }
        string encrypt(List<string> bigrams)
        {
            List<string> encyptedBigram = new List<string>();
            string result = string.Empty;

            int xCordF = -1;
            int yCordF = -1;
            int xCordS = -1;
            int yCordS = -1;

            for (int i = 0; i < bigrams.Count; i++)
            {
                char[] singleBigram = bigrams[i].ToCharArray();
                char[] singleEncryptedBigram = new char[2];
                getLetterCords(singleBigram, out xCordF, out yCordF, out xCordS, out yCordS);

                if (yCordF == yCordS) // если буквы находятся в одной колоне, то сдвигаем их на 1 вниз
                {
                    if (xCordF != 4 && xCordS != 4)
                    {
                        singleEncryptedBigram[0] = Convert.ToChar(matrix[xCordF + 1, yCordF].Text);
                        singleEncryptedBigram[1] = Convert.ToChar(matrix[xCordS + 1, yCordS].Text);
                        encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                        //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                        result = string.Join("", encyptedBigram);
                    }
                    else if (xCordF == 4)
                    {
                        singleEncryptedBigram[0] = Convert.ToChar(matrix[0, yCordF].Text);
                        singleEncryptedBigram[1] = Convert.ToChar(matrix[xCordS + 1, yCordS].Text);
                        encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                        //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                        result = string.Join("", encyptedBigram);
                    }
                    else if (xCordS == 4)
                    {
                        singleEncryptedBigram[0] = Convert.ToChar(matrix[xCordF + 1, yCordF].Text);
                        singleEncryptedBigram[1] = Convert.ToChar(matrix[0, yCordS].Text);
                        encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                        //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                        result = string.Join("", encyptedBigram);
                    }
                }
                else if (xCordF == xCordS) // если буквы находятся в одном ряду , то сдвигаем их на 1 вправо
                {
                    if (yCordF != 4 && yCordS != 4)
                    {
                        singleEncryptedBigram[0] = Convert.ToChar(matrix[xCordF, yCordF + 1].Text);
                        singleEncryptedBigram[1] = Convert.ToChar(matrix[xCordS, yCordS + 1].Text);
                        encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                        //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                        result = string.Join("", encyptedBigram);
                    }
                    else if (yCordF == 4)
                    {
                        singleEncryptedBigram[0] = Convert.ToChar(matrix[xCordF, 0].Text);
                        singleEncryptedBigram[1] = Convert.ToChar(matrix[xCordS, yCordS + 1].Text);
                        encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                        //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                        result = string.Join("", encyptedBigram);
                    }
                    else if (yCordS == 4)
                    {
                        singleEncryptedBigram[0] = Convert.ToChar(matrix[xCordF, yCordF + 1].Text);
                        singleEncryptedBigram[1] = Convert.ToChar(matrix[xCordS, 0].Text);
                        encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                        //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                        result = string.Join("", encyptedBigram);
                    }
                }
                else
                {
                    singleEncryptedBigram[0] = Convert.ToChar(matrix[xCordF,yCordS].Text);
                    singleEncryptedBigram[1] = Convert.ToChar(matrix[xCordS,yCordF].Text);
                    encyptedBigram.Add(string.Concat(singleEncryptedBigram[0], singleEncryptedBigram[1]));
                    //MessageBox.Show(string.Join(" ", encyptedBigram[i]));
                    result = string.Join("", encyptedBigram);
                }
            }
            return result;
        }
        void getLetterCords(char[] singleBigram, out int xPositionFirstSign, out int yPositionFirstSign, out int xPositionSecondSign, out int yPositionSecondSign)
        {
            xPositionFirstSign = -1;
            yPositionFirstSign = -1;

            xPositionSecondSign = -1;
            yPositionSecondSign = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (singleBigram[0].ToString() == matrix[i, j].Text)
                    {
                        xPositionFirstSign = i;
                        yPositionFirstSign = j;
                    }
                    if (singleBigram[1].ToString() == matrix[i, j].Text)
                    {
                        xPositionSecondSign = i;
                        yPositionSecondSign = j;
                    }
                }
            }
            //MessageBox.Show(
            //    "first letter is: " + matrix[xPositionFirstSign, yPositionFirstSign].Text + "\n" +
            //    "second letter is: " + matrix[xPositionSecondSign, yPositionSecondSign].Text + "\n" +
            //    "[" + xPositionFirstSign + " " + yPositionFirstSign + "]" + "  " + "[" + xPositionSecondSign + " " + yPositionSecondSign + "]"
            //);
        }
        List<string> createBigrams(string text)
        {
            List<string> bigrams = new List<string>();

            string reformedText = text;
            reformedText = Regex.Replace(reformedText, @"\s", "");
            for (int i = 1; i < reformedText.Length; i++)
            {
                int j = i - 1;
                if (reformedText[j] == reformedText[i])
                {
                    reformedText = reformedText.Insert(i, "x");
                    i++;
                }
            }

            if (reformedText.Length % 2 != 0)
            {
                reformedText = reformedText.Insert(reformedText.Length, "x");
            }

            for (int i = 0; i < reformedText.Length; i += 2)
            {
                string temp = string.Concat(reformedText[i], reformedText[i + 1]);
                bigrams.Add(temp);
            }
            bigramsTextBox.Text = string.Join(" ", bigrams);
            return bigrams;
        }

        private void зашифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionEncrypt = true;
            actionLabel.Text = "Зашифровать";
            label1.Text = "Текст";
            label1.Location = new Point(200,35);
        }

        private void расшифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionEncrypt = false;
            actionLabel.Text = "Расшифровать";
            label1.Text = "Зашифрованый текст";
            label1.Location = new Point(170, 35);
        }
    }
}
