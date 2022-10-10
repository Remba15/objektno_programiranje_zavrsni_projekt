namespace Zork_styled_game
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStartScreen = new System.Windows.Forms.TabPage();
            this.labelCredits = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.tabPageGameScreen = new System.Windows.Forms.TabPage();
            this.listBoxInventory = new System.Windows.Forms.ListBox();
            this.listBoxGameText = new System.Windows.Forms.ListBox();
            this.buttonCloseInventory = new System.Windows.Forms.Button();
            this.labelInventoryList = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageStartScreen.SuspendLayout();
            this.tabPageGameScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStartScreen);
            this.tabControl1.Controls.Add(this.tabPageGameScreen);
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 21);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 688);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStartScreen
            // 
            this.tabPageStartScreen.Controls.Add(this.labelCredits);
            this.tabPageStartScreen.Controls.Add(this.buttonQuit);
            this.tabPageStartScreen.Controls.Add(this.buttonStart);
            this.tabPageStartScreen.Controls.Add(this.labelGameTitle);
            this.tabPageStartScreen.Location = new System.Drawing.Point(4, 25);
            this.tabPageStartScreen.Name = "tabPageStartScreen";
            this.tabPageStartScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartScreen.Size = new System.Drawing.Size(1075, 659);
            this.tabPageStartScreen.TabIndex = 0;
            this.tabPageStartScreen.Text = "StartScreen";
            this.tabPageStartScreen.UseVisualStyleBackColor = true;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(7, 640);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(261, 15);
            this.labelCredits.TabIndex = 3;
            this.labelCredits.Text = "Created as student project by Renato Kuna, 2022";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuit.Location = new System.Drawing.Point(437, 268);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(158, 73);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(437, 189);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(158, 73);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.Font = new System.Drawing.Font("Papyrus", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGameTitle.Location = new System.Drawing.Point(232, 3);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(583, 106);
            this.labelGameTitle.TabIndex = 0;
            this.labelGameTitle.Text = "Zork-styled Game";
            // 
            // tabPageGameScreen
            // 
            this.tabPageGameScreen.Controls.Add(this.listBoxInventory);
            this.tabPageGameScreen.Controls.Add(this.listBoxGameText);
            this.tabPageGameScreen.Controls.Add(this.buttonCloseInventory);
            this.tabPageGameScreen.Controls.Add(this.labelInventoryList);
            this.tabPageGameScreen.Controls.Add(this.buttonExit);
            this.tabPageGameScreen.Controls.Add(this.buttonInventory);
            this.tabPageGameScreen.Controls.Add(this.buttonRestart);
            this.tabPageGameScreen.Controls.Add(this.buttonSend);
            this.tabPageGameScreen.Controls.Add(this.textBoxCommands);
            this.tabPageGameScreen.Location = new System.Drawing.Point(4, 25);
            this.tabPageGameScreen.Name = "tabPageGameScreen";
            this.tabPageGameScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGameScreen.Size = new System.Drawing.Size(1075, 659);
            this.tabPageGameScreen.TabIndex = 1;
            this.tabPageGameScreen.Text = "GameScreen";
            this.tabPageGameScreen.UseVisualStyleBackColor = true;
            // 
            // listBoxInventory
            // 
            this.listBoxInventory.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxInventory.FormattingEnabled = true;
            this.listBoxInventory.ItemHeight = 15;
            this.listBoxInventory.Location = new System.Drawing.Point(910, 151);
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.Size = new System.Drawing.Size(159, 334);
            this.listBoxInventory.TabIndex = 11;
            this.listBoxInventory.Visible = false;
            // 
            // listBoxGameText
            // 
            this.listBoxGameText.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxGameText.ColumnWidth = 1000;
            this.listBoxGameText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxGameText.FormattingEnabled = true;
            this.listBoxGameText.HorizontalScrollbar = true;
            this.listBoxGameText.ItemHeight = 17;
            this.listBoxGameText.Location = new System.Drawing.Point(7, 6);
            this.listBoxGameText.Name = "listBoxGameText";
            this.listBoxGameText.Size = new System.Drawing.Size(889, 531);
            this.listBoxGameText.TabIndex = 10;
            this.listBoxGameText.UseWaitCursor = true;
            // 
            // buttonCloseInventory
            // 
            this.buttonCloseInventory.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseInventory.Location = new System.Drawing.Point(910, 490);
            this.buttonCloseInventory.Name = "buttonCloseInventory";
            this.buttonCloseInventory.Size = new System.Drawing.Size(159, 52);
            this.buttonCloseInventory.TabIndex = 8;
            this.buttonCloseInventory.Text = "Close inventory";
            this.buttonCloseInventory.UseVisualStyleBackColor = true;
            this.buttonCloseInventory.Visible = false;
            this.buttonCloseInventory.Click += new System.EventHandler(this.buttonCloseInventory_Click);
            // 
            // labelInventoryList
            // 
            this.labelInventoryList.AutoSize = true;
            this.labelInventoryList.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventoryList.Location = new System.Drawing.Point(910, 124);
            this.labelInventoryList.Name = "labelInventoryList";
            this.labelInventoryList.Size = new System.Drawing.Size(133, 24);
            this.labelInventoryList.TabIndex = 7;
            this.labelInventoryList.Text = "Inventory List:";
            this.labelInventoryList.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(910, 548);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(159, 52);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInventory.Location = new System.Drawing.Point(910, 64);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(159, 52);
            this.buttonInventory.TabIndex = 4;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.Location = new System.Drawing.Point(910, 6);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(159, 52);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.Location = new System.Drawing.Point(820, 606);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(84, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Location = new System.Drawing.Point(7, 606);
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(807, 23);
            this.textBoxCommands.TabIndex = 1;
            this.textBoxCommands.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCommands_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStartScreen.ResumeLayout(false);
            this.tabPageStartScreen.PerformLayout();
            this.tabPageGameScreen.ResumeLayout(false);
            this.tabPageGameScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageStartScreen;
        private Button buttonQuit;
        private Button buttonStart;
        private Label labelGameTitle;
        private TabPage tabPageGameScreen;
        private Label labelInventoryList;
        private Button buttonExit;
        private Button buttonInventory;
        private Button buttonRestart;
        private Button buttonSend;
        private TextBox textBoxCommands;
        private Button buttonCloseInventory;
        private Label labelCredits;
        private ListBox listBoxGameText;
        private ListBox listBoxInventory;
    }
}