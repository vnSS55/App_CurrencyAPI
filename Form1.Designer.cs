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
            Currency_Title_label = new Label();
            Base_currency_combobox = new ComboBox();
            Target_currency_combobox = new ComboBox();
            Convert_text_label = new Label();
            info_label = new Label();
            Value_TextBox = new TextBox();
            Result_Textbox = new TextBox();
            Swap_currency_button = new Button();
            SuspendLayout();
            // 
            // Get_currency_button
            // 
            Get_currency_button.Location = new Point(18, 117);
            Get_currency_button.Name = "Get_currency_button";
            Get_currency_button.Size = new Size(128, 49);
            Get_currency_button.TabIndex = 0;
            Get_currency_button.Text = "Convert";
            Get_currency_button.UseVisualStyleBackColor = true;
            Get_currency_button.Click += Get_currency_button_Click;
            // 
            // Currency_Title_label
            // 
            Currency_Title_label.AutoSize = true;
            Currency_Title_label.Location = new Point(12, 26);
            Currency_Title_label.Name = "Currency_Title_label";
            Currency_Title_label.Size = new Size(134, 20);
            Currency_Title_label.TabIndex = 1;
            Currency_Title_label.Text = "Currency Converter";
            // 
            // Base_currency_combobox
            // 
            Base_currency_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Base_currency_combobox.FormattingEnabled = true;
            Base_currency_combobox.Location = new Point(187, 58);
            Base_currency_combobox.Name = "Base_currency_combobox";
            Base_currency_combobox.Size = new Size(68, 28);
            Base_currency_combobox.TabIndex = 2;
            // 
            // Target_currency_combobox
            // 
            Target_currency_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Target_currency_combobox.FormattingEnabled = true;
            Target_currency_combobox.Location = new Point(373, 58);
            Target_currency_combobox.Name = "Target_currency_combobox";
            Target_currency_combobox.Size = new Size(60, 28);
            Target_currency_combobox.TabIndex = 3;
            // 
            // Convert_text_label
            // 
            Convert_text_label.AutoSize = true;
            Convert_text_label.Location = new Point(261, 61);
            Convert_text_label.Name = "Convert_text_label";
            Convert_text_label.Size = new Size(106, 20);
            Convert_text_label.TabIndex = 4;
            Convert_text_label.Text = "> Convert to >";
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Location = new Point(217, 166);
            info_label.Name = "info_label";
            info_label.Size = new Size(38, 20);
            info_label.TabIndex = 5;
            info_label.Text = "info.";
            // 
            // Value_TextBox
            // 
            Value_TextBox.Location = new Point(12, 59);
            Value_TextBox.Name = "Value_TextBox";
            Value_TextBox.PlaceholderText = "Enter a value";
            Value_TextBox.Size = new Size(169, 27);
            Value_TextBox.TabIndex = 6;
            // 
            // Result_Textbox
            // 
            Result_Textbox.Enabled = false;
            Result_Textbox.Location = new Point(12, 202);
            Result_Textbox.Name = "Result_Textbox";
            Result_Textbox.PlaceholderText = "Result";
            Result_Textbox.Size = new Size(159, 27);
            Result_Textbox.TabIndex = 7;
            // 
            // Swap_currency_button
            // 
            Swap_currency_button.Location = new Point(261, 98);
            Swap_currency_button.Name = "Swap_currency_button";
            Swap_currency_button.Size = new Size(106, 39);
            Swap_currency_button.TabIndex = 8;
            Swap_currency_button.Text = "Swap";
            Swap_currency_button.UseVisualStyleBackColor = true;
            Swap_currency_button.Click += Swap_currency_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Swap_currency_button);
            Controls.Add(Result_Textbox);
            Controls.Add(Value_TextBox);
            Controls.Add(info_label);
            Controls.Add(Convert_text_label);
            Controls.Add(Target_currency_combobox);
            Controls.Add(Base_currency_combobox);
            Controls.Add(Currency_Title_label);
            Controls.Add(Get_currency_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Get_currency_button;
        private Label Currency_Title_label;
        private ComboBox Base_currency_combobox;
        private ComboBox Target_currency_combobox;
        private Label Convert_text_label;
        private Label info_label;
        private TextBox Value_TextBox;
        private TextBox Result_Textbox;
        private Button Swap_currency_button;
    }
}
