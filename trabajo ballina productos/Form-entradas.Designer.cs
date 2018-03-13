namespace trabajo_ballina_productos
{
    partial class Form_entradas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_entradas));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nu_productoLabel;
            System.Windows.Forms.Label nu_ubicacionLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label facturaLabel;
            System.Windows.Forms.Label fecha_facturaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label condicionLabel;
            this.postgresDataSet = new trabajo_ballina_productos.postgresDataSet();
            this.entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradasTableAdapter = new trabajo_ballina_productos.postgresDataSetTableAdapters.entradasTableAdapter();
            this.tableAdapterManager = new trabajo_ballina_productos.postgresDataSetTableAdapters.TableAdapterManager();
            this.entradasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.entradasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nu_productoTextBox = new System.Windows.Forms.TextBox();
            this.nu_ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.facturaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_facturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.condicionTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nu_productoLabel = new System.Windows.Forms.Label();
            nu_ubicacionLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            facturaLabel = new System.Windows.Forms.Label();
            fecha_facturaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            condicionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingNavigator)).BeginInit();
            this.entradasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradasBindingSource
            // 
            this.entradasBindingSource.DataMember = "entradas";
            this.entradasBindingSource.DataSource = this.postgresDataSet;
            // 
            // entradasTableAdapter
            // 
            this.entradasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.entradasTableAdapter = this.entradasTableAdapter;
            this.tableAdapterManager.inventariosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.ubicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabajo_ballina_productos.postgresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // entradasBindingNavigator
            // 
            this.entradasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.entradasBindingNavigator.BindingSource = this.entradasBindingSource;
            this.entradasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entradasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.entradasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.entradasBindingNavigatorSaveItem});
            this.entradasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entradasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entradasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entradasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entradasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entradasBindingNavigator.Name = "entradasBindingNavigator";
            this.entradasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entradasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.entradasBindingNavigator.TabIndex = 0;
            this.entradasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // entradasBindingNavigatorSaveItem
            // 
            this.entradasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entradasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entradasBindingNavigatorSaveItem.Image")));
            this.entradasBindingNavigatorSaveItem.Name = "entradasBindingNavigatorSaveItem";
            this.entradasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.entradasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.entradasBindingNavigatorSaveItem.Click += new System.EventHandler(this.entradasBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(57, 72);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(136, 69);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nu_productoLabel
            // 
            nu_productoLabel.AutoSize = true;
            nu_productoLabel.Location = new System.Drawing.Point(57, 98);
            nu_productoLabel.Name = "nu_productoLabel";
            nu_productoLabel.Size = new System.Drawing.Size(67, 13);
            nu_productoLabel.TabIndex = 3;
            nu_productoLabel.Text = "nu producto:";
            // 
            // nu_productoTextBox
            // 
            this.nu_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "nu_producto", true));
            this.nu_productoTextBox.Location = new System.Drawing.Point(136, 95);
            this.nu_productoTextBox.Name = "nu_productoTextBox";
            this.nu_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nu_productoTextBox.TabIndex = 4;
            // 
            // nu_ubicacionLabel
            // 
            nu_ubicacionLabel.AutoSize = true;
            nu_ubicacionLabel.Location = new System.Drawing.Point(57, 124);
            nu_ubicacionLabel.Name = "nu_ubicacionLabel";
            nu_ubicacionLabel.Size = new System.Drawing.Size(71, 13);
            nu_ubicacionLabel.TabIndex = 5;
            nu_ubicacionLabel.Text = "nu ubicacion:";
            // 
            // nu_ubicacionTextBox
            // 
            this.nu_ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "nu_ubicacion", true));
            this.nu_ubicacionTextBox.Location = new System.Drawing.Point(136, 121);
            this.nu_ubicacionTextBox.Name = "nu_ubicacionTextBox";
            this.nu_ubicacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.nu_ubicacionTextBox.TabIndex = 6;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(57, 150);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(51, 13);
            cantidadLabel.TabIndex = 7;
            cantidadLabel.Text = "cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(136, 147);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(200, 20);
            this.cantidadTextBox.TabIndex = 8;
            // 
            // facturaLabel
            // 
            facturaLabel.AutoSize = true;
            facturaLabel.Location = new System.Drawing.Point(57, 176);
            facturaLabel.Name = "facturaLabel";
            facturaLabel.Size = new System.Drawing.Size(43, 13);
            facturaLabel.TabIndex = 9;
            facturaLabel.Text = "factura:";
            // 
            // facturaTextBox
            // 
            this.facturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "factura", true));
            this.facturaTextBox.Location = new System.Drawing.Point(136, 173);
            this.facturaTextBox.Name = "facturaTextBox";
            this.facturaTextBox.Size = new System.Drawing.Size(200, 20);
            this.facturaTextBox.TabIndex = 10;
            // 
            // fecha_facturaLabel
            // 
            fecha_facturaLabel.AutoSize = true;
            fecha_facturaLabel.Location = new System.Drawing.Point(57, 203);
            fecha_facturaLabel.Name = "fecha_facturaLabel";
            fecha_facturaLabel.Size = new System.Drawing.Size(73, 13);
            fecha_facturaLabel.TabIndex = 11;
            fecha_facturaLabel.Text = "fecha factura:";
            // 
            // fecha_facturaDateTimePicker
            // 
            this.fecha_facturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entradasBindingSource, "fecha_factura", true));
            this.fecha_facturaDateTimePicker.Location = new System.Drawing.Point(136, 199);
            this.fecha_facturaDateTimePicker.Name = "fecha_facturaDateTimePicker";
            this.fecha_facturaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_facturaDateTimePicker.TabIndex = 12;
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(57, 228);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(39, 13);
            montoLabel.TabIndex = 13;
            montoLabel.Text = "monto:";
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "monto", true));
            this.montoTextBox.Location = new System.Drawing.Point(136, 225);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoTextBox.TabIndex = 14;
            // 
            // condicionLabel
            // 
            condicionLabel.AutoSize = true;
            condicionLabel.Location = new System.Drawing.Point(57, 254);
            condicionLabel.Name = "condicionLabel";
            condicionLabel.Size = new System.Drawing.Size(56, 13);
            condicionLabel.TabIndex = 15;
            condicionLabel.Text = "condicion:";
            // 
            // condicionTextBox
            // 
            this.condicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradasBindingSource, "condicion", true));
            this.condicionTextBox.Location = new System.Drawing.Point(136, 251);
            this.condicionTextBox.Name = "condicionTextBox";
            this.condicionTextBox.Size = new System.Drawing.Size(200, 20);
            this.condicionTextBox.TabIndex = 16;
            // 
            // Form_entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nu_productoLabel);
            this.Controls.Add(this.nu_productoTextBox);
            this.Controls.Add(nu_ubicacionLabel);
            this.Controls.Add(this.nu_ubicacionTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(facturaLabel);
            this.Controls.Add(this.facturaTextBox);
            this.Controls.Add(fecha_facturaLabel);
            this.Controls.Add(this.fecha_facturaDateTimePicker);
            this.Controls.Add(montoLabel);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(condicionLabel);
            this.Controls.Add(this.condicionTextBox);
            this.Controls.Add(this.entradasBindingNavigator);
            this.Name = "Form_entradas";
            this.Text = "Form_entradas";
            this.Load += new System.EventHandler(this.Form_entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingNavigator)).EndInit();
            this.entradasBindingNavigator.ResumeLayout(false);
            this.entradasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource entradasBindingSource;
        private postgresDataSetTableAdapters.entradasTableAdapter entradasTableAdapter;
        private postgresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entradasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton entradasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nu_productoTextBox;
        private System.Windows.Forms.TextBox nu_ubicacionTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox facturaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_facturaDateTimePicker;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.TextBox condicionTextBox;
    }
}