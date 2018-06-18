using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Species;

namespace Species
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SqlCommander sqlCommand = new SqlCommander();
            Species.Species species = new Species.Species();

            List<string> query = species.PopulateSpecie();

            sqlCommand.AddStuff(query);
        }
    }
}