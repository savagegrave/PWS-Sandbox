using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PWS_Sandbox;
namespace PWS_Sandbox.ViewModels
{
    class PWS_Sandbox : INotifyPropertyChanged
        
    {
        #region property changed
        
        /*
         * Now this bit of code, I learnt from James Montemagno, a developer for Microsoft.
         * The link can be found in the readme.txt files.
         * 
         * This region will allow the view to update each time values in the data bindings change.  Its pretty cool!
         */

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        // Declare Some Variables.

        #region Variables

        /// <summary>
        /// Username = Variable to hold the user's name.
        /// </summary>
        private string username = "Steven Houldey";
        /// <summary>
        /// Emailaddress = User's Email Address.
        /// </summary>
        private string emailaddress = "Hi";
        
        /// <summary>
        /// Set Busy Indicator
        /// </summary>
        private bool imbusy = false;

        #endregion

        #region Getters and Setters.
        // Getters and Setters
        // ( I know this can be done in one line, but its easier to visualise)

        /// <summary>
        /// Set the return and set values as required. 
        /// </summary>
        public string UserName
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
                OnPropertyChanged();
            }
        }
            
        public string EmailAddress
        {
            get
            {
                return emailaddress;
            }

            set
            {
                emailaddress = value;
                OnPropertyChanged();
            }
        }

        public string MessageToUser
        {
            get
            {
                return $"Hello {username} How are you today? Your Email Is: {emailaddress}";
            }
       
        }

        public bool ImBusy
        {
            get { return imbusy; }
            set { 
                imbusy = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
