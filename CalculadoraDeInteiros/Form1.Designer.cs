namespace CalculadoraDeInteiros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_0 = new Button();
            btn_igual = new Button();
            btn_soma = new Button();
            btn_sub = new Button();
            btn_mult = new Button();
            btn_div = new Button();
            numero_temp = new TextBox();
            SuspendLayout();
            // 
            // btn_3
            // 
            btn_3.Location = new Point(78, 298);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(50, 50);
            btn_3.TabIndex = 0;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += button1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(148, 298);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(50, 50);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(218, 298);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(50, 50);
            btn_1.TabIndex = 2;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += button3_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(78, 232);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(50, 50);
            btn_6.TabIndex = 3;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(148, 232);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(50, 50);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(218, 232);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(50, 50);
            btn_4.TabIndex = 5;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(78, 161);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(50, 50);
            btn_9.TabIndex = 6;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(148, 161);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(50, 50);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += button8_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(218, 161);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(50, 50);
            btn_7.TabIndex = 8;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(78, 367);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(50, 50);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_igual
            // 
            btn_igual.Location = new Point(148, 367);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(120, 50);
            btn_igual.TabIndex = 10;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = true;
            btn_igual.Click += btn_igual_Click;
            // 
            // btn_soma
            // 
            btn_soma.Location = new Point(331, 161);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(50, 50);
            btn_soma.TabIndex = 11;
            btn_soma.Text = "+";
            btn_soma.UseVisualStyleBackColor = true;
            btn_soma.Click += btn_soma_Click;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(331, 232);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(50, 50);
            btn_sub.TabIndex = 12;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_mult
            // 
            btn_mult.Location = new Point(331, 298);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(50, 50);
            btn_mult.TabIndex = 13;
            btn_mult.Text = "*";
            btn_mult.UseVisualStyleBackColor = true;
            btn_mult.Click += btn_mult_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(331, 367);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(50, 50);
            btn_div.TabIndex = 14;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // numero_temp
            // 
            numero_temp.Location = new Point(78, 113);
            numero_temp.Name = "numero_temp";
            numero_temp.Size = new Size(303, 31);
            numero_temp.TabIndex = 15;
            numero_temp.TextChanged += numero_temp_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 622);
            Controls.Add(numero_temp);
            Controls.Add(btn_div);
            Controls.Add(btn_mult);
            Controls.Add(btn_sub);
            Controls.Add(btn_soma);
            Controls.Add(btn_igual);
            Controls.Add(btn_0);
            Controls.Add(btn_7);
            Controls.Add(btn_8);
            Controls.Add(btn_9);
            Controls.Add(btn_4);
            Controls.Add(btn_5);
            Controls.Add(btn_6);
            Controls.Add(btn_1);
            Controls.Add(btn_2);
            Controls.Add(btn_3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_0;
        private Button btn_igual;
        private Button btn_soma;
        private Button btn_sub;
        private Button btn_mult;
        private Button btn_div;
        private TextBox numero_temp;
    }
}