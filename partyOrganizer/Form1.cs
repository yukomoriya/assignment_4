using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partyOrganizer
{
    public partial class Form1 : Form
    {
        private PartyManager partyManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
           if(int.TryParse(txtbMaxNumberGuests.Text,out int maxNumberOfGuests))
            partyManager = new PartyManager(maxNumberOfGuests);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (partyManager == null) return;
            if(!string.IsNullOrEmpty(txtbLastName.Text) && !string.IsNullOrEmpty(txtbFirstName.Text))
            {
                var success = partyManager.AddNewGuests(txtbFirstName.Text, txtbLastName.Text);
                if (success) {
                    txtbFirstName.Text = string.Empty;
                    txtbLastName.Text = string.Empty;
                }
                DisplayGuestsList();
            }
        }

        private void DisplayGuestsList()
        {
            ListBox.ObjectCollection objectCollection = new ListBox.ObjectCollection(lBGuestList);
            objectCollection.Clear();
            foreach (var guest in partyManager.Guests)
            {
                if (guest == null)
                {
                    objectCollection.Add("");
                }
                else {
                    objectCollection.Add(guest);
                }
            }
            
        }
    }
}
