
namespace Ejercicio6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdia2 = new System.Windows.Forms.TextBox();
            this.txtmes2 = new System.Windows.Forms.TextBox();
            this.txtanho2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año:";
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(190, 80);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(100, 23);
            this.txtdia.TabIndex = 3;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(190, 116);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 23);
            this.txtmes.TabIndex = 4;
            // 
            // txtanho
            // 
            this.txtanho.Location = new System.Drawing.Point(190, 154);
            this.txtanho.Name = "txtanho";
            this.txtanho.Size = new System.Drawing.Size(100, 23);
            this.txtanho.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Día:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Año:";
            // 
            // txtdia2
            // 
            this.txtdia2.Location = new System.Drawing.Point(585, 91);
            this.txtdia2.Name = "txtdia2";
            this.txtdia2.Size = new System.Drawing.Size(100, 23);
            this.txtdia2.TabIndex = 9;
            this.txtdia2.TextChanged += new System.EventHandler(this.txtdia2_TextChanged);
            // 
            // txtmes2
            // 
            this.txtmes2.Location = new System.Drawing.Point(585, 124);
            this.txtmes2.Name = "txtmes2";
            this.txtmes2.Size = new System.Drawing.Size(100, 23);
            this.txtmes2.TabIndex = 10;
            // 
            // txtanho2
            // 
            this.txtanho2.Location = new System.Drawing.Point(585, 154);
            this.txtanho2.Name = "txtanho2";
            this.txtanho2.Size = new System.Drawing.Size(100, 23);
            this.txtanho2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtanho2);
            this.Controls.Add(this.txtmes2);
            this.Controls.Add(this.txtdia2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtanho);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdia2;
        private System.Windows.Forms.TextBox txtmes2;
        private System.Windows.Forms.TextBox txtanho2;
        private System.Windows.Forms.Button button1;
    }
}

