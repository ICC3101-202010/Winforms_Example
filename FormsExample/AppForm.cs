using FormsExample.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExample
{
    public partial class AppForm : Form
    {
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;


        //Organizacion
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public AppForm()
        {
            InitializeComponent();
            panels.Add("LoginPanel", LoginView);
            panels.Add("ProfilePanel", profileView);
            stackPanels.Add(panels["LoginPanel"]);
            ShowLastPanel();
        }

        private void loginViewButton_Click(object sender, EventArgs e)
        {
            string username = loginViewUserInput.Text;
            string pass = loginViewPassWordInput.Text;
            OnLoginButtonClicked(username, pass);
        }

        private void profileViewLogOutButton_Click(object sender, EventArgs e)
        {
            profileViewUserText.ResetText();
            profileViewNameText.ResetText();
            profileViewAgeText.ResetText();
            stackPanels.RemoveAt(stackPanels.Count - 1);
            ShowLastPanel();
        }

        //Metodos Internos
        private void OnLoginButtonClicked(string username, string pass)
        {
            if (LoginButtonClicked != null)
            {
                bool result = LoginButtonClicked(this, new LoginEventArgs() { UsernameText = username, PasswordText = pass});
                if (!result)
                {
                    loginViewInvalidCredentialsAlert.Text = "Credenciales invalidas";
                    loginViewInvalidCredentialsAlert.Visible = true;
                }
                else
                {
                    loginViewInvalidCredentialsAlert.ResetText();
                    loginViewInvalidCredentialsAlert.Visible = false;
                    OnUserChecked(username);
                }
            }
        }

        private void OnUserChecked(string username)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username });
                loginViewUserInput.ResetText();
                loginViewPassWordInput.ResetText();
                stackPanels.Add(panels["ProfilePanel"]);
                ShowLastPanel();
            }
        }


        public void setProfile(string username, string name, int age)
        {
            profileViewUserText.Text = username;
            profileViewNameText.Text = name;
            profileViewAgeText.Text = age.ToString();
        }

        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }

        
    }
}
