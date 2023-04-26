namespace AuthenticationServer.RSAKeyGenerator.UI
{
    partial class MainWindow
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
            privateKeyPathTextBox = new TextBox();
            privateKeyTextBox = new TextBox();
            publicKeyPathTextBox = new TextBox();
            publicKeyTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            selectPrivateKeyPathButton = new Button();
            openPrivateKeyPathButton = new Button();
            selectPublicKeyPathButton = new Button();
            openPublicKeyPathButton = new Button();
            generatorButton = new Button();
            SuspendLayout();
            // 
            // privateKeyPathTextBox
            // 
            privateKeyPathTextBox.Location = new Point(32, 53);
            privateKeyPathTextBox.Name = "privateKeyPathTextBox";
            privateKeyPathTextBox.Size = new Size(260, 23);
            privateKeyPathTextBox.TabIndex = 0;
            // 
            // privateKeyTextBox
            // 
            privateKeyTextBox.BackColor = SystemColors.Window;
            privateKeyTextBox.Location = new Point(32, 143);
            privateKeyTextBox.Multiline = true;
            privateKeyTextBox.Name = "privateKeyTextBox";
            privateKeyTextBox.ReadOnly = true;
            privateKeyTextBox.ScrollBars = ScrollBars.Vertical;
            privateKeyTextBox.Size = new Size(340, 260);
            privateKeyTextBox.TabIndex = 1;
            // 
            // publicKeyPathTextBox
            // 
            publicKeyPathTextBox.Location = new Point(413, 53);
            publicKeyPathTextBox.Name = "publicKeyPathTextBox";
            publicKeyPathTextBox.Size = new Size(260, 23);
            publicKeyPathTextBox.TabIndex = 2;
            // 
            // publicKeyTextBox
            // 
            publicKeyTextBox.BackColor = SystemColors.Window;
            publicKeyTextBox.Location = new Point(413, 143);
            publicKeyTextBox.Multiline = true;
            publicKeyTextBox.Name = "publicKeyTextBox";
            publicKeyTextBox.ReadOnly = true;
            publicKeyTextBox.ScrollBars = ScrollBars.Vertical;
            publicKeyTextBox.Size = new Size(340, 260);
            publicKeyTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(308, 17);
            label1.TabIndex = 4;
            label1.Text = "生成私钥文件的路径（可选，如不选则不生成私钥文件）";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 21);
            label2.Name = "label2";
            label2.Size = new Size(308, 17);
            label2.TabIndex = 5;
            label2.Text = "生成共钥文件的路径（可选，如不选则不生成公钥文件）";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 110);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 6;
            label3.Text = "私钥";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 110);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 7;
            label4.Text = "公钥";
            // 
            // selectPrivateKeyPathButton
            // 
            selectPrivateKeyPathButton.Location = new Point(298, 53);
            selectPrivateKeyPathButton.Name = "selectPrivateKeyPathButton";
            selectPrivateKeyPathButton.Size = new Size(75, 23);
            selectPrivateKeyPathButton.TabIndex = 8;
            selectPrivateKeyPathButton.Text = "选择路径";
            selectPrivateKeyPathButton.UseVisualStyleBackColor = true;
            selectPrivateKeyPathButton.Click += selectPrivateKeyPathButton_Click;
            // 
            // openPrivateKeyPathButton
            // 
            openPrivateKeyPathButton.Location = new Point(298, 82);
            openPrivateKeyPathButton.Name = "openPrivateKeyPathButton";
            openPrivateKeyPathButton.Size = new Size(75, 23);
            openPrivateKeyPathButton.TabIndex = 9;
            openPrivateKeyPathButton.Text = "打开路径";
            openPrivateKeyPathButton.UseVisualStyleBackColor = true;
            openPrivateKeyPathButton.Click += openPrivateKeyPathButton_Click;
            // 
            // selectPublicKeyPathButton
            // 
            selectPublicKeyPathButton.Location = new Point(679, 53);
            selectPublicKeyPathButton.Name = "selectPublicKeyPathButton";
            selectPublicKeyPathButton.Size = new Size(75, 23);
            selectPublicKeyPathButton.TabIndex = 10;
            selectPublicKeyPathButton.Text = "选择路径";
            selectPublicKeyPathButton.UseVisualStyleBackColor = true;
            selectPublicKeyPathButton.Click += selectPublicKeyPathButton_Click;
            // 
            // openPublicKeyPathButton
            // 
            openPublicKeyPathButton.Location = new Point(679, 82);
            openPublicKeyPathButton.Name = "openPublicKeyPathButton";
            openPublicKeyPathButton.Size = new Size(75, 23);
            openPublicKeyPathButton.TabIndex = 11;
            openPublicKeyPathButton.Text = "打开路径";
            openPublicKeyPathButton.UseVisualStyleBackColor = true;
            openPublicKeyPathButton.Click += openPublicKeyPathButton_Click;
            // 
            // generatorButton
            // 
            generatorButton.Location = new Point(351, 430);
            generatorButton.Name = "generatorButton";
            generatorButton.Size = new Size(75, 23);
            generatorButton.TabIndex = 12;
            generatorButton.Text = "生成";
            generatorButton.UseVisualStyleBackColor = true;
            generatorButton.Click += generatorButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 473);
            Controls.Add(generatorButton);
            Controls.Add(openPublicKeyPathButton);
            Controls.Add(selectPublicKeyPathButton);
            Controls.Add(openPrivateKeyPathButton);
            Controls.Add(selectPrivateKeyPathButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(publicKeyTextBox);
            Controls.Add(publicKeyPathTextBox);
            Controls.Add(privateKeyTextBox);
            Controls.Add(privateKeyPathTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "RSA Key 生成器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox privateKeyPathTextBox;
        private TextBox privateKeyTextBox;
        private TextBox publicKeyPathTextBox;
        private TextBox publicKeyTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button selectPrivateKeyPathButton;
        private Button openPrivateKeyPathButton;
        private Button selectPublicKeyPathButton;
        private Button openPublicKeyPathButton;
        private Button generatorButton;
    }
}