
namespace DatabaseFirst
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrderByDesc = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(7, 19);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(87, 43);
            this.btnToList.TabIndex = 1;
            this.btnToList.Text = "ToList";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(379, 19);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(87, 43);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(100, 19);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(87, 43);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderByDesc
            // 
            this.btnOrderByDesc.Location = new System.Drawing.Point(193, 19);
            this.btnOrderByDesc.Name = "btnOrderByDesc";
            this.btnOrderByDesc.Size = new System.Drawing.Size(87, 43);
            this.btnOrderByDesc.TabIndex = 2;
            this.btnOrderByDesc.Text = "Order By Descending";
            this.btnOrderByDesc.UseVisualStyleBackColor = true;
            this.btnOrderByDesc.Click += new System.EventHandler(this.btnOrderByDesc_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(286, 19);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(87, 43);
            this.btnOrderBy.TabIndex = 2;
            this.btnOrderBy.Text = "Order By";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(379, 19);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(87, 43);
            this.btnGroupBy.TabIndex = 2;
            this.btnGroupBy.Text = "GroupBy";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(472, 19);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(87, 43);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(565, 19);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(87, 43);
            this.btnFirstOrDefault.TabIndex = 2;
            this.btnFirstOrDefault.Text = "First or Default";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(379, 78);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 43);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(472, 78);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(87, 43);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(7, 78);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(87, 43);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(100, 78);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(87, 43);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contain";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(193, 78);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(87, 43);
            this.btnStartWith.TabIndex = 2;
            this.btnStartWith.Text = "Start With";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(286, 78);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(87, 43);
            this.btnEndWith.TabIndex = 2;
            this.btnEndWith.Text = "End With";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(565, 78);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(87, 43);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToList);
            this.groupBox1.Controls.Add(this.btnWhere);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnOrderByDesc);
            this.groupBox1.Controls.Add(this.btnEndWith);
            this.groupBox1.Controls.Add(this.btnOrderBy);
            this.groupBox1.Controls.Add(this.btnStartWith);
            this.groupBox1.Controls.Add(this.btnGroupBy);
            this.groupBox1.Controls.Add(this.btnContains);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnSkip);
            this.groupBox1.Controls.Add(this.btnFirstOrDefault);
            this.groupBox1.Controls.Add(this.btnTake);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linq to Methods";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSum);
            this.groupBox2.Controls.Add(this.btnCount);
            this.groupBox2.Controls.Add(this.btnAverage);
            this.groupBox2.Controls.Add(this.btnMax);
            this.groupBox2.Controls.Add(this.btnMin);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 76);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggregate Functions";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(100, 19);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(87, 43);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(7, 19);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(87, 43);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(193, 19);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(87, 43);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(286, 19);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(87, 43);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderByDesc;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
    }
}

