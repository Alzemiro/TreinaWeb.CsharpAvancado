using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEventos
{
    public partial class frmGerenciadorLatidos : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;
        public frmGerenciadorLatidos()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) => 
            {
                ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show(string.Format("O cachorro passou dos limites, com {0} decibeis. ", eventArgs.IntensidadeLatido, "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            };
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                MessageBox.Show("Você acbou de levar uma multa ", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void frmGerenciadorLatidos_Load(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = 0;

        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = _gerenciadorLatidos.Latir();
        }

   
    }
}
