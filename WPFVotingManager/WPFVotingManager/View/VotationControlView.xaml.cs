
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using SunVote;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input; 

namespace WPFVotingManager.View
{
    /// <summary>
    /// Lógica de interacción para VotationControlView.xaml
    /// </summary>
    public partial class VotationControlView : Page
    {
        private GraphicControlView secondaryWindow;

        BaseConnection baseConn;// = new SunVote.BaseConnection();
        BaseManage baseManage;
        Choices choices;
        KeypadManage keypadManage;
        Election election;
        SunVote.Message message;
        SunVote.SignIn signIn;

        public VotationControlView()
        {
            InitializeComponent();
            signIn = new SunVote.SignIn();
            baseManage = new SunVote.BaseManage();
            choices = new SunVote.Choices();
            keypadManage = new KeypadManage();
            election = new SunVote.Election();
            message = new SunVote.Message();
            baseConn = new SunVote.BaseConnection
            {
                // DemoMode = true,
                // DemoKeyIDs = "1", 
                ProtocolType = 2,

            };
            signIn.BaseConnection = baseConn;
            choices.BaseConnection = baseConn;
            keypadManage.BaseConnection = baseConn;
            election.BaseConnection = baseConn;
            message.BaseConnection = baseConn;

            baseConn.BaseOnLine += new SunVote.IBaseConnectionEvents_BaseOnLineEventHandler(baseConn_BaseOnLine);

            signIn.KeyStatus += new SunVote.ISignInEvents_KeyStatusEventHandler(signIn_KeyStatus);
            choices.KeyStatus += new IChoicesEvents_KeyStatusEventHandler(choices_KeyStatus);
            election.KeyStatus += new IElectionEvents_KeyStatusEventHandler(election_KeyStatus);
            election.KeyStatusSN += new IElectionEvents_KeyStatusSNEventHandler(election_KeyStatusSN);
            election.Elector += new IElectionEvents_ElectorEventHandler(election_Elector);

            secondaryWindow = new GraphicControlView();
            secondaryWindow.DataUpdated += SecondaryWindow_DataUpdated;
            secondaryWindow.Show();
        }

        private void election_Elector(string BaseTag, int KeyID, int NameID, string Name)
        {
            string str = string.Format("BaseTag:{0},KeyID:{1},NameID:{2},Name:{3}",
                        BaseTag, KeyID, NameID, Name);
        }

        private void election_KeyStatusSN(string BaseTag, string KeySN, int CommitOK, string KeyValue)
        {
            string str = string.Format("BaseTag:{0},KeySN:{1},CommitOK:{2},KeyValue:{3}",
                BaseTag, KeySN, CommitOK, KeyValue);
        }


        private void election_KeyStatus(string BaseTag, int KeyID, int CommitOK, string KeyValue)
        {
             
        }

        private void choices_KeyStatus(string BaseTag, int KeyID, string KeyValue, double KeyTime)
        { 

        }

        private void signIn_KeyStatus(string BaseTag, int KeyID, int ValueType, string KeyValue)
        {
             
        }


        private void baseConn_BaseOnLine(int BaseID, int BaseState)
        {               
            string sState = "";
            string sMsg = "";
            try
            {
                switch (BaseState)
                {
                    case 0:
                        sState = "¡Conexión a la Base falló o BaseConnection cerrada!";
                        break;
                    case 1:
                        sState = "Conexión correcta a la Base.";
                        break;
                    case -1:
                        sState = "¡Tipo de conexión no soportada!";
                        break;
                    case -2:
                        sState = "¡No se encuentra la Base!";
                        break;
                    case -3:
                        sState = "¡Error de Puerto!";
                        break;
                    case -4:
                        sState = "¡La Baseconnection ha sido cerrada!";
                        break;
                    case -5:
                        sState = "baseConnection.BaseUsedByApp=" + baseConn.BaseUsedByApp;
                        break;
                }

                sMsg = "conexionBase_BaseOnLine:" +
                        "IDBase=" + BaseID + ", EstadoBase=" + BaseState + "  " + sState; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
                 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int baseId = 6;
            try
            { 
                baseManage.BaseConnection = baseConn;
                baseManage.SetEnabledMobileBase(1, true); 
                baseConn.Open(1, baseId.ToString()); 
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo conectar con los mandos");
            }
        }

        private void btnfINIS_Click(object sender, RoutedEventArgs e)
        {
            baseConn.Close();
            keypadManage.RemoteOff(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var series = secondaryWindow.MyChart.Series[0] as PieSeries; // Asegúrate de seleccionar la serie correcta
            var random = new Random();
            double dou = double.Parse(random.Next(12).ToString());
            if (series != null)
            {
                series.Values.Add(dou);
            }
        }

        private void SecondaryWindow_DataUpdated(object sender, DataUpdatedEventArgs e)
        {
            var series = secondaryWindow.MyChart.Series[0] as PieSeries; // Asegúrate de seleccionar la serie correcta
            if (series != null)
            {
                series.Values.Add(e.NewData);
            }

        }
    }
}
