
namespace LAB_8
{
    partial class ChessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonRook = new System.Windows.Forms.RadioButton();
            this.radioButtonHorse = new System.Windows.Forms.RadioButton();
            this.radioButtonEleph = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonRook
            // 
            this.radioButtonRook.AutoSize = true;
            this.radioButtonRook.Location = new System.Drawing.Point(577, 151);
            this.radioButtonRook.Name = "radioButtonRook";
            this.radioButtonRook.Size = new System.Drawing.Size(72, 24);
            this.radioButtonRook.TabIndex = 1;
            this.radioButtonRook.TabStop = true;
            this.radioButtonRook.Text = "Ладья";
            this.radioButtonRook.UseVisualStyleBackColor = true;
            this.radioButtonRook.Click += new System.EventHandler(this.radioButtonRook_CheckedChanged);
            // 
            // radioButtonHorse
            // 
            this.radioButtonHorse.AutoSize = true;
            this.radioButtonHorse.Location = new System.Drawing.Point(577, 181);
            this.radioButtonHorse.Name = "radioButtonHorse";
            this.radioButtonHorse.Size = new System.Drawing.Size(65, 24);
            this.radioButtonHorse.TabIndex = 2;
            this.radioButtonHorse.TabStop = true;
            this.radioButtonHorse.Text = "Конь";
            this.radioButtonHorse.UseVisualStyleBackColor = true;
            this.radioButtonHorse.Click += new System.EventHandler(this.radioButtonHorse_CheckedChanged);
            // 
            // radioButtonEleph
            // 
            this.radioButtonEleph.AutoSize = true;
            this.radioButtonEleph.Location = new System.Drawing.Point(577, 211);
            this.radioButtonEleph.Name = "radioButtonEleph";
            this.radioButtonEleph.Size = new System.Drawing.Size(65, 24);
            this.radioButtonEleph.TabIndex = 3;
            this.radioButtonEleph.TabStop = true;
            this.radioButtonEleph.Text = "Слон";
            this.radioButtonEleph.UseVisualStyleBackColor = true;
            this.radioButtonEleph.Click += new System.EventHandler(this.radioButtonEleph_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(577, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберете одну из фигур , \r\nкоторой будете играть: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonEleph);
            this.Controls.Add(this.radioButtonHorse);
            this.Controls.Add(this.radioButtonRook);
            this.Controls.Add(this.button1);
            this.Name = "ChessForm";
            this.Text = "Шахматы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonRook;
        private System.Windows.Forms.RadioButton radioButtonHorse;
        private System.Windows.Forms.RadioButton radioButtonEleph;
        private System.Windows.Forms.Label label1;
    }
}