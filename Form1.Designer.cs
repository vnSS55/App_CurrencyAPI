namespace App_CurrencyAPI
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
            Get_currency_button = new Button();
            Base_currency_combobox = new ComboBox();
            Target_currency_combobox = new ComboBox();
            Convert_text_label = new Label();
            info_label = new Label();
            Value_TextBox = new TextBox();
            Result_Textbox = new TextBox();
            Swap_currency_button = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            label1 = new Label();
            SuspendLayout();
            // 
            // Get_currency_button
            // 
            Get_currency_button.Location = new Point(12, 119);
            Get_currency_button.Name = "Get_currency_button";
            Get_currency_button.Size = new Size(128, 49);
            Get_currency_button.TabIndex = 0;
            Get_currency_button.Text = "Convert";
            Get_currency_button.UseVisualStyleBackColor = true;
            Get_currency_button.Click += Get_currency_button_Click;
            // 
            // Base_currency_combobox
            // 
            Base_currency_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Base_currency_combobox.FormattingEnabled = true;
            Base_currency_combobox.Location = new Point(552, 74);
            Base_currency_combobox.Name = "Base_currency_combobox";
            Base_currency_combobox.Size = new Size(68, 28);
            Base_currency_combobox.TabIndex = 2;
            // 
            // Target_currency_combobox
            // 
            Target_currency_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Target_currency_combobox.FormattingEnabled = true;
            Target_currency_combobox.Location = new Point(187, 73);
            Target_currency_combobox.Name = "Target_currency_combobox";
            Target_currency_combobox.Size = new Size(84, 28);
            Target_currency_combobox.TabIndex = 3;
            // 
            // Convert_text_label
            // 
            Convert_text_label.AutoSize = true;
            Convert_text_label.Location = new Point(187, 47);
            Convert_text_label.Name = "Convert_text_label";
            Convert_text_label.Size = new Size(43, 20);
            Convert_text_label.TabIndex = 4;
            Convert_text_label.Text = "From";
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Location = new Point(187, 119);
            info_label.Name = "info_label";
            info_label.Size = new Size(38, 20);
            info_label.TabIndex = 5;
            info_label.Text = "info.";
            // 
            // Value_TextBox
            // 
            Value_TextBox.Location = new Point(12, 74);
            Value_TextBox.Name = "Value_TextBox";
            Value_TextBox.PlaceholderText = "Enter a value";
            Value_TextBox.RightToLeft = RightToLeft.Yes;
            Value_TextBox.Size = new Size(169, 27);
            Value_TextBox.TabIndex = 6;
            // 
            // Result_Textbox
            // 
            Result_Textbox.Enabled = false;
            Result_Textbox.Location = new Point(367, 73);
            Result_Textbox.Name = "Result_Textbox";
            Result_Textbox.PlaceholderText = "Result";
            Result_Textbox.RightToLeft = RightToLeft.Yes;
            Result_Textbox.Size = new Size(169, 27);
            Result_Textbox.TabIndex = 7;
            // 
            // Swap_currency_button
            // 
            Swap_currency_button.Location = new Point(277, 71);
            Swap_currency_button.Name = "Swap_currency_button";
            Swap_currency_button.Size = new Size(84, 30);
            Swap_currency_button.TabIndex = 8;
            Swap_currency_button.Text = "Swap";
            Swap_currency_button.UseVisualStyleBackColor = true;
            Swap_currency_button.Click += Swap_currency_button_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(134, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Currency Converter";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(18, 34);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(596, 10);
            materialDivider1.TabIndex = 10;
            materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 47);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 11;
            label1.Text = "To";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 182);
            Controls.Add(label1);
            Controls.Add(materialDivider1);
            Controls.Add(materialLabel1);
            Controls.Add(Swap_currency_button);
            Controls.Add(Result_Textbox);
            Controls.Add(Value_TextBox);
            Controls.Add(info_label);
            Controls.Add(Convert_text_label);
            Controls.Add(Target_currency_combobox);
            Controls.Add(Base_currency_combobox);
            Controls.Add(Get_currency_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Get_currency_button;
        private ComboBox Base_currency_combobox;
        private ComboBox Target_currency_combobox;
        private Label Convert_text_label;
        private Label info_label;
        private TextBox Value_TextBox;
        private TextBox Result_Textbox;
        private Button Swap_currency_button;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label label1;
    }
}
