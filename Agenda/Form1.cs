using System.Drawing.Text;
using System.IO; //usado para trabalhar com arquivo externo

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != String.Empty && txtFone.Text != String.Empty && cmbSexo.Text != String.Empty)
            {
                if(MessageBox.Show("Deseja inserir esse registro?",
                    "Valida��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    lstAgenda.Items.Add(txtNome.Text+"|"+txtFone.Text+"|"+cmbSexo.Text);
                    btnNovo.PerformClick(); // comando para bot�o
                    //btnNovo_Click(Sender, e); comando para objetos gerais 
                }
                else
                {
                  
                }

            }
            else
            {
                MessageBox.Show(
                    "Preencha todos os campos do formulario",
                    "ta errado fiii",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtFone.Text = String.Empty;
            txtNome.Text = String.Empty;
            cmbSexo.Text = String.Empty;

            txtNome.Focus(); //Coloca o cursor no campo NOME
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(lstAgenda.SelectedItems.Count > 0)
            {
                if(MessageBox.Show(
                    "Deseja remover o item selecionado?",
                    "Informa��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    lstAgenda.Items.RemoveAt(lstAgenda.SelectedIndex);
                    MessageBox.Show("Sucesso na remo��o do item.");
                }
                else
                {
                    MessageBox.Show(
                      "Processo camcelado pelo usu�rio",
                      "informa��o",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um item da lista.",
                    "informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(lstAgenda.SelectedIndex >= 0)
            {
                if(MessageBox.Show(
                    "Deseja restaurar?",
                    "Infroma��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)== DialogResult.Yes)
                {
                String[] campos;

                campos = lstAgenda.SelectedItem.ToString().Split('|');
               
                txtNome.Text = campos[0];
                txtFone.Text = campos[1];
                cmbSexo.Text = campos[2];
                }

            }
            else
            {
                MessageBox.Show(
                    "Selecione um item da lista.",
                    "informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }           
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparContatos_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Deseja mesmo limpar a lista ?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstAgenda.Items.Clear();
            }
            else
            {
                MessageBox.Show("A lista n�o foi apagada",
                    "Informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FileInfo salvarArquivo = new FileInfo(@".\bkLista.txt");//o ponto pega o diretorio do app

            if (!salvarArquivo.Exists)
            {
                using(StreamWriter sa = salvarArquivo.CreateText())
                {
                    for (int i = 0; i < lstAgenda.Items.Count; i++)
                    {
                        sa.WriteLine(lstAgenda.Items[i].ToString());
                    }
                }
            }
            else if(MessageBox.Show("Deseja sobrepor o arquivo ?",
                    "Informa��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.Yes)
            {
                using (StreamWriter sa = salvarArquivo.CreateText())
                {
                    for (int i = 0; i < lstAgenda.Items.Count; i++)
                    {
                        sa.WriteLine(lstAgenda.Items[i].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("O Arquivo n�o foi alterado!");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FileInfo abrirArquivo = new FileInfo(@".\bkLista.txt");

            if (abrirArquivo.Exists)
            {
                using(StreamReader aa = abrirArquivo.OpenText())
                {
                    lstAgenda.Items.Clear();

                    string linha = null;

                    while((linha = aa.ReadLine()) != null)
                    {
                        lstAgenda.Items.Add(linha);
                    }
                }
                MessageBox.Show("Importa��o concluida com sucesso",
                   "informa��o",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("backup n�o encontrado",
                    "informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}