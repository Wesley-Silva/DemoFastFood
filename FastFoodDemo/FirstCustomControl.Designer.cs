namespace FastFoodDemo
{
    partial class FirstCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbItens = new System.Windows.Forms.ComboBox();
            this.rbLanche = new System.Windows.Forms.RadioButton();
            this.rbFritas = new System.Windows.Forms.RadioButton();
            this.rbFrango = new System.Windows.Forms.RadioButton();
            this.rbBebidas = new System.Windows.Forms.RadioButton();
            this.rbSobremesa = new System.Windows.Forms.RadioButton();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(70, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(509, 134);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(254, 29);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Adicionar Item";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // cbItens
            // 
            this.cbItens.FormattingEnabled = true;
            this.cbItens.Location = new System.Drawing.Point(509, 38);
            this.cbItens.Name = "cbItens";
            this.cbItens.Size = new System.Drawing.Size(254, 21);
            this.cbItens.TabIndex = 3;
            // 
            // rbLanche
            // 
            this.rbLanche.AutoSize = true;
            this.rbLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLanche.Location = new System.Drawing.Point(6, 22);
            this.rbLanche.Name = "rbLanche";
            this.rbLanche.Size = new System.Drawing.Size(84, 20);
            this.rbLanche.TabIndex = 4;
            this.rbLanche.TabStop = true;
            this.rbLanche.Text = "Lanches";
            this.rbLanche.UseVisualStyleBackColor = true;
            this.rbLanche.CheckedChanged += new System.EventHandler(this.RbLanche_CheckedChanged);
            // 
            // rbFritas
            // 
            this.rbFritas.AutoSize = true;
            this.rbFritas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFritas.Location = new System.Drawing.Point(160, 19);
            this.rbFritas.Name = "rbFritas";
            this.rbFritas.Size = new System.Drawing.Size(65, 20);
            this.rbFritas.TabIndex = 5;
            this.rbFritas.TabStop = true;
            this.rbFritas.Text = "Fritas";
            this.rbFritas.UseVisualStyleBackColor = true;
            this.rbFritas.CheckedChanged += new System.EventHandler(this.RbFritas_CheckedChanged);
            // 
            // rbFrango
            // 
            this.rbFrango.AutoSize = true;
            this.rbFrango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFrango.Location = new System.Drawing.Point(161, 60);
            this.rbFrango.Name = "rbFrango";
            this.rbFrango.Size = new System.Drawing.Size(75, 20);
            this.rbFrango.TabIndex = 6;
            this.rbFrango.TabStop = true;
            this.rbFrango.Text = "Frango";
            this.rbFrango.UseVisualStyleBackColor = true;
            // 
            // rbBebidas
            // 
            this.rbBebidas.AutoSize = true;
            this.rbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBebidas.Location = new System.Drawing.Point(6, 60);
            this.rbBebidas.Name = "rbBebidas";
            this.rbBebidas.Size = new System.Drawing.Size(84, 20);
            this.rbBebidas.TabIndex = 7;
            this.rbBebidas.TabStop = true;
            this.rbBebidas.Text = "Bebidas";
            this.rbBebidas.UseVisualStyleBackColor = true;
            this.rbBebidas.CheckedChanged += new System.EventHandler(this.RbBebidas_CheckedChanged);
            // 
            // rbSobremesa
            // 
            this.rbSobremesa.AutoSize = true;
            this.rbSobremesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSobremesa.Location = new System.Drawing.Point(295, 19);
            this.rbSobremesa.Name = "rbSobremesa";
            this.rbSobremesa.Size = new System.Drawing.Size(106, 20);
            this.rbSobremesa.TabIndex = 8;
            this.rbSobremesa.TabStop = true;
            this.rbSobremesa.Text = "Sobremesa";
            this.rbSobremesa.UseVisualStyleBackColor = true;
            this.rbSobremesa.CheckedChanged += new System.EventHandler(this.RbSobremesa_CheckedChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(74, 143);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(126, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(221, 143);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(126, 20);
            this.txtQtde.TabIndex = 9;
            this.txtQtde.Text = "0";
            this.txtQtde.TextChanged += new System.EventHandler(this.TxtQtde_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(368, 143);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.ForeColor = System.Drawing.Color.White;
            this.btRemover.Location = new System.Drawing.Point(509, 185);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(254, 29);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover Item";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 220);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(697, 173);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preço";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Horario";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 100;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(66, 433);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(126, 20);
            this.txtSubTotal.TabIndex = 12;
            this.txtSubTotal.Text = "0";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(637, 433);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(126, 20);
            this.txtValorTotal.TabIndex = 12;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(637, 476);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(126, 20);
            this.txtPagamento.TabIndex = 12;
            this.txtPagamento.TextChanged += new System.EventHandler(this.TxtPagamento_TextChanged);
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(637, 522);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(126, 20);
            this.txtTroco.TabIndex = 12;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(235, 433);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(126, 20);
            this.txtDesconto.TabIndex = 12;
            this.txtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label15.Location = new System.Drawing.Point(217, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Quantidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label16.Location = new System.Drawing.Point(364, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label17.Location = new System.Drawing.Point(62, 410);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sub-Total";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label18.Location = new System.Drawing.Point(231, 410);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Desconto";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label19.Location = new System.Drawing.Point(400, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Voucher";
            // 
            // txtVoucher
            // 
            this.txtVoucher.Location = new System.Drawing.Point(404, 433);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(126, 20);
            this.txtVoucher.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(633, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor-Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(633, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(633, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Troco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(505, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecione o item da categoria";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(368, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPizza.Location = new System.Drawing.Point(295, 60);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(63, 20);
            this.rbPizza.TabIndex = 8;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.RbPizza_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLanche);
            this.groupBox1.Controls.Add(this.rbBebidas);
            this.groupBox1.Controls.Add(this.rbFritas);
            this.groupBox1.Controls.Add(this.rbFrango);
            this.groupBox1.Controls.Add(this.rbSobremesa);
            this.groupBox1.Controls.Add(this.rbPizza);
            this.groupBox1.Location = new System.Drawing.Point(74, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 90);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma categoria";
            // 
            // FirstCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtVoucher);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.cbItens);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Name = "FirstCustomControl";
            this.Size = new System.Drawing.Size(817, 581);
            this.Load += new System.EventHandler(this.FirstCustomControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbItens;
        private System.Windows.Forms.RadioButton rbLanche;
        private System.Windows.Forms.RadioButton rbFritas;
        private System.Windows.Forms.RadioButton rbFrango;
        private System.Windows.Forms.RadioButton rbBebidas;
        private System.Windows.Forms.RadioButton rbSobremesa;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
