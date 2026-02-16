namespace MainMenu
{
    partial class ProgressBar
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
            label1 = new Label();
            label2 = new Label();
            exec = new Button();
            exit = new Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            progressBar2 = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Index Principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Index Secondaire";
            // 
            // exec
            // 
            exec.Location = new Point(12, 144);
            exec.Name = "exec";
            exec.Size = new Size(80, 29);
            exec.TabIndex = 2;
            exec.Text = "Executer";
            exec.UseVisualStyleBackColor = true;
            exec.Click += exec_Click;
            // 
            // exit
            // 
            exit.Location = new Point(98, 144);
            exit.Name = "exit";
            exit.Size = new Size(80, 29);
            exit.TabIndex = 3;
            exit.Text = "Quitter";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Bisque;
            progressBar1.ForeColor = Color.Green;
            progressBar1.Location = new Point(12, 32);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(166, 23);
            progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 90);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(166, 29);
            progressBar2.Style = ProgressBarStyle.Marquee;
            progressBar2.TabIndex = 5;
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 198);
            ControlBox = false;
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(exit);
            Controls.Add(exec);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Green;
            Name = "ProgressBar";
            Text = "Barre de Progression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button exec;
        private Button exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}