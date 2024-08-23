namespace dfggfd
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
            dataGridView1 = new DataGridView();
            ghjk = new DataGridViewTextBoxColumn();
            ten = new DataGridViewTextBoxColumn();
            typecustomer = new DataGridViewTextBoxColumn();
            thismonth = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            clmtt = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            texthis = new TextBox();
            txbname = new TextBox();
            textid = new TextBox();
            textlast = new TextBox();
            txbphone = new TextBox();
            ccbtype = new ComboBox();
            label7 = new Label();
            txtsearch = new TextBox();
            button7 = new Button();
            txtbill = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ghjk, ten, typecustomer, thismonth, Column1, Column2, clmtt });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(18, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ghjk
            // 
            ghjk.HeaderText = "name";
            ghjk.MinimumWidth = 6;
            ghjk.Name = "ghjk";
            ghjk.Width = 125;
            // 
            // ten
            // 
            ten.HeaderText = "id";
            ten.MinimumWidth = 6;
            ten.Name = "ten";
            ten.Width = 125;
            // 
            // typecustomer
            // 
            typecustomer.HeaderText = "type of customer";
            typecustomer.MinimumWidth = 6;
            typecustomer.Name = "typecustomer";
            typecustomer.Width = 125;
            // 
            // thismonth
            // 
            thismonth.HeaderText = "thismonth";
            thismonth.MinimumWidth = 6;
            thismonth.Name = "thismonth";
            thismonth.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "last month";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "phone";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // clmtt
            // 
            clmtt.HeaderText = "total";
            clmtt.MinimumWidth = 6;
            clmtt.Name = "clmtt";
            clmtt.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(749, 54);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(749, 89);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(749, 124);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(749, 159);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(749, 194);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(749, 229);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "exit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 188);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "this month";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 137);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 8;
            label2.Text = "type";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 25);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 79);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 10;
            label4.Text = "id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 234);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 11;
            label5.Text = "last month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 286);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 12;
            label6.Text = "phone";
            // 
            // texthis
            // 
            texthis.Location = new Point(133, 181);
            texthis.Name = "texthis";
            texthis.Size = new Size(151, 27);
            texthis.TabIndex = 13;
            // 
            // txbname
            // 
            txbname.Location = new Point(133, 25);
            txbname.Name = "txbname";
            txbname.Size = new Size(151, 27);
            txbname.TabIndex = 15;
            // 
            // textid
            // 
            textid.Location = new Point(133, 79);
            textid.Name = "textid";
            textid.Size = new Size(151, 27);
            textid.TabIndex = 16;
            // 
            // textlast
            // 
            textlast.Location = new Point(133, 231);
            textlast.Name = "textlast";
            textlast.Size = new Size(151, 27);
            textlast.TabIndex = 17;
            textlast.TextChanged += textwaterbill_TextChanged;
            // 
            // txbphone
            // 
            txbphone.Location = new Point(133, 283);
            txbphone.Name = "txbphone";
            txbphone.Size = new Size(151, 27);
            txbphone.TabIndex = 18;
            txbphone.TextChanged += txbphone_TextChanged;
            // 
            // ccbtype
            // 
            ccbtype.FormattingEnabled = true;
            ccbtype.Items.AddRange(new object[] { "house hold", "Administrative agency, public services", "Production units", "else" });
            ccbtype.Location = new Point(133, 134);
            ccbtype.Name = "ccbtype";
            ccbtype.Size = new Size(151, 28);
            ccbtype.TabIndex = 19;
            ccbtype.SelectedIndexChanged += ccbtype_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 25);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 20;
            label7.Text = "search";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(474, 22);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(233, 27);
            txtsearch.TabIndex = 21;
            txtsearch.TextChanged += textBox1_TextChanged;
            // 
            // button7
            // 
            button7.Location = new Point(474, 70);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 22;
            button7.Text = "search";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_2;
            // 
            // txtbill
            // 
            txtbill.Location = new Point(474, 159);
            txtbill.Name = "txtbill";
            txtbill.Size = new Size(125, 27);
            txtbill.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 163);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 24;
            label8.Text = "bill";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 807);
            Controls.Add(label8);
            Controls.Add(txtbill);
            Controls.Add(button7);
            Controls.Add(txtsearch);
            Controls.Add(label7);
            Controls.Add(ccbtype);
            Controls.Add(txbphone);
            Controls.Add(textlast);
            Controls.Add(textid);
            Controls.Add(txbname);
            Controls.Add(texthis);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox texthis;
        private TextBox txbname;
        private TextBox textid;
        private TextBox textlast;
        private TextBox txbphone;
        private ComboBox ccbtype;
        private DataGridViewTextBoxColumn ghjk;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn typecustomer;
        private DataGridViewTextBoxColumn thismonth;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn clmtt;
        private Label label7;
        private TextBox txtsearch;
        private Button button7;
        private TextBox txtbill;
        private Label label8;
    }
}
