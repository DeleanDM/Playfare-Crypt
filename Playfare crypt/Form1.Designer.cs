namespace Playfare_crypt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matrixPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.resArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.keyArea = new System.Windows.Forms.TextBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.changeKeyTip = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.bigramsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(12, 62);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(577, 154);
            this.textArea.TabIndex = 0;
            this.textArea.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "text";
            // 
            // matrixPanel
            // 
            this.matrixPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.matrixPanel.Location = new System.Drawing.Point(10, 240);
            this.matrixPanel.Name = "matrixPanel";
            this.matrixPanel.Size = new System.Drawing.Size(216, 199);
            this.matrixPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица шифрования";
            // 
            // resArea
            // 
            this.resArea.Location = new System.Drawing.Point(353, 417);
            this.resArea.Name = "resArea";
            this.resArea.ReadOnly = true;
            this.resArea.Size = new System.Drawing.Size(236, 22);
            this.resArea.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(247, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "результат:";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.GoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoButton.Location = new System.Drawing.Point(353, 324);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(236, 50);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Рассчитать";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(247, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "действие:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(247, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "ключ:";
            // 
            // keyArea
            // 
            this.keyArea.Location = new System.Drawing.Point(353, 224);
            this.keyArea.Name = "keyArea";
            this.keyArea.Size = new System.Drawing.Size(236, 22);
            this.keyArea.TabIndex = 9;
            this.keyArea.TextChanged += new System.EventHandler(this.keyArea_TextChanged);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(350, 262);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(46, 17);
            this.actionLabel.TabIndex = 11;
            this.actionLabel.Text = "action";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(248, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "биграмы:";
            // 
            // bigramsTextBox
            // 
            this.bigramsTextBox.Location = new System.Drawing.Point(353, 390);
            this.bigramsTextBox.Name = "bigramsTextBox";
            this.bigramsTextBox.ReadOnly = true;
            this.bigramsTextBox.Size = new System.Drawing.Size(236, 22);
            this.bigramsTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 451);
            this.Controls.Add(this.bigramsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.keyArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textArea);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Шифр плейфера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel matrixPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyArea;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.ToolTip changeKeyTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bigramsTextBox;
    }
}

