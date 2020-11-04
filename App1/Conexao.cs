using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;

namespace App1
{
	public class Conexao
	{
		public string conec = "SERVER=hipnoclinica.com.br; DATABASE=hipnoc08_BDXamarin; UID=hipnoc08_xama01; PWD=y3x.bmw9; PORT=3306";
		public MySqlConnection con = null;
		

		public void AbrirCon()
		{
			try
			{
				con = new MySqlConnection(conec);
				con.Open();
				Toast.MakeText(Application.Context, "Conexão efetuada com sucesso!", ToastLength.Long).Show();
				
			}
			catch (Exception ex)
			{

				Toast.MakeText(Application.Context, "Erro ao conectar!!! " + ex.Message, ToastLength.Long).Show();

			}
		}

		public void FecharCon()
		{
			try
			{
				con = new MySqlConnection(conec);
				con.Close();
				Toast.MakeText(Application.Context, "Conexão fechada com sucesso!", ToastLength.Long).Show();
			}
			catch (Exception ex)
			{

				Toast.MakeText(Application.Context, "Erro ao desconectar!!! " + ex.Message, ToastLength.Long).Show();

			}
		}


	}
}