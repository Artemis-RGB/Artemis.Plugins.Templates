namespace ModuleProjectWizard
{
    partial class UserInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModuleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUseDataModel = new System.Windows.Forms.CheckBox();
            this.checkboxExpandsMainDataModel = new System.Windows.Forms.CheckBox();
            this.checkBoxCustomTab = new System.Windows.Forms.CheckBox();
            this.comboBoxModuleType = new System.Windows.Forms.ComboBox();
            this.checkBoxUseProfiles = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module name";
            // 
            // textBoxModuleName
            // 
            this.textBoxModuleName.Location = new System.Drawing.Point(15, 30);
            this.textBoxModuleName.Name = "textBoxModuleName";
            this.textBoxModuleName.Size = new System.Drawing.Size(655, 22);
            this.textBoxModuleName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Module category";
            // 
            // checkBoxUseDataModel
            // 
            this.checkBoxUseDataModel.AutoSize = true;
            this.checkBoxUseDataModel.Location = new System.Drawing.Point(15, 185);
            this.checkBoxUseDataModel.Name = "checkBoxUseDataModel";
            this.checkBoxUseDataModel.Size = new System.Drawing.Size(136, 21);
            this.checkBoxUseDataModel.TabIndex = 4;
            this.checkBoxUseDataModel.Text = "Uses data model";
            this.checkBoxUseDataModel.UseVisualStyleBackColor = true;
            // 
            // checkboxExpandsMainDataModel
            // 
            this.checkboxExpandsMainDataModel.AutoSize = true;
            this.checkboxExpandsMainDataModel.Location = new System.Drawing.Point(15, 230);
            this.checkboxExpandsMainDataModel.Name = "checkboxExpandsMainDataModel";
            this.checkboxExpandsMainDataModel.Size = new System.Drawing.Size(192, 21);
            this.checkboxExpandsMainDataModel.TabIndex = 5;
            this.checkboxExpandsMainDataModel.Text = "Expands main data model";
            this.checkboxExpandsMainDataModel.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomTab
            // 
            this.checkBoxCustomTab.AutoSize = true;
            this.checkBoxCustomTab.Location = new System.Drawing.Point(15, 279);
            this.checkBoxCustomTab.Name = "checkBoxCustomTab";
            this.checkBoxCustomTab.Size = new System.Drawing.Size(172, 21);
            this.checkBoxCustomTab.TabIndex = 6;
            this.checkBoxCustomTab.Text = "Includes custom UI tab";
            this.checkBoxCustomTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxModuleType
            // 
            this.comboBoxModuleType.FormattingEnabled = true;
            this.comboBoxModuleType.Items.AddRange(new object[] {
            "General",
            "Application/game",
            "Overlay"});
            this.comboBoxModuleType.Location = new System.Drawing.Point(15, 77);
            this.comboBoxModuleType.Name = "comboBoxModuleType";
            this.comboBoxModuleType.Size = new System.Drawing.Size(655, 24);
            this.comboBoxModuleType.TabIndex = 7;
            // 
            // checkBoxUseProfiles
            // 
            this.checkBoxUseProfiles.AutoSize = true;
            this.checkBoxUseProfiles.Location = new System.Drawing.Point(15, 139);
            this.checkBoxUseProfiles.Name = "checkBoxUseProfiles";
            this.checkBoxUseProfiles.Size = new System.Drawing.Size(124, 21);
            this.checkBoxUseProfiles.TabIndex = 8;
            this.checkBoxUseProfiles.Text = "Enable profiles";
            this.checkBoxUseProfiles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(658, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "The category defines a starting point for the module\'s render priority. This can " +
    "be changed by the user.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "When enabled, users can create profiles for this module";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(499, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "When checked, a sample data model is generated and included in the project.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(477, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "When checked, the data model you define is visible to every other module.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(572, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "When checked, a sample view and view model are generated and included in the proj" +
    "ect. \r\nThis allows you to create your own UI for your module.";
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxUseProfiles);
            this.Controls.Add(this.comboBoxModuleType);
            this.Controls.Add(this.checkBoxCustomTab);
            this.Controls.Add(this.checkboxExpandsMainDataModel);
            this.Controls.Add(this.checkBoxUseDataModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxModuleName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInputForm";
            this.Text = "Artemis project wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModuleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxUseDataModel;
        private System.Windows.Forms.CheckBox checkboxExpandsMainDataModel;
        private System.Windows.Forms.CheckBox checkBoxCustomTab;
        private System.Windows.Forms.ComboBox comboBoxModuleType;
        private System.Windows.Forms.CheckBox checkBoxUseProfiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}