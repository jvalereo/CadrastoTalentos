using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroTalento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declarar as variaveis sexo e idioma, tipo string, int
        string sexo = "";
        int qtdeIdiomas = 0;

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            //Projeto básico Cadastro de Talentos, Aula - Etec de São Paulo
            //Curso técnico em informática noturno - 2015
            //Projeto remoto, não tem banco de dados 
            //Jonas Valereo - Técnico em informática


            //declarando vetor array mItems, tipo string 
            string[] mItems = new string[] {

               TextBoxNome.Text,
               dateTimePickerNascimento.Text,
               MaskedTextBoxCpf.Text,
               MaskedTextBoxRg.Text,
               sexo,
               ComboBoxFormacao.SelectedItem.ToString(),
               qtdeIdiomas.ToString(),
               checkListBoxInfo.CheckedItems.Count.ToString()

            };

            //declarando objeto list, criando uma listas e instanciando
            ListViewItem list = new ListViewItem(mItems);
            listViewDados.Items.Add(list);
            //declarando metodo LimpaTela
            LimpaTela();

        }

        //declarando o RadiobuttonMasculino 
        private void RadioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {
            //declerando a variavel sexo masculino
            sexo = "M";
        }

        //declarando o RadiobuttonFeminino
        private void RadioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {
            //declarando a variavel sexo feminino
            sexo = "F";
        }

        //declarando o CheckboxIngles
        private void CheckBoxIngles_CheckedChanged(object sender, EventArgs e)
        {
            //declarando tomada de decisao if, adicionando a variavel qtdeIdioma, incremento, decremento
            if (CheckBoxIngles.Checked == true)
            {
                qtdeIdiomas++;
            }
            else
            {
                qtdeIdiomas--;
            }
        }

        //declarando o CheckboxEspanhol
        private void CheckBoxEspanhol_CheckedChanged(object sender, EventArgs e)
        {
            //declarando tomada de decisao if, adicionando a variavel qtdeIdioma, incremento, decremento
            if (CheckBoxEspanhol.Checked == true)
            {
                qtdeIdiomas++;
            }
            else
            {
                qtdeIdiomas--;
            }
        }

        //declarando o CheckboxItaliano
        private void CheckBoxItaliano_CheckedChanged(object sender, EventArgs e)
        {
            //declarando tomada de decisao if, adicionando a variavel qtdeIdioma, incremento, decremento
            if (CheckBoxItaliano.Checked == true)
            {
                qtdeIdiomas++;
            }
            else
            {
                qtdeIdiomas--;
            }
        }

        //declarando o CheckboxTodos
        private void CheckBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            //declarando tomada de decisao if e else, adicionando for, incremento e decremento
            if (CheckBoxTodos.Checked == true)
            {
                for (int i = 0; i < checkListBoxInfo.Items.Count; i++)
                {
                    checkListBoxInfo.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int a = 0; a < checkListBoxInfo.Items.Count; a++)
                {
                    checkListBoxInfo.SetItemChecked(a, true);
                }
            }
        }

        //declarando button, listViemDado, ensirir na grid, alterar e excluir
        private void listViewDados_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxNome.Text = listViewDados.FocusedItem.SubItems[0].Text;
            dateTimePickerNascimento.Text = listViewDados.FocusedItem.SubItems[1].Text;
            MaskedTextBoxCpf.Text = listViewDados.FocusedItem.SubItems[2].Text;
            MaskedTextBoxRg.Text = listViewDados.FocusedItem.SubItems[3].Text;
            ComboBoxFormacao.Text = listViewDados.FocusedItem.SubItems[5].Text;
        }

        //declarando button, BtnAltera, altera dados na listViemDado
        private void BtnAltera_Click(object sender, EventArgs e)
        {
            listViewDados.FocusedItem.SubItems[0].Text = TextBoxNome.Text;
            listViewDados.FocusedItem.SubItems[1].Text = dateTimePickerNascimento.Text;
            listViewDados.FocusedItem.SubItems[2].Text = MaskedTextBoxCpf.Text;
            listViewDados.FocusedItem.SubItems[3].Text = MaskedTextBoxRg.Text;
            listViewDados.FocusedItem.SubItems[4].Text = sexo;
            listViewDados.FocusedItem.SubItems[5].Text = ComboBoxFormacao.SelectedItem.ToString();
            listViewDados.FocusedItem.SubItems[6].Text = qtdeIdiomas.ToString();
            listViewDados.FocusedItem.SubItems[7].Text = checkListBoxInfo.CheckedItems.Count.ToString();
            //declarando metodo LimpaTela
            LimpaTela();
        }

        //declarando button, BtnExcluir, excluir da listViemDado, aplicando for 
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = listViewDados.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem li = listViewDados.SelectedItems[i];
                listViewDados.Items.Remove(li);
            }

            //declarando metodo LimpaTela
            LimpaTela();
        }

        //declarando button, BtnSair, fechar o aplicativo
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //declarando metodo LimpaTela
        public void LimpaTela()
        {
            TextBoxNome.Clear();
            dateTimePickerNascimento.Text = "";
            MaskedTextBoxCpf.Clear();
            MaskedTextBoxRg.Clear();
            ComboBoxFormacao.SelectedIndex = -1;
            TextBoxMesagem.Clear();
            CheckBoxIngles.Checked = false;
            CheckBoxEspanhol.Checked = false;
            CheckBoxItaliano.Checked = false;
            RadioButtonMasculino.Checked = false;
            RadioButtonFeminino.Checked = false;
            CheckBoxTodos.Checked = false;
        }
    }
    //fim do programa
}
