namespace WebDbClient.Forms
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hotelInsertButton = new System.Windows.Forms.Button();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.hotelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.hotelInsertTextBox = new System.Windows.Forms.TextBox();
            this.hotelGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.freeRoomGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hotelTypeInsertButton = new System.Windows.Forms.Button();
            this.hotelTypeInserttextBox = new System.Windows.Forms.TextBox();
            this.hotelTypeGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.areaInsertButton = new System.Windows.Forms.Button();
            this.areaInsertTextBox = new System.Windows.Forms.TextBox();
            this.areaGridView = new System.Windows.Forms.DataGridView();
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.roomPriceTextBox = new System.Windows.Forms.TextBox();
            this.insertRoomButton = new System.Windows.Forms.Button();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateHotelButton = new System.Windows.Forms.Button();
            this.deleteHotelButton = new System.Windows.Forms.Button();
            this.hotelIndexComboBox = new System.Windows.Forms.ComboBox();
            this.roomUpdateButton = new System.Windows.Forms.Button();
            this.roomDeleteButton = new System.Windows.Forms.Button();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.hotelTypesDeleteButton = new System.Windows.Forms.Button();
            this.hotelTypesDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.areaDeleteButton = new System.Windows.Forms.Button();
            this.areaDeleteCombobox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeRoomGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelTypeGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateHotelButton);
            this.tabPage1.Controls.Add(this.deleteHotelButton);
            this.tabPage1.Controls.Add(this.hotelIndexComboBox);
            this.tabPage1.Controls.Add(this.hotelInsertButton);
            this.tabPage1.Controls.Add(this.areaComboBox);
            this.tabPage1.Controls.Add(this.hotelTypeComboBox);
            this.tabPage1.Controls.Add(this.hotelInsertTextBox);
            this.tabPage1.Controls.Add(this.hotelGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hotels";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // hotelInsertButton
            // 
            this.hotelInsertButton.Location = new System.Drawing.Point(387, 120);
            this.hotelInsertButton.Name = "hotelInsertButton";
            this.hotelInsertButton.Size = new System.Drawing.Size(109, 22);
            this.hotelInsertButton.TabIndex = 4;
            this.hotelInsertButton.Text = "Insert";
            this.hotelInsertButton.UseVisualStyleBackColor = true;
            this.hotelInsertButton.Click += new System.EventHandler(this.hotelInsertButton_Click);
            // 
            // areaComboBox
            // 
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(387, 66);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(109, 21);
            this.areaComboBox.TabIndex = 3;
            // 
            // hotelTypeComboBox
            // 
            this.hotelTypeComboBox.FormattingEnabled = true;
            this.hotelTypeComboBox.Location = new System.Drawing.Point(387, 93);
            this.hotelTypeComboBox.Name = "hotelTypeComboBox";
            this.hotelTypeComboBox.Size = new System.Drawing.Size(109, 21);
            this.hotelTypeComboBox.TabIndex = 2;
            // 
            // hotelInsertTextBox
            // 
            this.hotelInsertTextBox.Location = new System.Drawing.Point(387, 40);
            this.hotelInsertTextBox.Name = "hotelInsertTextBox";
            this.hotelInsertTextBox.Size = new System.Drawing.Size(109, 20);
            this.hotelInsertTextBox.TabIndex = 1;
            // 
            // hotelGridView
            // 
            this.hotelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.hotelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotelGridView.Location = new System.Drawing.Point(0, 3);
            this.hotelGridView.Name = "hotelGridView";
            this.hotelGridView.Size = new System.Drawing.Size(361, 415);
            this.hotelGridView.TabIndex = 0;
            this.hotelGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotelsGridView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomUpdateButton);
            this.tabPage2.Controls.Add(this.roomDeleteButton);
            this.tabPage2.Controls.Add(this.roomComboBox);
            this.tabPage2.Controls.Add(this.roomNumberTextBox);
            this.tabPage2.Controls.Add(this.insertRoomButton);
            this.tabPage2.Controls.Add(this.hotelComboBox);
            this.tabPage2.Controls.Add(this.roomPriceTextBox);
            this.tabPage2.Controls.Add(this.freeRoomGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Free Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // freeRoomGridView
            // 
            this.freeRoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.freeRoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freeRoomGridView.Location = new System.Drawing.Point(3, 3);
            this.freeRoomGridView.Name = "freeRoomGridView";
            this.freeRoomGridView.Size = new System.Drawing.Size(361, 415);
            this.freeRoomGridView.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hotelTypesDeleteButton);
            this.tabPage3.Controls.Add(this.hotelTypesDeleteComboBox);
            this.tabPage3.Controls.Add(this.hotelTypeInsertButton);
            this.tabPage3.Controls.Add(this.hotelTypeInserttextBox);
            this.tabPage3.Controls.Add(this.hotelTypeGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hotel Types";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hotelTypeInsertButton
            // 
            this.hotelTypeInsertButton.Location = new System.Drawing.Point(387, 57);
            this.hotelTypeInsertButton.Name = "hotelTypeInsertButton";
            this.hotelTypeInsertButton.Size = new System.Drawing.Size(100, 22);
            this.hotelTypeInsertButton.TabIndex = 5;
            this.hotelTypeInsertButton.Text = "Insert";
            this.hotelTypeInsertButton.UseVisualStyleBackColor = true;
            this.hotelTypeInsertButton.Click += new System.EventHandler(this.hotelTypeInsertButton_Click);
            // 
            // hotelTypeInserttextBox
            // 
            this.hotelTypeInserttextBox.Location = new System.Drawing.Point(387, 15);
            this.hotelTypeInserttextBox.Name = "hotelTypeInserttextBox";
            this.hotelTypeInserttextBox.Size = new System.Drawing.Size(100, 20);
            this.hotelTypeInserttextBox.TabIndex = 4;
            // 
            // hotelTypeGridView
            // 
            this.hotelTypeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.hotelTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelTypeGridView.Location = new System.Drawing.Point(3, 3);
            this.hotelTypeGridView.Name = "hotelTypeGridView";
            this.hotelTypeGridView.Size = new System.Drawing.Size(361, 415);
            this.hotelTypeGridView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.areaDeleteButton);
            this.tabPage4.Controls.Add(this.areaDeleteCombobox);
            this.tabPage4.Controls.Add(this.areaInsertButton);
            this.tabPage4.Controls.Add(this.areaInsertTextBox);
            this.tabPage4.Controls.Add(this.areaGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Areas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // areaInsertButton
            // 
            this.areaInsertButton.Location = new System.Drawing.Point(387, 59);
            this.areaInsertButton.Name = "areaInsertButton";
            this.areaInsertButton.Size = new System.Drawing.Size(100, 22);
            this.areaInsertButton.TabIndex = 3;
            this.areaInsertButton.Text = "Insert";
            this.areaInsertButton.UseVisualStyleBackColor = true;
            this.areaInsertButton.Click += new System.EventHandler(this.areaInsertButton_Click);
            // 
            // areaInsertTextBox
            // 
            this.areaInsertTextBox.Location = new System.Drawing.Point(387, 17);
            this.areaInsertTextBox.Name = "areaInsertTextBox";
            this.areaInsertTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaInsertTextBox.TabIndex = 2;
            // 
            // areaGridView
            // 
            this.areaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.areaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areaGridView.Location = new System.Drawing.Point(3, 3);
            this.areaGridView.Name = "areaGridView";
            this.areaGridView.Size = new System.Drawing.Size(361, 415);
            this.areaGridView.TabIndex = 1;
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Location = new System.Drawing.Point(387, 69);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(109, 21);
            this.hotelComboBox.TabIndex = 4;
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.Location = new System.Drawing.Point(387, 43);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(109, 20);
            this.roomPriceTextBox.TabIndex = 3;
            // 
            // insertRoomButton
            // 
            this.insertRoomButton.Location = new System.Drawing.Point(387, 96);
            this.insertRoomButton.Name = "insertRoomButton";
            this.insertRoomButton.Size = new System.Drawing.Size(109, 22);
            this.insertRoomButton.TabIndex = 5;
            this.insertRoomButton.Text = "Insert";
            this.insertRoomButton.UseVisualStyleBackColor = true;
            this.insertRoomButton.Click += new System.EventHandler(this.insertRoomButton_Click);
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(387, 17);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(109, 20);
            this.roomNumberTextBox.TabIndex = 6;
            // 
            // updateHotelButton
            // 
            this.updateHotelButton.Location = new System.Drawing.Point(616, 66);
            this.updateHotelButton.Name = "updateHotelButton";
            this.updateHotelButton.Size = new System.Drawing.Size(54, 22);
            this.updateHotelButton.TabIndex = 12;
            this.updateHotelButton.Text = "Update";
            this.updateHotelButton.UseVisualStyleBackColor = true;
            this.updateHotelButton.Click += new System.EventHandler(this.updateHotelButton_Click);
            // 
            // deleteHotelButton
            // 
            this.deleteHotelButton.Location = new System.Drawing.Point(561, 66);
            this.deleteHotelButton.Name = "deleteHotelButton";
            this.deleteHotelButton.Size = new System.Drawing.Size(54, 22);
            this.deleteHotelButton.TabIndex = 11;
            this.deleteHotelButton.Text = "Delete";
            this.deleteHotelButton.UseVisualStyleBackColor = true;
            this.deleteHotelButton.Click += new System.EventHandler(this.deleteHotelButton_Click_1);
            // 
            // hotelIndexComboBox
            // 
            this.hotelIndexComboBox.FormattingEnabled = true;
            this.hotelIndexComboBox.Location = new System.Drawing.Point(561, 39);
            this.hotelIndexComboBox.Name = "hotelIndexComboBox";
            this.hotelIndexComboBox.Size = new System.Drawing.Size(109, 21);
            this.hotelIndexComboBox.TabIndex = 10;
            // 
            // roomUpdateButton
            // 
            this.roomUpdateButton.Location = new System.Drawing.Point(620, 43);
            this.roomUpdateButton.Name = "roomUpdateButton";
            this.roomUpdateButton.Size = new System.Drawing.Size(54, 22);
            this.roomUpdateButton.TabIndex = 15;
            this.roomUpdateButton.Text = "Update";
            this.roomUpdateButton.UseVisualStyleBackColor = true;
            this.roomUpdateButton.Click += new System.EventHandler(this.roomUpdateButton_Click);
            // 
            // roomDeleteButton
            // 
            this.roomDeleteButton.Location = new System.Drawing.Point(565, 43);
            this.roomDeleteButton.Name = "roomDeleteButton";
            this.roomDeleteButton.Size = new System.Drawing.Size(54, 22);
            this.roomDeleteButton.TabIndex = 14;
            this.roomDeleteButton.Text = "Delete";
            this.roomDeleteButton.UseVisualStyleBackColor = true;
            this.roomDeleteButton.Click += new System.EventHandler(this.roomDeleteButton_Click);
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(565, 16);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(109, 21);
            this.roomComboBox.TabIndex = 13;
            // 
            // hotelTypesDeleteButton
            // 
            this.hotelTypesDeleteButton.Location = new System.Drawing.Point(538, 43);
            this.hotelTypesDeleteButton.Name = "hotelTypesDeleteButton";
            this.hotelTypesDeleteButton.Size = new System.Drawing.Size(109, 22);
            this.hotelTypesDeleteButton.TabIndex = 13;
            this.hotelTypesDeleteButton.Text = "Delete";
            this.hotelTypesDeleteButton.UseVisualStyleBackColor = true;
            this.hotelTypesDeleteButton.Click += new System.EventHandler(this.hotelTypesDeleteButton_Click);
            // 
            // hotelTypesDeleteComboBox
            // 
            this.hotelTypesDeleteComboBox.FormattingEnabled = true;
            this.hotelTypesDeleteComboBox.Location = new System.Drawing.Point(538, 16);
            this.hotelTypesDeleteComboBox.Name = "hotelTypesDeleteComboBox";
            this.hotelTypesDeleteComboBox.Size = new System.Drawing.Size(109, 21);
            this.hotelTypesDeleteComboBox.TabIndex = 12;
            // 
            // areaDeleteButton
            // 
            this.areaDeleteButton.Location = new System.Drawing.Point(566, 44);
            this.areaDeleteButton.Name = "areaDeleteButton";
            this.areaDeleteButton.Size = new System.Drawing.Size(109, 22);
            this.areaDeleteButton.TabIndex = 15;
            this.areaDeleteButton.Text = "Delete";
            this.areaDeleteButton.UseVisualStyleBackColor = true;
            this.areaDeleteButton.Click += new System.EventHandler(this.areaDeleteButton_Click);
            // 
            // areaDeleteCombobox
            // 
            this.areaDeleteCombobox.FormattingEnabled = true;
            this.areaDeleteCombobox.Location = new System.Drawing.Point(566, 17);
            this.areaDeleteCombobox.Name = "areaDeleteCombobox";
            this.areaDeleteCombobox.Size = new System.Drawing.Size(109, 21);
            this.areaDeleteCombobox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeRoomGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelTypeGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView hotelGridView;
        private System.Windows.Forms.DataGridView freeRoomGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView hotelTypeGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView areaGridView;
        private System.Windows.Forms.Button areaInsertButton;
        private System.Windows.Forms.TextBox areaInsertTextBox;
        private System.Windows.Forms.Button hotelTypeInsertButton;
        private System.Windows.Forms.TextBox hotelTypeInserttextBox;
        private System.Windows.Forms.Button hotelInsertButton;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.ComboBox hotelTypeComboBox;
        private System.Windows.Forms.TextBox hotelInsertTextBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Button insertRoomButton;
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.TextBox roomPriceTextBox;
        private System.Windows.Forms.Button updateHotelButton;
        private System.Windows.Forms.Button deleteHotelButton;
        private System.Windows.Forms.ComboBox hotelIndexComboBox;
        private System.Windows.Forms.Button roomUpdateButton;
        private System.Windows.Forms.Button roomDeleteButton;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Button hotelTypesDeleteButton;
        private System.Windows.Forms.ComboBox hotelTypesDeleteComboBox;
        private System.Windows.Forms.Button areaDeleteButton;
        private System.Windows.Forms.ComboBox areaDeleteCombobox;
    }
}