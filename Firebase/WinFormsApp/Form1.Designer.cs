
namespace WinFormsApp
{
    partial class Pokemon_
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
            this.Pokemon = new System.Windows.Forms.GroupBox();
            this.PokemonGirdView = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.KeywordLb = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.GroupBox();
            this.TypeTb = new System.Windows.Forms.TextBox();
            this.Typelb = new System.Windows.Forms.Label();
            this.WeightTb = new System.Windows.Forms.NumericUpDown();
            this.Weightlb = new System.Windows.Forms.Label();
            this.HeightTb = new System.Windows.Forms.NumericUpDown();
            this.Heightlb = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.Namelb = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.IDlb = new System.Windows.Forms.Label();
            this.Pokemon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonGirdView)).BeginInit();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTb)).BeginInit();
            this.SuspendLayout();
            // 
            // Pokemon
            // 
            this.Pokemon.Controls.Add(this.PokemonGirdView);
            this.Pokemon.Controls.Add(this.SearchBtn);
            this.Pokemon.Controls.Add(this.searchBox);
            this.Pokemon.Controls.Add(this.KeywordLb);
            this.Pokemon.Location = new System.Drawing.Point(31, 37);
            this.Pokemon.Name = "Pokemon";
            this.Pokemon.Size = new System.Drawing.Size(802, 445);
            this.Pokemon.TabIndex = 0;
            this.Pokemon.TabStop = false;
            this.Pokemon.Text = "Pokemon";
            // 
            // PokemonGirdView
            // 
            this.PokemonGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokemonGirdView.Location = new System.Drawing.Point(44, 135);
            this.PokemonGirdView.Name = "PokemonGirdView";
            this.PokemonGirdView.RowHeadersWidth = 62;
            this.PokemonGirdView.RowTemplate.Height = 33;
            this.PokemonGirdView.Size = new System.Drawing.Size(729, 279);
            this.PokemonGirdView.TabIndex = 4;
            this.PokemonGirdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PokemonGirdView_CellClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(645, 45);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(128, 39);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(184, 45);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(421, 39);
            this.searchBox.TabIndex = 2;
            // 
            // KeywordLb
            // 
            this.KeywordLb.AutoSize = true;
            this.KeywordLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeywordLb.Location = new System.Drawing.Point(44, 45);
            this.KeywordLb.Name = "KeywordLb";
            this.KeywordLb.Size = new System.Drawing.Size(106, 32);
            this.KeywordLb.TabIndex = 1;
            this.KeywordLb.Text = "Keyword";
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.TypeTb);
            this.ControlBox.Controls.Add(this.Typelb);
            this.ControlBox.Controls.Add(this.WeightTb);
            this.ControlBox.Controls.Add(this.Weightlb);
            this.ControlBox.Controls.Add(this.HeightTb);
            this.ControlBox.Controls.Add(this.Heightlb);
            this.ControlBox.Controls.Add(this.DeleteBtn);
            this.ControlBox.Controls.Add(this.UpdateBtn);
            this.ControlBox.Controls.Add(this.NameTb);
            this.ControlBox.Controls.Add(this.Namelb);
            this.ControlBox.Controls.Add(this.Addbtn);
            this.ControlBox.Controls.Add(this.IDTb);
            this.ControlBox.Controls.Add(this.IDlb);
            this.ControlBox.Location = new System.Drawing.Point(31, 499);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(802, 341);
            this.ControlBox.TabIndex = 5;
            this.ControlBox.TabStop = false;
            this.ControlBox.Text = "Control";
            // 
            // TypeTb
            // 
            this.TypeTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeTb.Location = new System.Drawing.Point(152, 281);
            this.TypeTb.Name = "TypeTb";
            this.TypeTb.Size = new System.Drawing.Size(421, 39);
            this.TypeTb.TabIndex = 17;
            // 
            // Typelb
            // 
            this.Typelb.AutoSize = true;
            this.Typelb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Typelb.Location = new System.Drawing.Point(44, 281);
            this.Typelb.Name = "Typelb";
            this.Typelb.Size = new System.Drawing.Size(65, 32);
            this.Typelb.TabIndex = 16;
            this.Typelb.Text = "Type";
            // 
            // WeightTb
            // 
            this.WeightTb.DecimalPlaces = 4;
            this.WeightTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightTb.Location = new System.Drawing.Point(152, 230);
            this.WeightTb.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.WeightTb.Name = "WeightTb";
            this.WeightTb.Size = new System.Drawing.Size(421, 39);
            this.WeightTb.TabIndex = 15;
            // 
            // Weightlb
            // 
            this.Weightlb.AutoSize = true;
            this.Weightlb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Weightlb.Location = new System.Drawing.Point(44, 230);
            this.Weightlb.Name = "Weightlb";
            this.Weightlb.Size = new System.Drawing.Size(90, 32);
            this.Weightlb.TabIndex = 14;
            this.Weightlb.Text = "Weight";
            // 
            // HeightTb
            // 
            this.HeightTb.DecimalPlaces = 4;
            this.HeightTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightTb.Location = new System.Drawing.Point(152, 171);
            this.HeightTb.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HeightTb.Name = "HeightTb";
            this.HeightTb.Size = new System.Drawing.Size(421, 39);
            this.HeightTb.TabIndex = 13;
            // 
            // Heightlb
            // 
            this.Heightlb.AutoSize = true;
            this.Heightlb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Heightlb.Location = new System.Drawing.Point(44, 167);
            this.Heightlb.Name = "Heightlb";
            this.Heightlb.Size = new System.Drawing.Size(86, 32);
            this.Heightlb.TabIndex = 12;
            this.Heightlb.Text = "Height";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(645, 223);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 50);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(645, 149);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 50);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTb.Location = new System.Drawing.Point(152, 114);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(421, 39);
            this.NameTb.TabIndex = 9;
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Namelb.Location = new System.Drawing.Point(44, 114);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(78, 32);
            this.Namelb.TabIndex = 8;
            this.Namelb.Text = "Name";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.Location = new System.Drawing.Point(645, 82);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(130, 50);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // IDTb
            // 
            this.IDTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDTb.Location = new System.Drawing.Point(152, 61);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(421, 39);
            this.IDTb.TabIndex = 6;
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDlb.Location = new System.Drawing.Point(44, 61);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(37, 32);
            this.IDlb.TabIndex = 5;
            this.IDlb.Text = "ID";
            // 
            // Pokemon_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 852);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.Pokemon);
            this.Name = "Pokemon_";
            this.Text = "Pokemon";
            this.Pokemon.ResumeLayout(false);
            this.Pokemon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonGirdView)).EndInit();
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pokemon;
        private System.Windows.Forms.Label KeywordLb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView PokemonGirdView;
        private new System.Windows.Forms.GroupBox ControlBox;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label Heightlb;
        private System.Windows.Forms.NumericUpDown HeightTb;
        private System.Windows.Forms.TextBox TypeTb;
        private System.Windows.Forms.Label Typelb;
        private System.Windows.Forms.NumericUpDown WeightTb;
        private System.Windows.Forms.Label Weightlb;
    }

}

