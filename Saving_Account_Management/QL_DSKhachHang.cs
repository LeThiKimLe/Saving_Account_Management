using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using Saving_Account_Management.BS_Layer;
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_DSKhachHang : Form
    {
        private BS_DSKhachHang action = new BS_DSKhachHang();
        public QL_DSKhachHang()
        {
            InitializeComponent();
        }
    }
}
