using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content.PM;

namespace XamarinAnimateRadioGroup
{
    [Activity(Label = "AnimateRadioGroup", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        private RadioGroup RdRetrorrefletancia { get; set; }

        private ImageView CorImageViewRadioGroup { get; set; }

        private int Cor;
    
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            this.Title = "RadioGroup";
            CorImageViewRadioGroup = (ImageView)FindViewById(Resource.Id.CorImageViewRadioGroup);

            RdRetrorrefletancia = (RadioGroup)FindViewById(Resource.Id.rgRadioGroup);
            RdRetrorrefletancia.Tag = false;
            RdRetrorrefletancia.CheckedChange += OnRdRetrorrefletancia_Click;
        }

        private void OnRdRetrorrefletancia_Click(object sender, EventArgs e)
        {
            switch (RdRetrorrefletancia.CheckedRadioButtonId)
            {
                case Resource.Id.rd_branca:
                    Toast.MakeText(this, "O radioButton branco está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_branco;
                    break;
                case Resource.Id.rd_vermelho:
                    Toast.MakeText(this, "O radioButton vermelho está selecionado ", ToastLength.Short).Show();
                    
                    Cor = Resource.Drawable.ic_circulo_vermelho;
                    break;
                case Resource.Id.rd_verde:
                    Toast.MakeText(this, "O radioButton verde está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_verde;
                    break;
                case Resource.Id.rd_azul:
                    Toast.MakeText(this, "O radioButton azul está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_azul;
                    break;
                case Resource.Id.rd_amarela:
                    Toast.MakeText(this, "O radioButton amarelo está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_amarela;
                    break;
                case Resource.Id.rd_marron:
                    Toast.MakeText(this, "O radioButton marrom está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_marron;
                    break;
                case Resource.Id.rd_Preto:
                    Toast.MakeText(this, "O radioButton preto está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_preto;
                    break;
                case Resource.Id.rd_amareloFlorescente:
                    Toast.MakeText(this, "O radioButton amarelo Fluorescente está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_amarelo_florescente;
                    break;
                case Resource.Id.rd_amareloLimaLimao:
                    Toast.MakeText(this, "O radioButton amarelo lima limão está selecionado ", ToastLength.Short).Show();
                    Cor = Resource.Drawable.ic_circulo_amarelo_lima_limao;
                    break;
            }
            CorImageViewRadioGroup.SetBackgroundResource(Cor);
            RadioButton radioButton = FindViewById<RadioButton>(RdRetrorrefletancia.CheckedRadioButtonId);
        }
    }
}

