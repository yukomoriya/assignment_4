
namespace partyOrganizer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.txtbFeePerson = new System.Windows.Forms.TextBox();
            this.txtbCostPerson = new System.Windows.Forms.TextBox();
            this.txtbMaxNumberGuests = new System.Windows.Forms.TextBox();
            this.lblFeePerson = new System.Windows.Forms.Label();
            this.lblCostPerson = new System.Windows.Forms.Label();
            this.lblMaxNumberGuests = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNumberOfGuests = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTotalCost = new System.Windows.Forms.TextBox();
            this.txtbFees = new System.Windows.Forms.TextBox();
            this.txtbSurplus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lBGuestList = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateList);
            this.groupBox1.Controls.Add(this.txtbFeePerson);
            this.groupBox1.Controls.Add(this.txtbCostPerson);
            this.groupBox1.Controls.Add(this.txtbMaxNumberGuests);
            this.groupBox1.Controls.Add(this.lblFeePerson);
            this.groupBox1.Controls.Add(this.lblCostPerson);
            this.groupBox1.Controls.Add(this.lblMaxNumberGuests);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Party";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(121, 153);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(75, 23);
            this.btnCreateList.TabIndex = 6;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // txtbFeePerson
            // 
            this.txtbFeePerson.Location = new System.Drawing.Point(172, 97);
            this.txtbFeePerson.Name = "txtbFeePerson";
            this.txtbFeePerson.Size = new System.Drawing.Size(100, 23);
            this.txtbFeePerson.TabIndex = 5;
            // 
            // txtbCostPerson
            // 
            this.txtbCostPerson.Location = new System.Drawing.Point(172, 68);
            this.txtbCostPerson.Name = "txtbCostPerson";
            this.txtbCostPerson.Size = new System.Drawing.Size(100, 23);
            this.txtbCostPerson.TabIndex = 4;
            // 
            // txtbMaxNumberGuests
            // 
            this.txtbMaxNumberGuests.Location = new System.Drawing.Point(172, 39);
            this.txtbMaxNumberGuests.Name = "txtbMaxNumberGuests";
            this.txtbMaxNumberGuests.Size = new System.Drawing.Size(100, 23);
            this.txtbMaxNumberGuests.TabIndex = 3;
            // 
            // lblFeePerson
            // 
            this.lblFeePerson.AutoSize = true;
            this.lblFeePerson.Location = new System.Drawing.Point(11, 105);
            this.lblFeePerson.Name = "lblFeePerson";
            this.lblFeePerson.Size = new System.Drawing.Size(84, 15);
            this.lblFeePerson.TabIndex = 2;
            this.lblFeePerson.Text = "Fee per person";
            // 
            // lblCostPerson
            // 
            this.lblCostPerson.AutoSize = true;
            this.lblCostPerson.Location = new System.Drawing.Point(11, 76);
            this.lblCostPerson.Name = "lblCostPerson";
            this.lblCostPerson.Size = new System.Drawing.Size(90, 15);
            this.lblCostPerson.TabIndex = 1;
            this.lblCostPerson.Text = "Cost per person";
            // 
            // lblMaxNumberGuests
            // 
            this.lblMaxNumberGuests.AutoSize = true;
            this.lblMaxNumberGuests.Location = new System.Drawing.Point(11, 40);
            this.lblMaxNumberGuests.Name = "lblMaxNumberGuests";
            this.lblMaxNumberGuests.Size = new System.Drawing.Size(126, 15);
            this.lblMaxNumberGuests.TabIndex = 0;
            this.lblMaxNumberGuests.Text = "Max number of guests";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtbLastName);
            this.groupBox2.Controls.Add(this.txtbFirstName);
            this.groupBox2.Controls.Add(this.lblLastName);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Location = new System.Drawing.Point(47, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(128, 54);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(161, 23);
            this.txtbLastName.TabIndex = 3;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(128, 25);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(161, 23);
            this.txtbFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of guests";
            // 
            // txtbNumberOfGuests
            // 
            this.txtbNumberOfGuests.Location = new System.Drawing.Point(197, 345);
            this.txtbNumberOfGuests.Name = "txtbNumberOfGuests";
            this.txtbNumberOfGuests.Size = new System.Drawing.Size(78, 23);
            this.txtbNumberOfGuests.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surplus/deficit";
            // 
            // txtbTotalCost
            // 
            this.txtbTotalCost.Location = new System.Drawing.Point(197, 376);
            this.txtbTotalCost.Name = "txtbTotalCost";
            this.txtbTotalCost.Size = new System.Drawing.Size(78, 23);
            this.txtbTotalCost.TabIndex = 7;
            // 
            // txtbFees
            // 
            this.txtbFees.Location = new System.Drawing.Point(197, 410);
            this.txtbFees.Name = "txtbFees";
            this.txtbFees.Size = new System.Drawing.Size(78, 23);
            this.txtbFees.TabIndex = 8;
            // 
            // txtbSurplus
            // 
            this.txtbSurplus.Location = new System.Drawing.Point(197, 441);
            this.txtbSurplus.Name = "txtbSurplus";
            this.txtbSurplus.Size = new System.Drawing.Size(78, 23);
            this.txtbSurplus.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Guest List";
            // 
            // lBGuestList
            // 
            this.lBGuestList.FormattingEnabled = true;
            this.lBGuestList.ItemHeight = 15;
            this.lBGuestList.Location = new System.Drawing.Point(486, 34);
            this.lBGuestList.Name = "lBGuestList";
            this.lBGuestList.Size = new System.Drawing.Size(238, 364);
            this.lBGuestList.TabIndex = 11;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(515, 424);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(630, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 528);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lBGuestList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbSurplus);
            this.Controls.Add(this.txtbFees);
            this.Controls.Add(this.txtbTotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNumberOfGuests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.TextBox txtbFeePerson;
        private System.Windows.Forms.TextBox txtbCostPerson;
        private System.Windows.Forms.TextBox txtbMaxNumberGuests;
        private System.Windows.Forms.Label lblFeePerson;
        private System.Windows.Forms.Label lblCostPerson;
        private System.Windows.Forms.Label lblMaxNumberGuests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNumberOfGuests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbTotalCost;
        private System.Windows.Forms.TextBox txtbFees;
        private System.Windows.Forms.TextBox txtbSurplus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lBGuestList;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

