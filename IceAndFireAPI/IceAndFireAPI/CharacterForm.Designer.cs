
namespace IceAndFireAPI
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.btn_Search = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Born = new System.Windows.Forms.Label();
            this.label_Culture = new System.Windows.Forms.Label();
            this.label_Died = new System.Windows.Forms.Label();
            this.txt_CharacterID = new System.Windows.Forms.TextBox();
            this.label_DescDied = new System.Windows.Forms.Label();
            this.label_DescBorn = new System.Windows.Forms.Label();
            this.label_DescCulture = new System.Windows.Forms.Label();
            this.label_DescGender = new System.Windows.Forms.Label();
            this.label_DescName = new System.Windows.Forms.Label();
            this.listbox_Allegiance = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_DescWelcome = new System.Windows.Forms.Label();
            this.label_DescTry = new System.Windows.Forms.Label();
            this.label_DescEnterID = new System.Windows.Forms.Label();
            this.label_Explain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(269, 138);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(168, 223);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(77, 23);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.BackColor = System.Drawing.Color.Transparent;
            this.label_Gender.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_Gender.Location = new System.Drawing.Point(168, 272);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(101, 23);
            this.label_Gender.TabIndex = 2;
            this.label_Gender.Text = "Gender";
            // 
            // label_Born
            // 
            this.label_Born.AutoSize = true;
            this.label_Born.BackColor = System.Drawing.Color.Transparent;
            this.label_Born.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Born.ForeColor = System.Drawing.Color.Indigo;
            this.label_Born.Location = new System.Drawing.Point(168, 357);
            this.label_Born.Name = "label_Born";
            this.label_Born.Size = new System.Drawing.Size(75, 23);
            this.label_Born.TabIndex = 4;
            this.label_Born.Text = "Born";
            // 
            // label_Culture
            // 
            this.label_Culture.AutoSize = true;
            this.label_Culture.BackColor = System.Drawing.Color.Transparent;
            this.label_Culture.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Culture.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Culture.Location = new System.Drawing.Point(168, 314);
            this.label_Culture.Name = "label_Culture";
            this.label_Culture.Size = new System.Drawing.Size(116, 23);
            this.label_Culture.TabIndex = 3;
            this.label_Culture.Text = "Culture";
            // 
            // label_Died
            // 
            this.label_Died.AutoSize = true;
            this.label_Died.BackColor = System.Drawing.Color.Transparent;
            this.label_Died.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Died.ForeColor = System.Drawing.Color.Crimson;
            this.label_Died.Location = new System.Drawing.Point(168, 397);
            this.label_Died.Name = "label_Died";
            this.label_Died.Size = new System.Drawing.Size(64, 23);
            this.label_Died.TabIndex = 5;
            this.label_Died.Text = "Died";
            // 
            // txt_CharacterID
            // 
            this.txt_CharacterID.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_CharacterID.Location = new System.Drawing.Point(163, 140);
            this.txt_CharacterID.Name = "txt_CharacterID";
            this.txt_CharacterID.Size = new System.Drawing.Size(100, 20);
            this.txt_CharacterID.TabIndex = 6;
            // 
            // label_DescDied
            // 
            this.label_DescDied.AutoSize = true;
            this.label_DescDied.BackColor = System.Drawing.Color.Transparent;
            this.label_DescDied.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescDied.ForeColor = System.Drawing.Color.Crimson;
            this.label_DescDied.Location = new System.Drawing.Point(63, 397);
            this.label_DescDied.Name = "label_DescDied";
            this.label_DescDied.Size = new System.Drawing.Size(104, 23);
            this.label_DescDied.TabIndex = 11;
            this.label_DescDied.Text = "Died in:";
            // 
            // label_DescBorn
            // 
            this.label_DescBorn.AutoSize = true;
            this.label_DescBorn.BackColor = System.Drawing.Color.Transparent;
            this.label_DescBorn.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescBorn.ForeColor = System.Drawing.Color.Indigo;
            this.label_DescBorn.Location = new System.Drawing.Point(52, 357);
            this.label_DescBorn.Name = "label_DescBorn";
            this.label_DescBorn.Size = new System.Drawing.Size(115, 23);
            this.label_DescBorn.TabIndex = 10;
            this.label_DescBorn.Text = "Born in:";
            // 
            // label_DescCulture
            // 
            this.label_DescCulture.AutoSize = true;
            this.label_DescCulture.BackColor = System.Drawing.Color.Transparent;
            this.label_DescCulture.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescCulture.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_DescCulture.Location = new System.Drawing.Point(45, 314);
            this.label_DescCulture.Name = "label_DescCulture";
            this.label_DescCulture.Size = new System.Drawing.Size(122, 23);
            this.label_DescCulture.TabIndex = 9;
            this.label_DescCulture.Text = "Culture:";
            // 
            // label_DescGender
            // 
            this.label_DescGender.AutoSize = true;
            this.label_DescGender.BackColor = System.Drawing.Color.Transparent;
            this.label_DescGender.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescGender.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_DescGender.Location = new System.Drawing.Point(59, 272);
            this.label_DescGender.Name = "label_DescGender";
            this.label_DescGender.Size = new System.Drawing.Size(107, 23);
            this.label_DescGender.TabIndex = 8;
            this.label_DescGender.Text = "Gender:";
            // 
            // label_DescName
            // 
            this.label_DescName.AutoSize = true;
            this.label_DescName.BackColor = System.Drawing.Color.Transparent;
            this.label_DescName.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescName.Location = new System.Drawing.Point(81, 223);
            this.label_DescName.Name = "label_DescName";
            this.label_DescName.Size = new System.Drawing.Size(83, 23);
            this.label_DescName.TabIndex = 7;
            this.label_DescName.Text = "Name:";
            // 
            // listbox_Allegiance
            // 
            this.listbox_Allegiance.BackColor = System.Drawing.Color.Bisque;
            this.listbox_Allegiance.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Allegiance.FormattingEnabled = true;
            this.listbox_Allegiance.ItemHeight = 15;
            this.listbox_Allegiance.Items.AddRange(new object[] {
            "No Allegiance detected"});
            this.listbox_Allegiance.Location = new System.Drawing.Point(577, 138);
            this.listbox_Allegiance.Name = "listbox_Allegiance";
            this.listbox_Allegiance.Size = new System.Drawing.Size(229, 199);
            this.listbox_Allegiance.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Allegiances";
            // 
            // label_DescWelcome
            // 
            this.label_DescWelcome.AutoSize = true;
            this.label_DescWelcome.BackColor = System.Drawing.Color.Transparent;
            this.label_DescWelcome.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescWelcome.Location = new System.Drawing.Point(20, 34);
            this.label_DescWelcome.Name = "label_DescWelcome";
            this.label_DescWelcome.Size = new System.Drawing.Size(721, 23);
            this.label_DescWelcome.TabIndex = 16;
            this.label_DescWelcome.Text = "Welcome to the \'Game of Throne\' character informer!";
            // 
            // label_DescTry
            // 
            this.label_DescTry.AutoSize = true;
            this.label_DescTry.BackColor = System.Drawing.Color.Transparent;
            this.label_DescTry.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescTry.Location = new System.Drawing.Point(132, 164);
            this.label_DescTry.Name = "label_DescTry";
            this.label_DescTry.Size = new System.Drawing.Size(157, 14);
            this.label_DescTry.TabIndex = 17;
            this.label_DescTry.Text = "Try ID 583 or 2138 !";
            // 
            // label_DescEnterID
            // 
            this.label_DescEnterID.AutoSize = true;
            this.label_DescEnterID.BackColor = System.Drawing.Color.Transparent;
            this.label_DescEnterID.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescEnterID.Location = new System.Drawing.Point(44, 138);
            this.label_DescEnterID.Name = "label_DescEnterID";
            this.label_DescEnterID.Size = new System.Drawing.Size(113, 23);
            this.label_DescEnterID.TabIndex = 18;
            this.label_DescEnterID.Text = "Enter ID:";
            // 
            // label_Explain
            // 
            this.label_Explain.AutoSize = true;
            this.label_Explain.BackColor = System.Drawing.Color.Transparent;
            this.label_Explain.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Explain.Location = new System.Drawing.Point(30, 106);
            this.label_Explain.Name = "label_Explain";
            this.label_Explain.Size = new System.Drawing.Size(380, 57);
            this.label_Explain.TabIndex = 19;
            this.label_Explain.Text = "Over 2000 character ID to choose from!\r\n\r\n\r\n";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 513);
            this.Controls.Add(this.label_DescEnterID);
            this.Controls.Add(this.label_DescTry);
            this.Controls.Add(this.label_DescWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_Allegiance);
            this.Controls.Add(this.label_DescDied);
            this.Controls.Add(this.label_DescBorn);
            this.Controls.Add(this.label_DescCulture);
            this.Controls.Add(this.label_DescGender);
            this.Controls.Add(this.label_DescName);
            this.Controls.Add(this.txt_CharacterID);
            this.Controls.Add(this.label_Died);
            this.Controls.Add(this.label_Born);
            this.Controls.Add(this.label_Culture);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label_Explain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterForm";
            this.Text = "Game of Thrones Character Informer";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Born;
        private System.Windows.Forms.Label label_Culture;
        private System.Windows.Forms.Label label_Died;
        private System.Windows.Forms.TextBox txt_CharacterID;
        private System.Windows.Forms.Label label_DescDied;
        private System.Windows.Forms.Label label_DescBorn;
        private System.Windows.Forms.Label label_DescCulture;
        private System.Windows.Forms.Label label_DescGender;
        private System.Windows.Forms.Label label_DescName;
        private System.Windows.Forms.ListBox listbox_Allegiance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DescWelcome;
        private System.Windows.Forms.Label label_DescTry;
        private System.Windows.Forms.Label label_DescEnterID;
        private System.Windows.Forms.Label label_Explain;
    }
}

