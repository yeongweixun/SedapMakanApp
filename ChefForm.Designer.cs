using System.Windows.Forms;

namespace SedapMakanApp
{
    partial class ChefForm
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
            this.chefForm_lbl = new System.Windows.Forms.Label();
            this.exitChefBtn = new System.Windows.Forms.Button();
            this.menuListview = new System.Windows.Forms.ListView();
            this.selectedFoodLabel = new System.Windows.Forms.Label();
            this.removeSelected = new System.Windows.Forms.Button();
            this.editSelected = new System.Windows.Forms.Button();
            this.targetEditName = new System.Windows.Forms.TextBox();
            this.targetEditPrice = new System.Windows.Forms.TextBox();
            this.targetEditDescription = new System.Windows.Forms.TextBox();
            this.confirmEditBtn = new System.Windows.Forms.Button();
            this.addFoodBtn = new System.Windows.Forms.Button();
            this.foodEntryNameLabel = new System.Windows.Forms.Label();
            this.foodEntryPriceLabel = new System.Windows.Forms.Label();
            this.editorModeLabel = new System.Windows.Forms.Label();
            this.targetEditAvailability = new System.Windows.Forms.CheckBox();
            this.IdEntryLabel = new System.Windows.Forms.Label();
            this.targetEditId = new System.Windows.Forms.TextBox();
            this.orderListview = new System.Windows.Forms.ListView();
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.viewSelectedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chefForm_lbl
            // 
            this.chefForm_lbl.AutoSize = true;
            this.chefForm_lbl.Location = new System.Drawing.Point(23, 9);
            this.chefForm_lbl.Name = "chefForm_lbl";
            this.chefForm_lbl.Size = new System.Drawing.Size(68, 16);
            this.chefForm_lbl.TabIndex = 0;
            this.chefForm_lbl.Text = "Chef Form";
            // 
            // exitChefBtn
            // 
            this.exitChefBtn.Location = new System.Drawing.Point(393, 58);
            this.exitChefBtn.Name = "exitChefBtn";
            this.exitChefBtn.Size = new System.Drawing.Size(75, 23);
            this.exitChefBtn.TabIndex = 1;
            this.exitChefBtn.Text = "exitChef";
            this.exitChefBtn.UseVisualStyleBackColor = true;
            this.exitChefBtn.Click += new System.EventHandler(this.exitChefBtn_Click);
            // 
            // menuListview
            // 
            this.menuListview.AccessibleName = "";
            this.menuListview.HideSelection = false;
            this.menuListview.Location = new System.Drawing.Point(26, 58);
            this.menuListview.Name = "menuListview";
            this.menuListview.Scrollable = false;
            this.menuListview.Size = new System.Drawing.Size(351, 261);
            this.menuListview.TabIndex = 2;
            this.menuListview.UseCompatibleStateImageBehavior = false;
            // 
            // selectedFoodLabel
            // 
            this.selectedFoodLabel.AutoSize = true;
            this.selectedFoodLabel.Location = new System.Drawing.Point(23, 332);
            this.selectedFoodLabel.Name = "selectedFoodLabel";
            this.selectedFoodLabel.Size = new System.Drawing.Size(135, 16);
            this.selectedFoodLabel.TabIndex = 3;
            this.selectedFoodLabel.Text = "Selected Food: None";
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(303, 329);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(74, 23);
            this.removeSelected.TabIndex = 4;
            this.removeSelected.Text = "Remove Selected";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // editSelected
            // 
            this.editSelected.Location = new System.Drawing.Point(26, 363);
            this.editSelected.Name = "editSelected";
            this.editSelected.Size = new System.Drawing.Size(132, 23);
            this.editSelected.TabIndex = 5;
            this.editSelected.Text = "Edit Selected";
            this.editSelected.UseVisualStyleBackColor = true;
            this.editSelected.Click += new System.EventHandler(this.editSelected_Click);
            // 
            // targetEditName
            // 
            this.targetEditName.Location = new System.Drawing.Point(137, 405);
            this.targetEditName.Name = "targetEditName";
            this.targetEditName.Size = new System.Drawing.Size(131, 22);
            this.targetEditName.TabIndex = 6;
            // 
            // targetEditPrice
            // 
            this.targetEditPrice.Location = new System.Drawing.Point(318, 404);
            this.targetEditPrice.Name = "targetEditPrice";
            this.targetEditPrice.Size = new System.Drawing.Size(59, 22);
            this.targetEditPrice.TabIndex = 7;
            // 
            // targetEditDescription
            // 
            this.targetEditDescription.Location = new System.Drawing.Point(26, 446);
            this.targetEditDescription.Multiline = true;
            this.targetEditDescription.Name = "targetEditDescription";
            this.targetEditDescription.Size = new System.Drawing.Size(351, 57);
            this.targetEditDescription.TabIndex = 8;
            // 
            // confirmEditBtn
            // 
            this.confirmEditBtn.Location = new System.Drawing.Point(302, 509);
            this.confirmEditBtn.Name = "confirmEditBtn";
            this.confirmEditBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmEditBtn.TabIndex = 9;
            this.confirmEditBtn.Text = "Confirm";
            this.confirmEditBtn.UseVisualStyleBackColor = true;
            this.confirmEditBtn.Click += new System.EventHandler(this.confirmEditBtn_Click);
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.Location = new System.Drawing.Point(255, 363);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.Size = new System.Drawing.Size(122, 23);
            this.addFoodBtn.TabIndex = 10;
            this.addFoodBtn.Text = "Add New Food";
            this.addFoodBtn.UseVisualStyleBackColor = true;
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // foodEntryNameLabel
            // 
            this.foodEntryNameLabel.AutoSize = true;
            this.foodEntryNameLabel.Location = new System.Drawing.Point(87, 408);
            this.foodEntryNameLabel.Name = "foodEntryNameLabel";
            this.foodEntryNameLabel.Size = new System.Drawing.Size(44, 16);
            this.foodEntryNameLabel.TabIndex = 11;
            this.foodEntryNameLabel.Text = "Name";
            // 
            // foodEntryPriceLabel
            // 
            this.foodEntryPriceLabel.AutoSize = true;
            this.foodEntryPriceLabel.Location = new System.Drawing.Point(274, 407);
            this.foodEntryPriceLabel.Name = "foodEntryPriceLabel";
            this.foodEntryPriceLabel.Size = new System.Drawing.Size(38, 16);
            this.foodEntryPriceLabel.TabIndex = 12;
            this.foodEntryPriceLabel.Text = "Price";
            // 
            // editorModeLabel
            // 
            this.editorModeLabel.AutoSize = true;
            this.editorModeLabel.Location = new System.Drawing.Point(214, 513);
            this.editorModeLabel.Name = "editorModeLabel";
            this.editorModeLabel.Size = new System.Drawing.Size(73, 16);
            this.editorModeLabel.TabIndex = 13;
            this.editorModeLabel.Text = "Mode: Add";
            // 
            // targetEditAvailability
            // 
            this.targetEditAvailability.AutoSize = true;
            this.targetEditAvailability.Location = new System.Drawing.Point(26, 509);
            this.targetEditAvailability.Name = "targetEditAvailability";
            this.targetEditAvailability.Size = new System.Drawing.Size(86, 20);
            this.targetEditAvailability.TabIndex = 14;
            this.targetEditAvailability.Text = "Available";
            this.targetEditAvailability.UseVisualStyleBackColor = true;
            // 
            // IdEntryLabel
            // 
            this.IdEntryLabel.AutoSize = true;
            this.IdEntryLabel.Location = new System.Drawing.Point(23, 409);
            this.IdEntryLabel.Name = "IdEntryLabel";
            this.IdEntryLabel.Size = new System.Drawing.Size(20, 16);
            this.IdEntryLabel.TabIndex = 15;
            this.IdEntryLabel.Text = "ID";
            // 
            // targetEditId
            // 
            this.targetEditId.Location = new System.Drawing.Point(45, 406);
            this.targetEditId.Name = "targetEditId";
            this.targetEditId.Size = new System.Drawing.Size(42, 22);
            this.targetEditId.TabIndex = 16;
            // 
            // orderListview
            // 
            this.orderListview.AccessibleName = "";
            this.orderListview.HideSelection = false;
            this.orderListview.Location = new System.Drawing.Point(487, 58);
            this.orderListview.Name = "orderListview";
            this.orderListview.Scrollable = false;
            this.orderListview.Size = new System.Drawing.Size(441, 261);
            this.orderListview.TabIndex = 17;
            this.orderListview.UseCompatibleStateImageBehavior = false;
            this.orderListview.SelectedIndexChanged += new System.EventHandler(this.orderListview_SelectedIndexChanged);
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Location = new System.Drawing.Point(495, 332);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(137, 16);
            this.selectedOrderLabel.TabIndex = 18;
            this.selectedOrderLabel.Text = "Selected Order: None";
            // 
            // viewSelectedBtn
            // 
            this.viewSelectedBtn.Location = new System.Drawing.Point(820, 332);
            this.viewSelectedBtn.Name = "viewSelectedBtn";
            this.viewSelectedBtn.Size = new System.Drawing.Size(108, 23);
            this.viewSelectedBtn.TabIndex = 19;
            this.viewSelectedBtn.Text = "View Selected";
            this.viewSelectedBtn.UseVisualStyleBackColor = true;
            this.viewSelectedBtn.Click += new System.EventHandler(this.viewSelectedBtn_Click);
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 560);
            this.Controls.Add(this.viewSelectedBtn);
            this.Controls.Add(this.selectedOrderLabel);
            this.Controls.Add(this.orderListview);
            this.Controls.Add(this.targetEditId);
            this.Controls.Add(this.IdEntryLabel);
            this.Controls.Add(this.targetEditAvailability);
            this.Controls.Add(this.editorModeLabel);
            this.Controls.Add(this.foodEntryPriceLabel);
            this.Controls.Add(this.foodEntryNameLabel);
            this.Controls.Add(this.addFoodBtn);
            this.Controls.Add(this.confirmEditBtn);
            this.Controls.Add(this.targetEditDescription);
            this.Controls.Add(this.targetEditPrice);
            this.Controls.Add(this.targetEditName);
            this.Controls.Add(this.editSelected);
            this.Controls.Add(this.removeSelected);
            this.Controls.Add(this.selectedFoodLabel);
            this.Controls.Add(this.menuListview);
            this.Controls.Add(this.exitChefBtn);
            this.Controls.Add(this.chefForm_lbl);
            this.Name = "ChefForm";
            this.Text = "Chef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chefForm_lbl;
        private System.Windows.Forms.Button exitChefBtn;
        private System.Windows.Forms.ListView menuListview;
        private System.Windows.Forms.Label selectedFoodLabel;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.Button editSelected;
        private System.Windows.Forms.TextBox targetEditName;
        private System.Windows.Forms.TextBox targetEditPrice;
        private System.Windows.Forms.TextBox targetEditDescription;
        private System.Windows.Forms.Button confirmEditBtn;
        private System.Windows.Forms.Button addFoodBtn;
        private System.Windows.Forms.Label foodEntryNameLabel;
        private System.Windows.Forms.Label foodEntryPriceLabel;
        private Label editorModeLabel;
        private System.Windows.Forms.CheckBox targetEditAvailability;
        private Label IdEntryLabel;
        private TextBox targetEditId;
        private ListView orderListview;
        private Label selectedOrderLabel;
        private Button viewSelectedBtn;
    }
}