namespace Calculadora
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
            this.visor = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonSubtrair = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.Enabled = false;
            this.visor.Location = new System.Drawing.Point(75, 137);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(163, 23);
            this.visor.TabIndex = 17;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(132, 89);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(70, 15);
            this.Titulo.TabIndex = 20;
            this.Titulo.Text = "Calculadora";
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(74, 333);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(34, 27);
            this.button0.TabIndex = 36;
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 27);
            this.button3.TabIndex = 23;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(132, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 27);
            this.button7.TabIndex = 27;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(75, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 27);
            this.button8.TabIndex = 28;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonSomar
            // 
            this.buttonSomar.Location = new System.Drawing.Point(279, 232);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(34, 27);
            this.buttonSomar.TabIndex = 33;
            this.buttonSomar.Text = "+";
            this.buttonSomar.UseVisualStyleBackColor = true;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click_1);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Location = new System.Drawing.Point(279, 265);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(34, 27);
            this.buttonDividir.TabIndex = 34;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click_1);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Location = new System.Drawing.Point(279, 199);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(34, 27);
            this.buttonMultiplicar.TabIndex = 26;
            this.buttonMultiplicar.Text = "x";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click_1);
            // 
            // buttonSubtrair
            // 
            this.buttonSubtrair.Location = new System.Drawing.Point(279, 298);
            this.buttonSubtrair.Name = "buttonSubtrair";
            this.buttonSubtrair.Size = new System.Drawing.Size(34, 27);
            this.buttonSubtrair.TabIndex = 35;
            this.buttonSubtrair.Text = "-";
            this.buttonSubtrair.UseVisualStyleBackColor = true;
            this.buttonSubtrair.Click += new System.EventHandler(this.buttonSubtrair_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Snow;
            this.buttonLimpar.Location = new System.Drawing.Point(132, 333);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(54, 27);
            this.buttonLimpar.TabIndex = 37;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Location = new System.Drawing.Point(192, 333);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(34, 27);
            this.buttonIgual.TabIndex = 38;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(75, 244);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 27);
            this.button10.TabIndex = 39;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 27);
            this.button4.TabIndex = 40;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 27);
            this.button5.TabIndex = 41;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 27);
            this.button6.TabIndex = 42;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(75, 333);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 27);
            this.button11.TabIndex = 43;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 409);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSubtrair);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.visor);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
    
        private TextBox visor;
        private Label Titulo;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button buttonSomar;
        private Button buttonDividir;
        private Button buttonSubtrair;
        private Button buttonMultiplicar;
        private Button buttonLimpar;
        private Button buttonIgual;
        private Button button10;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button11;
    }
}