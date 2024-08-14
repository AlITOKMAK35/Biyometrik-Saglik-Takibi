namespace process_işleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trombositprgbar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.trombositgrpbox = new System.Windows.Forms.GroupBox();
            this.diyabetgrpbox = new System.Windows.Forms.GroupBox();
            this.diyabetprgbar = new System.Windows.Forms.ProgressBar();
            this.şekergrpbox = new System.Windows.Forms.GroupBox();
            this.şekerprgbar = new System.Windows.Forms.ProgressBar();
            this.alyuvargrpbox = new System.Windows.Forms.GroupBox();
            this.alyuvarprgbar = new System.Windows.Forms.ProgressBar();
            this.trombositsonlbl = new System.Windows.Forms.Label();
            this.tansiyongrpbox = new System.Windows.Forms.GroupBox();
            this.tansiyonprgbar = new System.Windows.Forms.ProgressBar();
            this.trombosittxt = new System.Windows.Forms.TextBox();
            this.diyabettxt = new System.Windows.Forms.TextBox();
            this.şekertxt = new System.Windows.Forms.TextBox();
            this.alyuvartxt = new System.Windows.Forms.TextBox();
            this.tansiyontxt = new System.Windows.Forms.TextBox();
            this.diyabetsonlbl = new System.Windows.Forms.Label();
            this.şekersonlbl = new System.Windows.Forms.Label();
            this.alyuvarsonlbl = new System.Windows.Forms.Label();
            this.tansiyonsonlbl = new System.Windows.Forms.Label();
            this.trombositlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.processDataSet1 = new process_işleme.processDataSet1();
            this.processDataSet = new process_işleme.processDataSet();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.tctxt = new System.Windows.Forms.TextBox();
            this.bölümtxt = new System.Windows.Forms.TextBox();
            this.telefontxt = new System.Windows.Forms.TextBox();
            this.diyabetlbl = new System.Windows.Forms.Label();
            this.şekerlbl = new System.Windows.Forms.Label();
            this.alyuvarlbl = new System.Windows.Forms.Label();
            this.tansiyonlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuc2txt = new System.Windows.Forms.Label();
            this.postDataSet = new process_işleme.postDataSet();
            this.posttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.post_tableTableAdapter = new process_işleme.postDataSetTableAdapters.post_tableTableAdapter();
            this.processDataSet2 = new process_işleme.processDataSet2();
            this.proBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proTableAdapter = new process_işleme.processDataSet2TableAdapters.proTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trombositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diyabetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alyuvarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tansiyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trombositgrpbox.SuspendLayout();
            this.diyabetgrpbox.SuspendLayout();
            this.şekergrpbox.SuspendLayout();
            this.alyuvargrpbox.SuspendLayout();
            this.tansiyongrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trombositprgbar
            // 
            this.trombositprgbar.Location = new System.Drawing.Point(6, 40);
            this.trombositprgbar.MarqueeAnimationSpeed = 50;
            this.trombositprgbar.Name = "trombositprgbar";
            this.trombositprgbar.Size = new System.Drawing.Size(107, 27);
            this.trombositprgbar.Step = 25;
            this.trombositprgbar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trombositgrpbox
            // 
            this.trombositgrpbox.Controls.Add(this.trombositprgbar);
            this.trombositgrpbox.Location = new System.Drawing.Point(24, 148);
            this.trombositgrpbox.Name = "trombositgrpbox";
            this.trombositgrpbox.Size = new System.Drawing.Size(135, 103);
            this.trombositgrpbox.TabIndex = 9;
            this.trombositgrpbox.TabStop = false;
            this.trombositgrpbox.Text = "Trombosit";
            // 
            // diyabetgrpbox
            // 
            this.diyabetgrpbox.Controls.Add(this.diyabetprgbar);
            this.diyabetgrpbox.Location = new System.Drawing.Point(165, 148);
            this.diyabetgrpbox.Name = "diyabetgrpbox";
            this.diyabetgrpbox.Size = new System.Drawing.Size(135, 103);
            this.diyabetgrpbox.TabIndex = 10;
            this.diyabetgrpbox.TabStop = false;
            this.diyabetgrpbox.Text = "Diyabet";
            // 
            // diyabetprgbar
            // 
            this.diyabetprgbar.Location = new System.Drawing.Point(6, 40);
            this.diyabetprgbar.Name = "diyabetprgbar";
            this.diyabetprgbar.Size = new System.Drawing.Size(107, 27);
            this.diyabetprgbar.TabIndex = 12;
            // 
            // şekergrpbox
            // 
            this.şekergrpbox.Controls.Add(this.şekerprgbar);
            this.şekergrpbox.Location = new System.Drawing.Point(317, 148);
            this.şekergrpbox.Name = "şekergrpbox";
            this.şekergrpbox.Size = new System.Drawing.Size(135, 103);
            this.şekergrpbox.TabIndex = 10;
            this.şekergrpbox.TabStop = false;
            this.şekergrpbox.Text = "Şeker";
            // 
            // şekerprgbar
            // 
            this.şekerprgbar.Location = new System.Drawing.Point(6, 40);
            this.şekerprgbar.Name = "şekerprgbar";
            this.şekerprgbar.Size = new System.Drawing.Size(107, 27);
            this.şekerprgbar.TabIndex = 13;
            // 
            // alyuvargrpbox
            // 
            this.alyuvargrpbox.Controls.Add(this.alyuvarprgbar);
            this.alyuvargrpbox.Location = new System.Drawing.Point(470, 148);
            this.alyuvargrpbox.Name = "alyuvargrpbox";
            this.alyuvargrpbox.Size = new System.Drawing.Size(135, 103);
            this.alyuvargrpbox.TabIndex = 11;
            this.alyuvargrpbox.TabStop = false;
            this.alyuvargrpbox.Text = "Alyuvar";
            // 
            // alyuvarprgbar
            // 
            this.alyuvarprgbar.Location = new System.Drawing.Point(6, 40);
            this.alyuvarprgbar.Name = "alyuvarprgbar";
            this.alyuvarprgbar.Size = new System.Drawing.Size(107, 27);
            this.alyuvarprgbar.TabIndex = 14;
            // 
            // trombositsonlbl
            // 
            this.trombositsonlbl.AutoSize = true;
            this.trombositsonlbl.Location = new System.Drawing.Point(53, 275);
            this.trombositsonlbl.Name = "trombositsonlbl";
            this.trombositsonlbl.Size = new System.Drawing.Size(70, 22);
            this.trombositsonlbl.TabIndex = 12;
            this.trombositsonlbl.Text = "Sonuç";
            // 
            // tansiyongrpbox
            // 
            this.tansiyongrpbox.Controls.Add(this.tansiyonprgbar);
            this.tansiyongrpbox.Location = new System.Drawing.Point(637, 148);
            this.tansiyongrpbox.Name = "tansiyongrpbox";
            this.tansiyongrpbox.Size = new System.Drawing.Size(135, 103);
            this.tansiyongrpbox.TabIndex = 10;
            this.tansiyongrpbox.TabStop = false;
            this.tansiyongrpbox.Text = "Tansiyon";
            // 
            // tansiyonprgbar
            // 
            this.tansiyonprgbar.Location = new System.Drawing.Point(6, 40);
            this.tansiyonprgbar.Name = "tansiyonprgbar";
            this.tansiyonprgbar.Size = new System.Drawing.Size(107, 27);
            this.tansiyonprgbar.TabIndex = 15;
            // 
            // trombosittxt
            // 
            this.trombosittxt.Location = new System.Drawing.Point(44, 72);
            this.trombosittxt.Name = "trombosittxt";
            this.trombosittxt.Size = new System.Drawing.Size(100, 29);
            this.trombosittxt.TabIndex = 6;
            this.trombosittxt.Text = "Değer";
            // 
            // diyabettxt
            // 
            this.diyabettxt.Location = new System.Drawing.Point(178, 72);
            this.diyabettxt.Name = "diyabettxt";
            this.diyabettxt.Size = new System.Drawing.Size(100, 29);
            this.diyabettxt.TabIndex = 7;
            this.diyabettxt.Text = "Değer";
            // 
            // şekertxt
            // 
            this.şekertxt.Location = new System.Drawing.Point(330, 72);
            this.şekertxt.Name = "şekertxt";
            this.şekertxt.Size = new System.Drawing.Size(100, 29);
            this.şekertxt.TabIndex = 8;
            this.şekertxt.Text = "Değer";
            // 
            // alyuvartxt
            // 
            this.alyuvartxt.Location = new System.Drawing.Point(477, 72);
            this.alyuvartxt.Name = "alyuvartxt";
            this.alyuvartxt.Size = new System.Drawing.Size(100, 29);
            this.alyuvartxt.TabIndex = 9;
            this.alyuvartxt.Text = "Değer";
            // 
            // tansiyontxt
            // 
            this.tansiyontxt.Location = new System.Drawing.Point(650, 72);
            this.tansiyontxt.Name = "tansiyontxt";
            this.tansiyontxt.Size = new System.Drawing.Size(100, 29);
            this.tansiyontxt.TabIndex = 10;
            this.tansiyontxt.Text = "Değer";
            // 
            // diyabetsonlbl
            // 
            this.diyabetsonlbl.AutoSize = true;
            this.diyabetsonlbl.Location = new System.Drawing.Point(197, 275);
            this.diyabetsonlbl.Name = "diyabetsonlbl";
            this.diyabetsonlbl.Size = new System.Drawing.Size(70, 22);
            this.diyabetsonlbl.TabIndex = 18;
            this.diyabetsonlbl.Text = "Sonuç";
            // 
            // şekersonlbl
            // 
            this.şekersonlbl.AutoSize = true;
            this.şekersonlbl.Location = new System.Drawing.Point(347, 275);
            this.şekersonlbl.Name = "şekersonlbl";
            this.şekersonlbl.Size = new System.Drawing.Size(70, 22);
            this.şekersonlbl.TabIndex = 19;
            this.şekersonlbl.Text = "Sonuç";
            // 
            // alyuvarsonlbl
            // 
            this.alyuvarsonlbl.AutoSize = true;
            this.alyuvarsonlbl.Location = new System.Drawing.Point(493, 275);
            this.alyuvarsonlbl.Name = "alyuvarsonlbl";
            this.alyuvarsonlbl.Size = new System.Drawing.Size(70, 22);
            this.alyuvarsonlbl.TabIndex = 20;
            this.alyuvarsonlbl.Text = "Sonuç";
            // 
            // tansiyonsonlbl
            // 
            this.tansiyonsonlbl.AutoSize = true;
            this.tansiyonsonlbl.Location = new System.Drawing.Point(658, 275);
            this.tansiyonsonlbl.Name = "tansiyonsonlbl";
            this.tansiyonsonlbl.Size = new System.Drawing.Size(70, 22);
            this.tansiyonsonlbl.TabIndex = 21;
            this.tansiyonsonlbl.Text = "Sonuç";
            // 
            // trombositlbl
            // 
            this.trombositlbl.AutoSize = true;
            this.trombositlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trombositlbl.Location = new System.Drawing.Point(33, 114);
            this.trombositlbl.Name = "trombositlbl";
            this.trombositlbl.Size = new System.Drawing.Size(104, 15);
            this.trombositlbl.TabIndex = 22;
            this.trombositlbl.Text = "Trombosit Değeri";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.trombositDataGridViewTextBoxColumn,
            this.diyabetDataGridViewTextBoxColumn,
            this.sekerDataGridViewTextBoxColumn,
            this.alyuvarDataGridViewTextBoxColumn,
            this.tansiyonDataGridViewTextBoxColumn,
            this.sonucDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1136, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // processDataSet1
            // 
            this.processDataSet1.DataSetName = "processDataSet1";
            this.processDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processDataSet
            // 
            this.processDataSet.DataSetName = "processDataSet";
            this.processDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(44, 12);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(100, 29);
            this.adtxt.TabIndex = 1;
            this.adtxt.Text = "Ad";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(178, 12);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(100, 29);
            this.soyadtxt.TabIndex = 2;
            this.soyadtxt.Text = "Soyad";
            // 
            // tctxt
            // 
            this.tctxt.Location = new System.Drawing.Point(330, 12);
            this.tctxt.Name = "tctxt";
            this.tctxt.Size = new System.Drawing.Size(100, 29);
            this.tctxt.TabIndex = 3;
            this.tctxt.Text = "Tc No";
            // 
            // bölümtxt
            // 
            this.bölümtxt.Location = new System.Drawing.Point(477, 12);
            this.bölümtxt.Name = "bölümtxt";
            this.bölümtxt.Size = new System.Drawing.Size(100, 29);
            this.bölümtxt.TabIndex = 4;
            this.bölümtxt.Text = "Bölüm";
            // 
            // telefontxt
            // 
            this.telefontxt.Location = new System.Drawing.Point(650, 12);
            this.telefontxt.Name = "telefontxt";
            this.telefontxt.Size = new System.Drawing.Size(100, 29);
            this.telefontxt.TabIndex = 5;
            this.telefontxt.Text = "Telefon";
            // 
            // diyabetlbl
            // 
            this.diyabetlbl.AutoSize = true;
            this.diyabetlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyabetlbl.Location = new System.Drawing.Point(175, 114);
            this.diyabetlbl.Name = "diyabetlbl";
            this.diyabetlbl.Size = new System.Drawing.Size(89, 15);
            this.diyabetlbl.TabIndex = 33;
            this.diyabetlbl.Text = "Diyabet Değeri";
            // 
            // şekerlbl
            // 
            this.şekerlbl.AutoSize = true;
            this.şekerlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şekerlbl.Location = new System.Drawing.Point(326, 114);
            this.şekerlbl.Name = "şekerlbl";
            this.şekerlbl.Size = new System.Drawing.Size(81, 15);
            this.şekerlbl.TabIndex = 34;
            this.şekerlbl.Text = "Şeker Değeri";
            // 
            // alyuvarlbl
            // 
            this.alyuvarlbl.AutoSize = true;
            this.alyuvarlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alyuvarlbl.Location = new System.Drawing.Point(474, 114);
            this.alyuvarlbl.Name = "alyuvarlbl";
            this.alyuvarlbl.Size = new System.Drawing.Size(89, 15);
            this.alyuvarlbl.TabIndex = 35;
            this.alyuvarlbl.Text = "Alyuvar Değeri";
            // 
            // tansiyonlbl
            // 
            this.tansiyonlbl.AutoSize = true;
            this.tansiyonlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tansiyonlbl.Location = new System.Drawing.Point(647, 114);
            this.tansiyonlbl.Name = "tansiyonlbl";
            this.tansiyonlbl.Size = new System.Drawing.Size(97, 15);
            this.tansiyonlbl.TabIndex = 36;
            this.tansiyonlbl.Text = "Tansiyon Değeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Değer Sonuç :";
            // 
            // sonuc2txt
            // 
            this.sonuc2txt.AutoSize = true;
            this.sonuc2txt.Location = new System.Drawing.Point(716, 317);
            this.sonuc2txt.Name = "sonuc2txt";
            this.sonuc2txt.Size = new System.Drawing.Size(20, 22);
            this.sonuc2txt.TabIndex = 38;
            this.sonuc2txt.Text = "..";
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "postDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posttableBindingSource
            // 
            this.posttableBindingSource.DataMember = "post_table";
            this.posttableBindingSource.DataSource = this.postDataSet;
            // 
            // post_tableTableAdapter
            // 
            this.post_tableTableAdapter.ClearBeforeFill = true;
            // 
            // processDataSet2
            // 
            this.processDataSet2.DataSetName = "processDataSet2";
            this.processDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proBindingSource
            // 
            this.proBindingSource.DataMember = "pro";
            this.proBindingSource.DataSource = this.processDataSet2;
            // 
            // proTableAdapter
            // 
            this.proTableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // trombositDataGridViewTextBoxColumn
            // 
            this.trombositDataGridViewTextBoxColumn.DataPropertyName = "trombosit";
            this.trombositDataGridViewTextBoxColumn.HeaderText = "trombosit";
            this.trombositDataGridViewTextBoxColumn.Name = "trombositDataGridViewTextBoxColumn";
            // 
            // diyabetDataGridViewTextBoxColumn
            // 
            this.diyabetDataGridViewTextBoxColumn.DataPropertyName = "diyabet";
            this.diyabetDataGridViewTextBoxColumn.HeaderText = "diyabet";
            this.diyabetDataGridViewTextBoxColumn.Name = "diyabetDataGridViewTextBoxColumn";
            // 
            // sekerDataGridViewTextBoxColumn
            // 
            this.sekerDataGridViewTextBoxColumn.DataPropertyName = "seker";
            this.sekerDataGridViewTextBoxColumn.HeaderText = "seker";
            this.sekerDataGridViewTextBoxColumn.Name = "sekerDataGridViewTextBoxColumn";
            // 
            // alyuvarDataGridViewTextBoxColumn
            // 
            this.alyuvarDataGridViewTextBoxColumn.DataPropertyName = "alyuvar";
            this.alyuvarDataGridViewTextBoxColumn.HeaderText = "alyuvar";
            this.alyuvarDataGridViewTextBoxColumn.Name = "alyuvarDataGridViewTextBoxColumn";
            // 
            // tansiyonDataGridViewTextBoxColumn
            // 
            this.tansiyonDataGridViewTextBoxColumn.DataPropertyName = "tansiyon";
            this.tansiyonDataGridViewTextBoxColumn.HeaderText = "tansiyon";
            this.tansiyonDataGridViewTextBoxColumn.Name = "tansiyonDataGridViewTextBoxColumn";
            // 
            // sonucDataGridViewTextBoxColumn
            // 
            this.sonucDataGridViewTextBoxColumn.DataPropertyName = "sonuc";
            this.sonucDataGridViewTextBoxColumn.HeaderText = "sonuc";
            this.sonucDataGridViewTextBoxColumn.Name = "sonucDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 609);
            this.Controls.Add(this.sonuc2txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tansiyonlbl);
            this.Controls.Add(this.alyuvarlbl);
            this.Controls.Add(this.şekerlbl);
            this.Controls.Add(this.diyabetlbl);
            this.Controls.Add(this.telefontxt);
            this.Controls.Add(this.bölümtxt);
            this.Controls.Add(this.tctxt);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trombositlbl);
            this.Controls.Add(this.tansiyonsonlbl);
            this.Controls.Add(this.alyuvarsonlbl);
            this.Controls.Add(this.şekersonlbl);
            this.Controls.Add(this.diyabetsonlbl);
            this.Controls.Add(this.tansiyontxt);
            this.Controls.Add(this.alyuvartxt);
            this.Controls.Add(this.şekertxt);
            this.Controls.Add(this.diyabettxt);
            this.Controls.Add(this.trombosittxt);
            this.Controls.Add(this.tansiyongrpbox);
            this.Controls.Add(this.trombositsonlbl);
            this.Controls.Add(this.alyuvargrpbox);
            this.Controls.Add(this.şekergrpbox);
            this.Controls.Add(this.diyabetgrpbox);
            this.Controls.Add(this.trombositgrpbox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trombositgrpbox.ResumeLayout(false);
            this.diyabetgrpbox.ResumeLayout(false);
            this.şekergrpbox.ResumeLayout(false);
            this.alyuvargrpbox.ResumeLayout(false);
            this.tansiyongrpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar trombositprgbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox trombositgrpbox;
        private System.Windows.Forms.GroupBox diyabetgrpbox;
        private System.Windows.Forms.ProgressBar diyabetprgbar;
        private System.Windows.Forms.GroupBox şekergrpbox;
        private System.Windows.Forms.ProgressBar şekerprgbar;
        private System.Windows.Forms.GroupBox alyuvargrpbox;
        private System.Windows.Forms.ProgressBar alyuvarprgbar;
        private System.Windows.Forms.Label trombositsonlbl;
        private System.Windows.Forms.GroupBox tansiyongrpbox;
        private System.Windows.Forms.ProgressBar tansiyonprgbar;
        private System.Windows.Forms.TextBox trombosittxt;
        private System.Windows.Forms.TextBox diyabettxt;
        private System.Windows.Forms.TextBox şekertxt;
        private System.Windows.Forms.TextBox alyuvartxt;
        private System.Windows.Forms.TextBox tansiyontxt;
        private System.Windows.Forms.Label diyabetsonlbl;
        private System.Windows.Forms.Label şekersonlbl;
        private System.Windows.Forms.Label alyuvarsonlbl;
        private System.Windows.Forms.Label tansiyonsonlbl;
        private System.Windows.Forms.Label trombositlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.TextBox tctxt;
        private System.Windows.Forms.TextBox bölümtxt;
        private System.Windows.Forms.TextBox telefontxt;
        private System.Windows.Forms.Label diyabetlbl;
        private System.Windows.Forms.Label şekerlbl;
        private System.Windows.Forms.Label alyuvarlbl;
        private System.Windows.Forms.Label tansiyonlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sonuc2txt;
        private processDataSet processDataSet;
        private postDataSet postDataSet;
        private System.Windows.Forms.BindingSource posttableBindingSource;
        private postDataSetTableAdapters.post_tableTableAdapter post_tableTableAdapter;
        private processDataSet1 processDataSet1;
        private processDataSet2 processDataSet2;
        private System.Windows.Forms.BindingSource proBindingSource;
        private processDataSet2TableAdapters.proTableAdapter proTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trombositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diyabetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alyuvarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tansiyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonucDataGridViewTextBoxColumn;
    }
}

