namespace Bridge_System_Writer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            biddingDisplay = new DataGridView();
            North = new DataGridViewTextBoxColumn();
            East = new DataGridViewTextBoxColumn();
            South = new DataGridViewTextBoxColumn();
            West = new DataGridViewTextBoxColumn();
            button00 = new Button();
            bidButtonsBox = new GroupBox();
            button34 = new Button();
            button29 = new Button();
            button24 = new Button();
            button19 = new Button();
            button14 = new Button();
            button09 = new Button();
            button33 = new Button();
            button32 = new Button();
            button31 = new Button();
            button30 = new Button();
            button28 = new Button();
            button27 = new Button();
            button26 = new Button();
            button25 = new Button();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button08 = new Button();
            button07 = new Button();
            button06 = new Button();
            button05 = new Button();
            button04 = new Button();
            button03 = new Button();
            button02 = new Button();
            button01 = new Button();
            dataGridViewNewBids = new DataGridView();
            nextBidColumn = new DataGridViewTextBoxColumn();
            descriptionColumn = new DataGridViewTextBoxColumn();
            buttonUndoBid = new Button();
            textboxCurrentBid = new RichTextBox();
            dealerGroupBox = new GroupBox();
            radioButtonEast = new RadioButton();
            radioButtonNorth = new RadioButton();
            vulnGroupBox = new GroupBox();
            checkBoxVulAny = new CheckBox();
            radioButtonVulBoth = new RadioButton();
            radioButtonVulEW = new RadioButton();
            radioButtonVulNS = new RadioButton();
            radioButtonVulNone = new RadioButton();
            buttonRedouble = new Button();
            buttonDouble = new Button();
            buttonPass = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)biddingDisplay).BeginInit();
            bidButtonsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNewBids).BeginInit();
            dealerGroupBox.SuspendLayout();
            vulnGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // biddingDisplay
            // 
            biddingDisplay.AllowUserToDeleteRows = false;
            biddingDisplay.AllowUserToResizeColumns = false;
            biddingDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            biddingDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            biddingDisplay.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            biddingDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            biddingDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            biddingDisplay.Columns.AddRange(new DataGridViewColumn[] { North, East, South, West });
            biddingDisplay.EditMode = DataGridViewEditMode.EditProgrammatically;
            biddingDisplay.Location = new Point(12, 12);
            biddingDisplay.MultiSelect = false;
            biddingDisplay.Name = "biddingDisplay";
            biddingDisplay.ReadOnly = true;
            biddingDisplay.RowHeadersVisible = false;
            biddingDisplay.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            biddingDisplay.RowTemplate.Height = 25;
            biddingDisplay.ScrollBars = ScrollBars.Vertical;
            biddingDisplay.ShowCellErrors = false;
            biddingDisplay.ShowCellToolTips = false;
            biddingDisplay.ShowEditingIcon = false;
            biddingDisplay.ShowRowErrors = false;
            biddingDisplay.Size = new Size(295, 191);
            biddingDisplay.TabIndex = 0;
            biddingDisplay.CellStateChanged += refocusCell;
            // 
            // North
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            North.DefaultCellStyle = dataGridViewCellStyle3;
            North.HeaderText = "N";
            North.Name = "North";
            North.ReadOnly = true;
            North.Resizable = DataGridViewTriState.False;
            North.SortMode = DataGridViewColumnSortMode.NotSortable;
            North.Width = 74;
            // 
            // East
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            East.DefaultCellStyle = dataGridViewCellStyle4;
            East.HeaderText = "E";
            East.Name = "East";
            East.ReadOnly = true;
            East.Resizable = DataGridViewTriState.False;
            East.SortMode = DataGridViewColumnSortMode.NotSortable;
            East.Width = 74;
            // 
            // South
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            South.DefaultCellStyle = dataGridViewCellStyle5;
            South.HeaderText = "S";
            South.Name = "South";
            South.ReadOnly = true;
            South.Resizable = DataGridViewTriState.False;
            South.SortMode = DataGridViewColumnSortMode.NotSortable;
            South.Width = 74;
            // 
            // West
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            West.DefaultCellStyle = dataGridViewCellStyle6;
            West.HeaderText = "W";
            West.Name = "West";
            West.ReadOnly = true;
            West.Resizable = DataGridViewTriState.False;
            West.SortMode = DataGridViewColumnSortMode.NotSortable;
            West.Width = 74;
            // 
            // button00
            // 
            button00.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button00.Location = new Point(6, 22);
            button00.Name = "button00";
            button00.Size = new Size(49, 35);
            button00.TabIndex = 0;
            button00.Text = "1♣︎";
            button00.UseVisualStyleBackColor = true;
            button00.Click += bidClick;
            // 
            // bidButtonsBox
            // 
            bidButtonsBox.Controls.Add(button34);
            bidButtonsBox.Controls.Add(button29);
            bidButtonsBox.Controls.Add(button24);
            bidButtonsBox.Controls.Add(button19);
            bidButtonsBox.Controls.Add(button14);
            bidButtonsBox.Controls.Add(button09);
            bidButtonsBox.Controls.Add(button33);
            bidButtonsBox.Controls.Add(button32);
            bidButtonsBox.Controls.Add(button31);
            bidButtonsBox.Controls.Add(button30);
            bidButtonsBox.Controls.Add(button28);
            bidButtonsBox.Controls.Add(button27);
            bidButtonsBox.Controls.Add(button26);
            bidButtonsBox.Controls.Add(button25);
            bidButtonsBox.Controls.Add(button23);
            bidButtonsBox.Controls.Add(button22);
            bidButtonsBox.Controls.Add(button21);
            bidButtonsBox.Controls.Add(button20);
            bidButtonsBox.Controls.Add(button18);
            bidButtonsBox.Controls.Add(button17);
            bidButtonsBox.Controls.Add(button16);
            bidButtonsBox.Controls.Add(button15);
            bidButtonsBox.Controls.Add(button13);
            bidButtonsBox.Controls.Add(button12);
            bidButtonsBox.Controls.Add(button11);
            bidButtonsBox.Controls.Add(button10);
            bidButtonsBox.Controls.Add(button08);
            bidButtonsBox.Controls.Add(button07);
            bidButtonsBox.Controls.Add(button06);
            bidButtonsBox.Controls.Add(button05);
            bidButtonsBox.Controls.Add(button04);
            bidButtonsBox.Controls.Add(button03);
            bidButtonsBox.Controls.Add(button02);
            bidButtonsBox.Controls.Add(button01);
            bidButtonsBox.Controls.Add(button00);
            bidButtonsBox.Location = new Point(12, 202);
            bidButtonsBox.Name = "bidButtonsBox";
            bidButtonsBox.Size = new Size(295, 309);
            bidButtonsBox.TabIndex = 1;
            bidButtonsBox.TabStop = false;
            // 
            // button34
            // 
            button34.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button34.Location = new Point(226, 268);
            button34.Name = "button34";
            button34.Size = new Size(63, 35);
            button34.TabIndex = 34;
            button34.Text = "7NT";
            button34.UseVisualStyleBackColor = true;
            button34.Click += bidClick;
            // 
            // button29
            // 
            button29.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button29.Location = new Point(226, 227);
            button29.Name = "button29";
            button29.Size = new Size(63, 35);
            button29.TabIndex = 29;
            button29.Text = "6NT";
            button29.UseVisualStyleBackColor = true;
            button29.Click += bidClick;
            // 
            // button24
            // 
            button24.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button24.Location = new Point(226, 186);
            button24.Name = "button24";
            button24.Size = new Size(63, 35);
            button24.TabIndex = 24;
            button24.Text = "5NT";
            button24.UseVisualStyleBackColor = true;
            button24.Click += bidClick;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(226, 145);
            button19.Name = "button19";
            button19.Size = new Size(63, 35);
            button19.TabIndex = 19;
            button19.Text = "4NT";
            button19.UseVisualStyleBackColor = true;
            button19.Click += bidClick;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(226, 104);
            button14.Name = "button14";
            button14.Size = new Size(63, 35);
            button14.TabIndex = 14;
            button14.Text = "3NT";
            button14.UseVisualStyleBackColor = true;
            button14.Click += bidClick;
            // 
            // button09
            // 
            button09.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button09.Location = new Point(226, 63);
            button09.Name = "button09";
            button09.Size = new Size(63, 35);
            button09.TabIndex = 9;
            button09.Text = "2NT";
            button09.UseVisualStyleBackColor = true;
            button09.Click += bidClick;
            // 
            // button33
            // 
            button33.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button33.Location = new Point(171, 268);
            button33.Name = "button33";
            button33.Size = new Size(49, 35);
            button33.TabIndex = 33;
            button33.Text = "7♠︎";
            button33.UseVisualStyleBackColor = true;
            button33.Click += bidClick;
            // 
            // button32
            // 
            button32.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button32.Location = new Point(116, 268);
            button32.Name = "button32";
            button32.Size = new Size(49, 35);
            button32.TabIndex = 32;
            button32.Text = "7♥️";
            button32.UseVisualStyleBackColor = true;
            button32.Click += bidClick;
            // 
            // button31
            // 
            button31.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button31.Location = new Point(61, 268);
            button31.Name = "button31";
            button31.Size = new Size(49, 35);
            button31.TabIndex = 31;
            button31.Text = "7♦︎";
            button31.UseVisualStyleBackColor = true;
            button31.Click += bidClick;
            // 
            // button30
            // 
            button30.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button30.Location = new Point(6, 268);
            button30.Name = "button30";
            button30.Size = new Size(49, 35);
            button30.TabIndex = 30;
            button30.Text = "7♣︎";
            button30.UseVisualStyleBackColor = true;
            button30.Click += bidClick;
            // 
            // button28
            // 
            button28.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button28.Location = new Point(171, 227);
            button28.Name = "button28";
            button28.Size = new Size(49, 35);
            button28.TabIndex = 28;
            button28.Text = "6♠︎";
            button28.UseVisualStyleBackColor = true;
            button28.Click += bidClick;
            // 
            // button27
            // 
            button27.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button27.Location = new Point(116, 227);
            button27.Name = "button27";
            button27.Size = new Size(49, 35);
            button27.TabIndex = 27;
            button27.Text = "6♥️";
            button27.UseVisualStyleBackColor = true;
            button27.Click += bidClick;
            // 
            // button26
            // 
            button26.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button26.Location = new Point(61, 227);
            button26.Name = "button26";
            button26.Size = new Size(49, 35);
            button26.TabIndex = 26;
            button26.Text = "6♦︎";
            button26.UseVisualStyleBackColor = true;
            button26.Click += bidClick;
            // 
            // button25
            // 
            button25.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button25.Location = new Point(6, 227);
            button25.Name = "button25";
            button25.Size = new Size(49, 35);
            button25.TabIndex = 25;
            button25.Text = "6♣︎";
            button25.UseVisualStyleBackColor = true;
            button25.Click += bidClick;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button23.Location = new Point(171, 186);
            button23.Name = "button23";
            button23.Size = new Size(49, 35);
            button23.TabIndex = 23;
            button23.Text = "5♠︎";
            button23.UseVisualStyleBackColor = true;
            button23.Click += bidClick;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button22.Location = new Point(116, 186);
            button22.Name = "button22";
            button22.Size = new Size(49, 35);
            button22.TabIndex = 22;
            button22.Text = "5♥️";
            button22.UseVisualStyleBackColor = true;
            button22.Click += bidClick;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button21.Location = new Point(61, 186);
            button21.Name = "button21";
            button21.Size = new Size(49, 35);
            button21.TabIndex = 21;
            button21.Text = "5♦︎";
            button21.UseVisualStyleBackColor = true;
            button21.Click += bidClick;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(6, 186);
            button20.Name = "button20";
            button20.Size = new Size(49, 35);
            button20.TabIndex = 20;
            button20.Text = "5♣︎";
            button20.UseVisualStyleBackColor = true;
            button20.Click += bidClick;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(171, 145);
            button18.Name = "button18";
            button18.Size = new Size(49, 35);
            button18.TabIndex = 18;
            button18.Text = "4♠︎";
            button18.UseVisualStyleBackColor = true;
            button18.Click += bidClick;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(116, 145);
            button17.Name = "button17";
            button17.Size = new Size(49, 35);
            button17.TabIndex = 17;
            button17.Text = "4♥️";
            button17.UseVisualStyleBackColor = true;
            button17.Click += bidClick;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(61, 145);
            button16.Name = "button16";
            button16.Size = new Size(49, 35);
            button16.TabIndex = 16;
            button16.Text = "4♦︎";
            button16.UseVisualStyleBackColor = true;
            button16.Click += bidClick;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(6, 145);
            button15.Name = "button15";
            button15.Size = new Size(49, 35);
            button15.TabIndex = 15;
            button15.Text = "4♣︎";
            button15.UseVisualStyleBackColor = true;
            button15.Click += bidClick;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(171, 104);
            button13.Name = "button13";
            button13.Size = new Size(49, 35);
            button13.TabIndex = 13;
            button13.Text = "3♠︎";
            button13.UseVisualStyleBackColor = true;
            button13.Click += bidClick;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(116, 104);
            button12.Name = "button12";
            button12.Size = new Size(49, 35);
            button12.TabIndex = 12;
            button12.Text = "3♥️";
            button12.UseVisualStyleBackColor = true;
            button12.Click += bidClick;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(61, 104);
            button11.Name = "button11";
            button11.Size = new Size(49, 35);
            button11.TabIndex = 11;
            button11.Text = "3♦︎";
            button11.UseVisualStyleBackColor = true;
            button11.Click += bidClick;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(6, 104);
            button10.Name = "button10";
            button10.Size = new Size(49, 35);
            button10.TabIndex = 10;
            button10.Text = "3♣︎";
            button10.UseVisualStyleBackColor = true;
            button10.Click += bidClick;
            // 
            // button08
            // 
            button08.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button08.Location = new Point(171, 63);
            button08.Name = "button08";
            button08.Size = new Size(49, 35);
            button08.TabIndex = 8;
            button08.Text = "2♠︎";
            button08.UseVisualStyleBackColor = true;
            button08.Click += bidClick;
            // 
            // button07
            // 
            button07.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button07.Location = new Point(116, 63);
            button07.Name = "button07";
            button07.Size = new Size(49, 35);
            button07.TabIndex = 7;
            button07.Text = "2♥️";
            button07.UseVisualStyleBackColor = true;
            button07.Click += bidClick;
            // 
            // button06
            // 
            button06.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button06.Location = new Point(61, 63);
            button06.Name = "button06";
            button06.Size = new Size(49, 35);
            button06.TabIndex = 6;
            button06.Text = "2♦︎";
            button06.UseVisualStyleBackColor = true;
            button06.Click += bidClick;
            // 
            // button05
            // 
            button05.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button05.Location = new Point(6, 63);
            button05.Name = "button05";
            button05.Size = new Size(49, 35);
            button05.TabIndex = 5;
            button05.Text = "2♣︎";
            button05.UseVisualStyleBackColor = true;
            button05.Click += bidClick;
            // 
            // button04
            // 
            button04.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button04.Location = new Point(226, 22);
            button04.Name = "button04";
            button04.Size = new Size(63, 35);
            button04.TabIndex = 4;
            button04.Text = "1NT";
            button04.UseVisualStyleBackColor = true;
            button04.Click += bidClick;
            // 
            // button03
            // 
            button03.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button03.Location = new Point(171, 22);
            button03.Name = "button03";
            button03.Size = new Size(49, 35);
            button03.TabIndex = 3;
            button03.Text = "1♠︎";
            button03.UseVisualStyleBackColor = true;
            button03.Click += bidClick;
            // 
            // button02
            // 
            button02.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button02.Location = new Point(116, 22);
            button02.Name = "button02";
            button02.Size = new Size(49, 35);
            button02.TabIndex = 2;
            button02.Text = "1♥️";
            button02.UseVisualStyleBackColor = true;
            button02.Click += bidClick;
            // 
            // button01
            // 
            button01.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button01.Location = new Point(61, 22);
            button01.Name = "button01";
            button01.Size = new Size(49, 35);
            button01.TabIndex = 1;
            button01.Text = "1♦︎";
            button01.UseVisualStyleBackColor = true;
            button01.Click += bidClick;
            // 
            // dataGridViewNewBids
            // 
            dataGridViewNewBids.AllowUserToAddRows = false;
            dataGridViewNewBids.AllowUserToDeleteRows = false;
            dataGridViewNewBids.AllowUserToResizeColumns = false;
            dataGridViewNewBids.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewNewBids.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewNewBids.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewNewBids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewNewBids.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNewBids.Columns.AddRange(new DataGridViewColumn[] { nextBidColumn, descriptionColumn });
            dataGridViewNewBids.Location = new Point(313, 236);
            dataGridViewNewBids.Name = "dataGridViewNewBids";
            dataGridViewNewBids.ReadOnly = true;
            dataGridViewNewBids.RowHeadersVisible = false;
            dataGridViewNewBids.RowTemplate.Height = 25;
            dataGridViewNewBids.ScrollBars = ScrollBars.Vertical;
            dataGridViewNewBids.ShowCellErrors = false;
            dataGridViewNewBids.ShowCellToolTips = false;
            dataGridViewNewBids.ShowEditingIcon = false;
            dataGridViewNewBids.ShowRowErrors = false;
            dataGridViewNewBids.Size = new Size(404, 330);
            dataGridViewNewBids.TabIndex = 1;
            // 
            // nextBidColumn
            // 
            nextBidColumn.HeaderText = "Next Bid";
            nextBidColumn.Name = "nextBidColumn";
            nextBidColumn.ReadOnly = true;
            nextBidColumn.Resizable = DataGridViewTriState.False;
            nextBidColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            nextBidColumn.Width = 80;
            // 
            // descriptionColumn
            // 
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.Name = "descriptionColumn";
            descriptionColumn.ReadOnly = true;
            descriptionColumn.Resizable = DataGridViewTriState.False;
            descriptionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            descriptionColumn.Width = 320;
            // 
            // buttonUndoBid
            // 
            buttonUndoBid.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUndoBid.Location = new Point(317, 186);
            buttonUndoBid.Name = "buttonUndoBid";
            buttonUndoBid.Size = new Size(50, 44);
            buttonUndoBid.TabIndex = 3;
            buttonUndoBid.Text = "←";
            buttonUndoBid.TextAlign = ContentAlignment.TopCenter;
            buttonUndoBid.UseVisualStyleBackColor = true;
            buttonUndoBid.Click += undoBidClick;
            // 
            // textboxCurrentBid
            // 
            textboxCurrentBid.DetectUrls = false;
            textboxCurrentBid.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textboxCurrentBid.Location = new Point(464, 12);
            textboxCurrentBid.Name = "textboxCurrentBid";
            textboxCurrentBid.ScrollBars = RichTextBoxScrollBars.Vertical;
            textboxCurrentBid.Size = new Size(255, 218);
            textboxCurrentBid.TabIndex = 4;
            textboxCurrentBid.Text = "";
            // 
            // dealerGroupBox
            // 
            dealerGroupBox.Controls.Add(radioButtonEast);
            dealerGroupBox.Controls.Add(radioButtonNorth);
            dealerGroupBox.Location = new Point(315, 12);
            dealerGroupBox.Name = "dealerGroupBox";
            dealerGroupBox.Size = new Size(143, 68);
            dealerGroupBox.TabIndex = 5;
            dealerGroupBox.TabStop = false;
            dealerGroupBox.Text = "Dealer";
            // 
            // radioButtonEast
            // 
            radioButtonEast.AutoSize = true;
            radioButtonEast.Location = new Point(6, 43);
            radioButtonEast.Name = "radioButtonEast";
            radioButtonEast.Size = new Size(46, 19);
            radioButtonEast.TabIndex = 1;
            radioButtonEast.Text = "East";
            radioButtonEast.UseVisualStyleBackColor = true;
            // 
            // radioButtonNorth
            // 
            radioButtonNorth.AutoSize = true;
            radioButtonNorth.Checked = true;
            radioButtonNorth.Location = new Point(6, 22);
            radioButtonNorth.Name = "radioButtonNorth";
            radioButtonNorth.Size = new Size(56, 19);
            radioButtonNorth.TabIndex = 0;
            radioButtonNorth.TabStop = true;
            radioButtonNorth.Text = "North";
            radioButtonNorth.UseVisualStyleBackColor = true;
            // 
            // vulnGroupBox
            // 
            vulnGroupBox.Controls.Add(checkBoxVulAny);
            vulnGroupBox.Controls.Add(radioButtonVulBoth);
            vulnGroupBox.Controls.Add(radioButtonVulEW);
            vulnGroupBox.Controls.Add(radioButtonVulNS);
            vulnGroupBox.Controls.Add(radioButtonVulNone);
            vulnGroupBox.Location = new Point(317, 86);
            vulnGroupBox.Name = "vulnGroupBox";
            vulnGroupBox.Size = new Size(141, 94);
            vulnGroupBox.TabIndex = 6;
            vulnGroupBox.TabStop = false;
            vulnGroupBox.Text = "Vulnerability";
            // 
            // checkBoxVulAny
            // 
            checkBoxVulAny.AutoSize = true;
            checkBoxVulAny.Checked = true;
            checkBoxVulAny.CheckState = CheckState.Checked;
            checkBoxVulAny.Location = new Point(11, 70);
            checkBoxVulAny.Name = "checkBoxVulAny";
            checkBoxVulAny.Size = new Size(116, 19);
            checkBoxVulAny.TabIndex = 4;
            checkBoxVulAny.Text = "Any Vulnerability";
            checkBoxVulAny.UseVisualStyleBackColor = true;
            // 
            // radioButtonVulBoth
            // 
            radioButtonVulBoth.AutoSize = true;
            radioButtonVulBoth.Location = new Point(77, 20);
            radioButtonVulBoth.Name = "radioButtonVulBoth";
            radioButtonVulBoth.Size = new Size(50, 19);
            radioButtonVulBoth.TabIndex = 3;
            radioButtonVulBoth.Text = "Both";
            radioButtonVulBoth.UseVisualStyleBackColor = true;
            // 
            // radioButtonVulEW
            // 
            radioButtonVulEW.AutoSize = true;
            radioButtonVulEW.Location = new Point(77, 45);
            radioButtonVulEW.Name = "radioButtonVulEW";
            radioButtonVulEW.Size = new Size(42, 19);
            radioButtonVulEW.TabIndex = 2;
            radioButtonVulEW.Text = "EW";
            radioButtonVulEW.UseVisualStyleBackColor = true;
            // 
            // radioButtonVulNS
            // 
            radioButtonVulNS.AutoSize = true;
            radioButtonVulNS.Location = new Point(5, 45);
            radioButtonVulNS.Name = "radioButtonVulNS";
            radioButtonVulNS.Size = new Size(40, 19);
            radioButtonVulNS.TabIndex = 1;
            radioButtonVulNS.Text = "NS";
            radioButtonVulNS.UseVisualStyleBackColor = true;
            // 
            // radioButtonVulNone
            // 
            radioButtonVulNone.AutoSize = true;
            radioButtonVulNone.Checked = true;
            radioButtonVulNone.Location = new Point(5, 20);
            radioButtonVulNone.Name = "radioButtonVulNone";
            radioButtonVulNone.Size = new Size(54, 19);
            radioButtonVulNone.TabIndex = 0;
            radioButtonVulNone.TabStop = true;
            radioButtonVulNone.Text = "None";
            radioButtonVulNone.UseVisualStyleBackColor = true;
            // 
            // buttonRedouble
            // 
            buttonRedouble.Enabled = false;
            buttonRedouble.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRedouble.Location = new Point(73, 517);
            buttonRedouble.Name = "buttonRedouble";
            buttonRedouble.Size = new Size(49, 35);
            buttonRedouble.TabIndex = 39;
            buttonRedouble.Text = "XX";
            buttonRedouble.UseVisualStyleBackColor = true;
            buttonRedouble.Click += bidClick;
            // 
            // buttonDouble
            // 
            buttonDouble.Enabled = false;
            buttonDouble.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDouble.Location = new Point(18, 517);
            buttonDouble.Name = "buttonDouble";
            buttonDouble.Size = new Size(49, 35);
            buttonDouble.TabIndex = 38;
            buttonDouble.Text = "X";
            buttonDouble.UseVisualStyleBackColor = true;
            buttonDouble.Click += bidClick;
            // 
            // buttonPass
            // 
            buttonPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPass.Location = new Point(238, 517);
            buttonPass.Name = "buttonPass";
            buttonPass.Size = new Size(63, 35);
            buttonPass.TabIndex = 40;
            buttonPass.Text = "Pass";
            buttonPass.UseVisualStyleBackColor = true;
            buttonPass.Click += bidClick;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(373, 186);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(85, 44);
            buttonReset.TabIndex = 41;
            buttonReset.Text = "Reset Bids";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += resetBidsClick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(729, 578);
            Controls.Add(buttonReset);
            Controls.Add(buttonRedouble);
            Controls.Add(buttonDouble);
            Controls.Add(buttonPass);
            Controls.Add(vulnGroupBox);
            Controls.Add(dealerGroupBox);
            Controls.Add(textboxCurrentBid);
            Controls.Add(buttonUndoBid);
            Controls.Add(dataGridViewNewBids);
            Controls.Add(bidButtonsBox);
            Controls.Add(biddingDisplay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Bridge System Writer";
            ((System.ComponentModel.ISupportInitialize)biddingDisplay).EndInit();
            bidButtonsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNewBids).EndInit();
            dealerGroupBox.ResumeLayout(false);
            dealerGroupBox.PerformLayout();
            vulnGroupBox.ResumeLayout(false);
            vulnGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button00;
        private GroupBox bidButtonsBox;
        private Button button04;
        private Button button03;
        private Button button02;
        private Button button01;
        private DataGridView dataGridViewNewBids;
        private DataGridViewTextBoxColumn nextBidColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
        private Button buttonUndoBid;
        private RichTextBox textboxCurrentBid;
        private GroupBox dealerGroupBox;
        private RadioButton radioButtonEast;
        private RadioButton radioButtonNorth;
        private GroupBox vulnGroupBox;
        private CheckBox checkBoxVulAny;
        private RadioButton radioButtonVulBoth;
        private RadioButton radioButtonVulEW;
        private RadioButton radioButtonVulNS;
        private RadioButton radioButtonVulNone;
        private Button button34;
        private Button button29;
        private Button button24;
        private Button button19;
        private Button button14;
        private Button button09;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button08;
        private Button button07;
        private Button button06;
        private Button button05;
        private Button buttonRedouble;
        private Button buttonDouble;
        private Button buttonPass;
        private DataGridView biddingDisplay;
        private DataGridViewTextBoxColumn North;
        private DataGridViewTextBoxColumn East;
        private DataGridViewTextBoxColumn South;
        private DataGridViewTextBoxColumn West;
        private Button buttonReset;
    }
}