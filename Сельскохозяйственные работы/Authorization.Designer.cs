namespace Сельскохозяйственные_работы
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            label1 = new Label();
            SalesQ = new Button();
            Name = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // SalesQ
            // 
            SalesQ.BackColor = Color.Transparent;
            SalesQ.FlatStyle = FlatStyle.Popup;
            SalesQ.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SalesQ.ForeColor = Color.Transparent;
            SalesQ.Location = new Point(381, 455);
            SalesQ.Name = "SalesQ";
            SalesQ.Size = new Size(134, 46);
            SalesQ.TabIndex = 4;
            SalesQ.Text = "Войти";
            SalesQ.UseVisualStyleBackColor = false;
            SalesQ.Click += SalesQ_Click;
            // 
            // Name
            // 
            Name.BackColor = Color.DimGray;
            Name.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name.ForeColor = SystemColors.Window;
            Name.Location = new Point(324, 212);
            Name.Name = "Name";
            Name.Size = new Size(240, 26);
            Name.TabIndex = 5;
            // 
            // Password
            // 
            Password.BackColor = Color.DimGray;
            Password.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.Window;
            Password.Location = new Point(324, 303);
            Password.Name = "Password";
            Password.Size = new Size(240, 26);
            Password.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(324, 187);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 7;
            label2.Text = "Введите имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(324, 278);
            label3.Name = "label3";
            label3.Size = new Size(153, 22);
            label3.TabIndex = 8;
            label3.Text = "Введите пароль:";
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 561);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(Name);
            Controls.Add(SalesQ);
            Controls.Add(label1);

            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SalesQ;
        private TextBox Name;
        private TextBox Password;
        private Label label2;
        private Label label3;
    }
}