using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFVotingManager.Actions;
using WPFVotingManager.Model;

namespace WPFVotingManager.View
{
    /// <summary>
    /// Lógica de interacción para ConfigControlView.xaml
    /// </summary>
    public partial class ConfigControlView : Page
    {
        ConfigActions configActions = new ConfigActions();

        public ConfigControlView()
        {
            InitializeComponent();
        }

        private void btnCloseWindow(object sender, RoutedEventArgs e)
        {
            var frame = this.NavigationService.Content as Frame;
            if (frame != null)
            {
                frame.Content = null;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var model = configActions.SaveDocumentParticipant(new Config()
            {
                Id = (lblId.Text != "") ? ObjectId.Parse(lblId.Text) : new ObjectId(),
                StationBase = int.Parse(txtStationBase.Text),
                QuestionGeneral = new VotingManager_Entities.Entities.QuestionGeneral()
                {
                    Decimal = int.Parse(txtDecimal.Value.ToString()),
                    Format = cboTypeFormat.SelectedIndex,
                    ModeVisualization = cboGraphicView.SelectedIndex,
                    TextAnswer = chckAnswerGraphic.Checked,
                    TypeAuthorization = cboTypeAuthorization.SelectedIndex,
                    TypeCalculate = cboCalculateOn.SelectedIndex,
                    TypeGraphic = cboTypeGraphic.SelectedIndex,
                    TypeQuestion = cboTypeQuestion.SelectedIndex,
                    TypeIdentitifyVote = (rdIdentity.Checked) ? 1 : 2,
                    IsSecret = cboTypeDiscret.SelectedIndex,
                    TypeResult = cboTypeResult.SelectedIndex,
                    TypeVote = cboTypeVote.SelectedIndex,
                    TypeWeight = cboTypeWeight.SelectedIndex
                }
            });


            if (model)
            {
                MessageBox.Show("La configuración fue guardada correctamente");
            }
            else
            {
                MessageBox.Show("La configuración no se pudo guardar");

            }
        }
    }
}
