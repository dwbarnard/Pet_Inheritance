namespace PetsInheritance
{
	partial class Form1
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
			this.addButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.petInfoTextBox = new System.Windows.Forms.TextBox();
			this.petListBox = new System.Windows.Forms.ListBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.petTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.birdRadioBtn = new System.Windows.Forms.RadioButton();
			this.catRadioBtn = new System.Windows.Forms.RadioButton();
			this.dogRadioBtn = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.petTypeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(197, 0);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.Button1_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(197, 29);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 2;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(197, 58);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 3;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.Button3_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(197, 87);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 4;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// petInfoTextBox
			// 
			this.petInfoTextBox.Location = new System.Drawing.Point(0, 144);
			this.petInfoTextBox.Multiline = true;
			this.petInfoTextBox.Name = "petInfoTextBox";
			this.petInfoTextBox.Size = new System.Drawing.Size(272, 318);
			this.petInfoTextBox.TabIndex = 5;
			// 
			// petListBox
			// 
			this.petListBox.FormattingEnabled = true;
			this.petListBox.Location = new System.Drawing.Point(0, 0);
			this.petListBox.Name = "petListBox";
			this.petListBox.Size = new System.Drawing.Size(191, 134);
			this.petListBox.TabIndex = 6;
			this.petListBox.SelectedIndexChanged += new System.EventHandler(this.petListBox_SelectedIndexChanged);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(411, 3);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(188, 20);
			this.inputTextBox.TabIndex = 7;
			this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
			// 
			// petTypeGroupBox
			// 
			this.petTypeGroupBox.Controls.Add(this.birdRadioBtn);
			this.petTypeGroupBox.Controls.Add(this.catRadioBtn);
			this.petTypeGroupBox.Controls.Add(this.dogRadioBtn);
			this.petTypeGroupBox.Location = new System.Drawing.Point(316, 33);
			this.petTypeGroupBox.Name = "petTypeGroupBox";
			this.petTypeGroupBox.Size = new System.Drawing.Size(188, 91);
			this.petTypeGroupBox.TabIndex = 9;
			this.petTypeGroupBox.TabStop = false;
			this.petTypeGroupBox.Text = "Select your type of pet:";
			this.petTypeGroupBox.Enter += new System.EventHandler(this.petTypeGroupBox_Enter);
			// 
			// birdRadioBtn
			// 
			this.birdRadioBtn.AutoSize = true;
			this.birdRadioBtn.Location = new System.Drawing.Point(0, 65);
			this.birdRadioBtn.Name = "birdRadioBtn";
			this.birdRadioBtn.Size = new System.Drawing.Size(43, 17);
			this.birdRadioBtn.TabIndex = 11;
			this.birdRadioBtn.Text = "Bird";
			this.birdRadioBtn.UseVisualStyleBackColor = true;
			this.birdRadioBtn.CheckedChanged += new System.EventHandler(this.birdRadioBtn_CheckedChanged);
			// 
			// catRadioBtn
			// 
			this.catRadioBtn.AutoSize = true;
			this.catRadioBtn.Location = new System.Drawing.Point(0, 42);
			this.catRadioBtn.Name = "catRadioBtn";
			this.catRadioBtn.Size = new System.Drawing.Size(41, 17);
			this.catRadioBtn.TabIndex = 10;
			this.catRadioBtn.Text = "Cat";
			this.catRadioBtn.UseVisualStyleBackColor = true;
			this.catRadioBtn.CheckedChanged += new System.EventHandler(this.catRadioBtn_CheckedChanged);
			// 
			// dogRadioBtn
			// 
			this.dogRadioBtn.AutoSize = true;
			this.dogRadioBtn.Location = new System.Drawing.Point(0, 19);
			this.dogRadioBtn.Name = "dogRadioBtn";
			this.dogRadioBtn.Size = new System.Drawing.Size(45, 17);
			this.dogRadioBtn.TabIndex = 9;
			this.dogRadioBtn.Text = "Dog";
			this.dogRadioBtn.UseVisualStyleBackColor = true;
			this.dogRadioBtn.CheckedChanged += new System.EventHandler(this.dogRadioBtn_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(313, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Enter Pet\'s Name:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 532);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.petTypeGroupBox);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.petListBox);
			this.Controls.Add(this.petInfoTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.addButton);
			this.Name = "Form1";
			this.Text = "Pet Inheritance";
			this.petTypeGroupBox.ResumeLayout(false);
			this.petTypeGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TextBox petInfoTextBox;
		private System.Windows.Forms.ListBox petListBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.GroupBox petTypeGroupBox;
		private System.Windows.Forms.RadioButton birdRadioBtn;
		private System.Windows.Forms.RadioButton catRadioBtn;
		private System.Windows.Forms.RadioButton dogRadioBtn;
		private System.Windows.Forms.Label label1;
	}
}

