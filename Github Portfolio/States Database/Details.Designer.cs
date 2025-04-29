namespace AWalker_Lab3
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            System.Windows.Forms.Label stateIDLabel;
            System.Windows.Forms.Label stateNameLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label stateFlagLabel;
            System.Windows.Forms.Label stateFlowerLabel;
            System.Windows.Forms.Label stateBirdLabel;
            System.Windows.Forms.Label stateColorsLabel;
            System.Windows.Forms.Label largestCitiesLabel;
            System.Windows.Forms.Label stateCapitolLabel;
            System.Windows.Forms.Label medianIncomeLabel;
            System.Windows.Forms.Label computerJobsLabel;
            this.uS_StatesDataSet = new AWalker_Lab3.US_StatesDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new AWalker_Lab3.US_StatesDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new AWalker_Lab3.US_StatesDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateIDTextBox = new System.Windows.Forms.TextBox();
            this.stateNameTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.stateFlagTextBox = new System.Windows.Forms.TextBox();
            this.stateFlowerTextBox = new System.Windows.Forms.TextBox();
            this.stateBirdTextBox = new System.Windows.Forms.TextBox();
            this.stateColorsTextBox = new System.Windows.Forms.TextBox();
            this.largestCitiesTextBox = new System.Windows.Forms.TextBox();
            this.stateCapitolTextBox = new System.Windows.Forms.TextBox();
            this.medianIncomeTextBox = new System.Windows.Forms.TextBox();
            this.computerJobsTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            stateIDLabel = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            stateFlagLabel = new System.Windows.Forms.Label();
            stateFlowerLabel = new System.Windows.Forms.Label();
            stateBirdLabel = new System.Windows.Forms.Label();
            stateColorsLabel = new System.Windows.Forms.Label();
            largestCitiesLabel = new System.Windows.Forms.Label();
            stateCapitolLabel = new System.Windows.Forms.Label();
            medianIncomeLabel = new System.Windows.Forms.Label();
            computerJobsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uS_StatesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // uS_StatesDataSet
            // 
            this.uS_StatesDataSet.DataSetName = "US_StatesDataSet";
            this.uS_StatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.uS_StatesDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AWalker_Lab3.US_StatesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(664, 33);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // stateIDLabel
            // 
            stateIDLabel.AutoSize = true;
            stateIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateIDLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateIDLabel.Location = new System.Drawing.Point(56, 80);
            stateIDLabel.Name = "stateIDLabel";
            stateIDLabel.Size = new System.Drawing.Size(88, 25);
            stateIDLabel.TabIndex = 1;
            stateIDLabel.Text = "State ID:";
            stateIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateIDTextBox
            // 
            this.stateIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateID", true));
            this.stateIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateIDTextBox.Location = new System.Drawing.Point(349, 77);
            this.stateIDTextBox.Name = "stateIDTextBox";
            this.stateIDTextBox.Size = new System.Drawing.Size(264, 30);
            this.stateIDTextBox.TabIndex = 2;
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateNameLabel.Location = new System.Drawing.Point(56, 112);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(121, 25);
            stateNameLabel.TabIndex = 3;
            stateNameLabel.Text = "State Name:";
            stateNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Name", true));
            this.stateNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateNameTextBox.Location = new System.Drawing.Point(349, 109);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.Size = new System.Drawing.Size(264, 30);
            this.stateNameTextBox.TabIndex = 4;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            populationLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            populationLabel.Location = new System.Drawing.Point(56, 144);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(193, 25);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population (millions):";
            populationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Population (millions)", true));
            this.populationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationTextBox.Location = new System.Drawing.Point(349, 141);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(264, 30);
            this.populationTextBox.TabIndex = 6;
            // 
            // stateFlagLabel
            // 
            stateFlagLabel.AutoSize = true;
            stateFlagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateFlagLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateFlagLabel.Location = new System.Drawing.Point(56, 176);
            stateFlagLabel.Name = "stateFlagLabel";
            stateFlagLabel.Size = new System.Drawing.Size(107, 25);
            stateFlagLabel.TabIndex = 7;
            stateFlagLabel.Text = "State Flag:";
            stateFlagLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateFlagTextBox
            // 
            this.stateFlagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Flag", true));
            this.stateFlagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateFlagTextBox.Location = new System.Drawing.Point(349, 173);
            this.stateFlagTextBox.Multiline = true;
            this.stateFlagTextBox.Name = "stateFlagTextBox";
            this.stateFlagTextBox.Size = new System.Drawing.Size(264, 102);
            this.stateFlagTextBox.TabIndex = 8;
            // 
            // stateFlowerLabel
            // 
            stateFlowerLabel.AutoSize = true;
            stateFlowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateFlowerLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateFlowerLabel.Location = new System.Drawing.Point(56, 284);
            stateFlowerLabel.Name = "stateFlowerLabel";
            stateFlowerLabel.Size = new System.Drawing.Size(127, 25);
            stateFlowerLabel.TabIndex = 9;
            stateFlowerLabel.Text = "State Flower:";
            stateFlowerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateFlowerTextBox
            // 
            this.stateFlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Flower", true));
            this.stateFlowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateFlowerTextBox.Location = new System.Drawing.Point(349, 281);
            this.stateFlowerTextBox.Name = "stateFlowerTextBox";
            this.stateFlowerTextBox.Size = new System.Drawing.Size(264, 30);
            this.stateFlowerTextBox.TabIndex = 10;
            // 
            // stateBirdLabel
            // 
            stateBirdLabel.AutoSize = true;
            stateBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateBirdLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateBirdLabel.Location = new System.Drawing.Point(56, 316);
            stateBirdLabel.Name = "stateBirdLabel";
            stateBirdLabel.Size = new System.Drawing.Size(103, 25);
            stateBirdLabel.TabIndex = 11;
            stateBirdLabel.Text = "State Bird:";
            stateBirdLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateBirdTextBox
            // 
            this.stateBirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Bird", true));
            this.stateBirdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateBirdTextBox.Location = new System.Drawing.Point(349, 313);
            this.stateBirdTextBox.Name = "stateBirdTextBox";
            this.stateBirdTextBox.Size = new System.Drawing.Size(264, 30);
            this.stateBirdTextBox.TabIndex = 12;
            // 
            // stateColorsLabel
            // 
            stateColorsLabel.AutoSize = true;
            stateColorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateColorsLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateColorsLabel.Location = new System.Drawing.Point(56, 348);
            stateColorsLabel.Name = "stateColorsLabel";
            stateColorsLabel.Size = new System.Drawing.Size(126, 25);
            stateColorsLabel.TabIndex = 13;
            stateColorsLabel.Text = "State Colors:";
            stateColorsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateColorsTextBox
            // 
            this.stateColorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Colors", true));
            this.stateColorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateColorsTextBox.Location = new System.Drawing.Point(349, 345);
            this.stateColorsTextBox.Name = "stateColorsTextBox";
            this.stateColorsTextBox.Size = new System.Drawing.Size(264, 30);
            this.stateColorsTextBox.TabIndex = 14;
            // 
            // largestCitiesLabel
            // 
            largestCitiesLabel.AutoSize = true;
            largestCitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            largestCitiesLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            largestCitiesLabel.Location = new System.Drawing.Point(56, 380);
            largestCitiesLabel.Name = "largestCitiesLabel";
            largestCitiesLabel.Size = new System.Drawing.Size(137, 25);
            largestCitiesLabel.TabIndex = 15;
            largestCitiesLabel.Text = "Largest Cities:";
            largestCitiesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // largestCitiesTextBox
            // 
            this.largestCitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Largest Cities", true));
            this.largestCitiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largestCitiesTextBox.Location = new System.Drawing.Point(349, 377);
            this.largestCitiesTextBox.Multiline = true;
            this.largestCitiesTextBox.Name = "largestCitiesTextBox";
            this.largestCitiesTextBox.Size = new System.Drawing.Size(264, 64);
            this.largestCitiesTextBox.TabIndex = 16;
            // 
            // stateCapitolLabel
            // 
            stateCapitolLabel.AutoSize = true;
            stateCapitolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateCapitolLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            stateCapitolLabel.Location = new System.Drawing.Point(56, 450);
            stateCapitolLabel.Name = "stateCapitolLabel";
            stateCapitolLabel.Size = new System.Drawing.Size(130, 25);
            stateCapitolLabel.TabIndex = 17;
            stateCapitolLabel.Text = "State Capitol:";
            stateCapitolLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateCapitolTextBox
            // 
            this.stateCapitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Capitol", true));
            this.stateCapitolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateCapitolTextBox.Location = new System.Drawing.Point(349, 447);
            this.stateCapitolTextBox.Name = "stateCapitolTextBox";
            this.stateCapitolTextBox.Size = new System.Drawing.Size(264, 30);
            this.stateCapitolTextBox.TabIndex = 18;
            // 
            // medianIncomeLabel
            // 
            medianIncomeLabel.AutoSize = true;
            medianIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medianIncomeLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            medianIncomeLabel.Location = new System.Drawing.Point(56, 482);
            medianIncomeLabel.Name = "medianIncomeLabel";
            medianIncomeLabel.Size = new System.Drawing.Size(152, 25);
            medianIncomeLabel.TabIndex = 19;
            medianIncomeLabel.Text = "Median Income:";
            medianIncomeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // medianIncomeTextBox
            // 
            this.medianIncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Median Income", true));
            this.medianIncomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianIncomeTextBox.Location = new System.Drawing.Point(349, 479);
            this.medianIncomeTextBox.Name = "medianIncomeTextBox";
            this.medianIncomeTextBox.Size = new System.Drawing.Size(264, 30);
            this.medianIncomeTextBox.TabIndex = 20;
            // 
            // computerJobsLabel
            // 
            computerJobsLabel.AutoSize = true;
            computerJobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            computerJobsLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            computerJobsLabel.Location = new System.Drawing.Point(56, 514);
            computerJobsLabel.Name = "computerJobsLabel";
            computerJobsLabel.Size = new System.Drawing.Size(269, 25);
            computerJobsLabel.TabIndex = 21;
            computerJobsLabel.Text = "% of Computer-Related Jobs:";
            computerJobsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // computerJobsTextBox
            // 
            this.computerJobsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "% of Computer-Related Jobs", true));
            this.computerJobsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerJobsTextBox.Location = new System.Drawing.Point(349, 511);
            this.computerJobsTextBox.Name = "computerJobsTextBox";
            this.computerJobsTextBox.Size = new System.Drawing.Size(264, 30);
            this.computerJobsTextBox.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(246, 569);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 74);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 671);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(stateIDLabel);
            this.Controls.Add(this.stateIDTextBox);
            this.Controls.Add(stateNameLabel);
            this.Controls.Add(this.stateNameTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(stateFlagLabel);
            this.Controls.Add(this.stateFlagTextBox);
            this.Controls.Add(stateFlowerLabel);
            this.Controls.Add(this.stateFlowerTextBox);
            this.Controls.Add(stateBirdLabel);
            this.Controls.Add(this.stateBirdTextBox);
            this.Controls.Add(stateColorsLabel);
            this.Controls.Add(this.stateColorsTextBox);
            this.Controls.Add(largestCitiesLabel);
            this.Controls.Add(this.largestCitiesTextBox);
            this.Controls.Add(stateCapitolLabel);
            this.Controls.Add(this.stateCapitolTextBox);
            this.Controls.Add(medianIncomeLabel);
            this.Controls.Add(this.medianIncomeTextBox);
            this.Controls.Add(computerJobsLabel);
            this.Controls.Add(this.computerJobsTextBox);
            this.Controls.Add(this.statesBindingNavigator);
            this.Name = "Details";
            this.Text = "State Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uS_StatesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_StatesDataSet uS_StatesDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private US_StatesDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private US_StatesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stateIDTextBox;
        private System.Windows.Forms.TextBox stateNameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox stateFlagTextBox;
        private System.Windows.Forms.TextBox stateFlowerTextBox;
        private System.Windows.Forms.TextBox stateBirdTextBox;
        private System.Windows.Forms.TextBox stateColorsTextBox;
        private System.Windows.Forms.TextBox largestCitiesTextBox;
        private System.Windows.Forms.TextBox stateCapitolTextBox;
        private System.Windows.Forms.TextBox medianIncomeTextBox;
        private System.Windows.Forms.TextBox computerJobsTextBox;
        private System.Windows.Forms.Button btnClose;
    }
}