using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAD.Forms
{
    public partial class ViewVisaTypesForCountry : Form
    {
        private Country Country;
        private List<VisaType> AvailableVisaTypes;
        public ViewVisaTypesForCountry(Country country)
        {
            InitializeComponent();
            this.Country = country;
            LoadCountryDetails();
        }

        public void LoadCountryDetails()
        {
            if (Country == null)
            {
                return;
            }
            AvailableVisaTypes = Database.VisaTypes.Where(x => x.Country.ID == Country.ID).ToList();

            List<VisaTypeDisplay> displays = new List<VisaTypeDisplay>();

            for (int i = 0; i < AvailableVisaTypes.Count; i++)
            {
                VisaTypeDisplay newDisplay = new VisaTypeDisplay(AvailableVisaTypes[i]);

                Point point = new Point(0, i * 120);
                newDisplay.Location = point;
                displays.Add(newDisplay);
            }

            foreach(VisaTypeDisplay display in displays)
            {
                this.Controls.Add(display);
            }
        }
    }
}
