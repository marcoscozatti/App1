using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Conexao con = new Conexao();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button btnConn = FindViewById<Button>(Resource.Id.btnConecta);
            TextView txtRes = FindViewById<TextView>(Resource.Id.txtResultado);
            TextView txtUsu = FindViewById<TextView>(Resource.Id.txtUsuario);
            TextView txtPass = FindViewById<TextView>(Resource.Id.txtSenha);

            btnConn.Click += delegate
            {
                con.AbrirCon();
                txtRes.Text = "Conectado!!!";
            };


           



        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            
        }
        

    }

}

