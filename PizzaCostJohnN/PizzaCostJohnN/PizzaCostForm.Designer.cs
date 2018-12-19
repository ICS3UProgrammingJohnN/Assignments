namespace PizzaCostJohnN
{
    partial class frmPizzaCost
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
            this.radMediumPizza = new System.Windows.Forms.RadioButton();
            this.radLargePizza = new System.Windows.Forms.RadioButton();
            this.radExtraLargePizza = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.grbReceipt = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.picPizzaSize = new System.Windows.Forms.PictureBox();
            this.lblSubTotalAnswer = new System.Windows.Forms.Label();
            this.lblHSTAnswer = new System.Windows.Forms.Label();
            this.lblTotalCostAnswer = new System.Windows.Forms.Label();
            this.lblNumberOfPizzas = new System.Windows.Forms.Label();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.txtNumberOfPizzas = new System.Windows.Forms.TextBox();
            this.grbReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaSize)).BeginInit();
            this.SuspendLayout();
            // 
            // radMediumPizza
            // 
            this.radMediumPizza.AutoSize = true;
            this.radMediumPizza.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMediumPizza.Location = new System.Drawing.Point(46, 65);
            this.radMediumPizza.Name = "radMediumPizza";
            this.radMediumPizza.Size = new System.Drawing.Size(145, 42);
            this.radMediumPizza.TabIndex = 1;
            this.radMediumPizza.TabStop = true;
            this.radMediumPizza.Text = "Medium";
            this.radMediumPizza.UseVisualStyleBackColor = true;
            // 
            // radLargePizza
            // 
            this.radLargePizza.AutoSize = true;
            this.radLargePizza.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLargePizza.Location = new System.Drawing.Point(197, 65);
            this.radLargePizza.Name = "radLargePizza";
            this.radLargePizza.Size = new System.Drawing.Size(108, 42);
            this.radLargePizza.TabIndex = 2;
            this.radLargePizza.TabStop = true;
            this.radLargePizza.Text = "Large";
            this.radLargePizza.UseVisualStyleBackColor = true;
            // 
            // radExtraLargePizza
            // 
            this.radExtraLargePizza.AutoSize = true;
            this.radExtraLargePizza.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExtraLargePizza.Location = new System.Drawing.Point(311, 65);
            this.radExtraLargePizza.Name = "radExtraLargePizza";
            this.radExtraLargePizza.Size = new System.Drawing.Size(176, 42);
            this.radExtraLargePizza.TabIndex = 3;
            this.radExtraLargePizza.TabStop = true;
            this.radExtraLargePizza.Text = "ExtraLarge";
            this.radExtraLargePizza.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(41, 172);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(355, 28);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "How many toppings would you like";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(207, 296);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(143, 50);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.Location = new System.Drawing.Point(383, 16);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(110, 38);
            this.lblReceipt.TabIndex = 7;
            this.lblReceipt.Text = "Receipt";
            // 
            // grbReceipt
            // 
            this.grbReceipt.Controls.Add(this.lblTotalCostAnswer);
            this.grbReceipt.Controls.Add(this.lblHSTAnswer);
            this.grbReceipt.Controls.Add(this.lblSubTotalAnswer);
            this.grbReceipt.Controls.Add(this.lblTotalCost);
            this.grbReceipt.Controls.Add(this.lblSubTotal);
            this.grbReceipt.Controls.Add(this.lblHST);
            this.grbReceipt.Controls.Add(this.lblReceipt);
            this.grbReceipt.Location = new System.Drawing.Point(12, 400);
            this.grbReceipt.Name = "grbReceipt";
            this.grbReceipt.Size = new System.Drawing.Size(898, 278);
            this.grbReceipt.TabIndex = 8;
            this.grbReceipt.TabStop = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(218, 224);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(128, 32);
            this.lblTotalCost.TabIndex = 11;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(230, 83);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(108, 32);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(280, 134);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(58, 28);
            this.lblHST.TabIndex = 9;
            this.lblHST.Text = "HST:";
            // 
            // picPizzaSize
            // 
            this.picPizzaSize.Image = global::PizzaCostJohnN.Properties.Resources.pizza_dancing;
            this.picPizzaSize.Location = new System.Drawing.Point(603, 65);
            this.picPizzaSize.Name = "picPizzaSize";
            this.picPizzaSize.Size = new System.Drawing.Size(262, 264);
            this.picPizzaSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPizzaSize.TabIndex = 9;
            this.picPizzaSize.TabStop = false;
            // 
            // lblSubTotalAnswer
            // 
            this.lblSubTotalAnswer.AutoSize = true;
            this.lblSubTotalAnswer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalAnswer.Location = new System.Drawing.Point(344, 83);
            this.lblSubTotalAnswer.Name = "lblSubTotalAnswer";
            this.lblSubTotalAnswer.Size = new System.Drawing.Size(99, 32);
            this.lblSubTotalAnswer.TabIndex = 12;
            this.lblSubTotalAnswer.Text = "subtotal";
            // 
            // lblHSTAnswer
            // 
            this.lblHSTAnswer.AutoSize = true;
            this.lblHSTAnswer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSTAnswer.Location = new System.Drawing.Point(344, 130);
            this.lblHSTAnswer.Name = "lblHSTAnswer";
            this.lblHSTAnswer.Size = new System.Drawing.Size(47, 32);
            this.lblHSTAnswer.TabIndex = 13;
            this.lblHSTAnswer.Text = "hst";
            // 
            // lblTotalCostAnswer
            // 
            this.lblTotalCostAnswer.AutoSize = true;
            this.lblTotalCostAnswer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostAnswer.Location = new System.Drawing.Point(344, 224);
            this.lblTotalCostAnswer.Name = "lblTotalCostAnswer";
            this.lblTotalCostAnswer.Size = new System.Drawing.Size(57, 32);
            this.lblTotalCostAnswer.TabIndex = 15;
            this.lblTotalCostAnswer.Text = "cost";
            // 
            // lblNumberOfPizzas
            // 
            this.lblNumberOfPizzas.AutoSize = true;
            this.lblNumberOfPizzas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPizzas.Location = new System.Drawing.Point(66, 230);
            this.lblNumberOfPizzas.Name = "lblNumberOfPizzas";
            this.lblNumberOfPizzas.Size = new System.Drawing.Size(330, 28);
            this.lblNumberOfPizzas.TabIndex = 10;
            this.lblNumberOfPizzas.Text = "How many pizzas would you like";
            // 
            // txtToppings
            // 
            this.txtToppings.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.Location = new System.Drawing.Point(402, 164);
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(53, 36);
            this.txtToppings.TabIndex = 11;
            // 
            // txtNumberOfPizzas
            // 
            this.txtNumberOfPizzas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPizzas.Location = new System.Drawing.Point(402, 230);
            this.txtNumberOfPizzas.Name = "txtNumberOfPizzas";
            this.txtNumberOfPizzas.Size = new System.Drawing.Size(53, 36);
            this.txtNumberOfPizzas.TabIndex = 12;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaCostJohnN.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(922, 690);
            this.Controls.Add(this.txtNumberOfPizzas);
            this.Controls.Add(this.txtToppings);
            this.Controls.Add(this.lblNumberOfPizzas);
            this.Controls.Add(this.picPizzaSize);
            this.Controls.Add(this.grbReceipt);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.radExtraLargePizza);
            this.Controls.Add(this.radLargePizza);
            this.Controls.Add(this.radMediumPizza);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            this.grbReceipt.ResumeLayout(false);
            this.grbReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMediumPizza;
        private System.Windows.Forms.RadioButton radLargePizza;
        private System.Windows.Forms.RadioButton radExtraLargePizza;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.GroupBox grbReceipt;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.PictureBox picPizzaSize;
        private System.Windows.Forms.Label lblTotalCostAnswer;
        private System.Windows.Forms.Label lblHSTAnswer;
        private System.Windows.Forms.Label lblSubTotalAnswer;
        private System.Windows.Forms.Label lblNumberOfPizzas;
        private System.Windows.Forms.TextBox txtToppings;
        private System.Windows.Forms.TextBox txtNumberOfPizzas;
    }
}

