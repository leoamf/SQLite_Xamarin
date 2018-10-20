using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            carregarLista();
        }   

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Aluno aluno = new Aluno
            {
                Nome = txtNome.Text,
                Idade = txtIdade.Text
            };

            App.BD.Insert(aluno);
            carregarLista();
        }

        void carregarLista(){

            var dadosTabela = App.BD.Table<Aluno>();
            if(dadosTabela!=null){

                List<Aluno> lista = dadosTabela.ToList();
                
                listarAluno.ItemsSource = lista;
            }
        }
    }
}
