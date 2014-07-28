using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace LFT_Win_Phone_App
{
    public partial class Registration : PhoneApplicationPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnPledge_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();

            emailComposeTask.Subject = "LFT Pledge via " + tb6.ToString() + ", " + tb5.ToString();
            emailComposeTask.Body = "Hello " + tb1.ToString()
                +",\nYou just took a Pledge to stand in favour of Anti-Drug and Anti-Ragging Campaigns. You can also become a member of LFT by paying the annual fee of Rs.50 only."
                + "We welcome you in the ever expanding family of Leaders For Tomorrow. Your details as per our records are: "
                + "\nName: "
                + tb1.ToString()
                + "\nEmail: "
                + tb2.ToString()
                + "\nPhone No.: "
                + tb3.ToString()
                + "\nCourse/Year: "
                + tb4.ToString()
                + "\nCollege: "
                + tb5.ToString()
                + "\n\n"
                + "To DOWNLOAD OUR ANDROID APP from Google PlayStore: \nClick the following link https://play.google.com/store/apps/details?id=io.github.stupidamigo.lftadarcampaign"
                + "\n\nFollow us on Facebook: www.facebook.com/LeadersForTomorrow to stay tuned to our events."
                + "\nYou can contact us at president.lft@gmail.com in case of any query. We would love to help you!"
                + "\n\nAnd again, Thanks for becoming a part of ADAR, our awareness campaign, to eradicate the twin menaces of ragging and substance abuse."
                + "\nTake up our 30 days of goodness campaign and spread the goodness around you by doing one good deed a day and spreading the message through facebook. Register with us at http://tinyurl.com/30daysofgoodness and post the good deeds you do with #leadersfortomorrow #30daysofgoodness #gooddeed(no.) on Facebook\n";

            emailComposeTask.To = tb2.ToString();
            //emailComposeTask.Cc = "cc@example.com";
            emailComposeTask.Bcc = "coreteam.lft1@gmail.com";

            emailComposeTask.Show();
        }

        private void btnMember_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();

            emailComposeTask.Subject = "LFT Member via " + tb6.ToString() + ", "+ tb5.ToString();
            emailComposeTask.Body = "Hello " + tb1.ToString()
                + ",\nYou just became a member of LFT by paying the annual fee of Rs.50 only."
                + "We welcome you in the ever expanding family of Leaders For Tomorrow. Your details as per our records are: "
                + "\nName: "
                + tb1.ToString()
                + "\nEmail: "
                + tb2.ToString()
                + "\nPhone No.: "
                + tb3.ToString()
                + "\nCourse/Year: "
                + tb4.ToString()
                + "\nCollege: "
                + tb5.ToString()
                + "\n\n"
                + "To DOWNLOAD OUR ANDROID APP from Google PlayStore: \nClick the following link https://play.google.com/store/apps/details?id=io.github.stupidamigo.lftadarcampaign"
                + "\n\nFollow us on Facebook: www.facebook.com/LeadersForTomorrow to stay tuned to our events."
                + "\nYou can contact us at president.lft@gmail.com in case of any query. We would love to help you!"
                + "\n\nAnd again, Thanks for becoming a part of ADAR, our awareness campaign, to eradicate the twin menaces of ragging and substance abuse."
                + "\nTake up our 30 days of goodness campaign and spread the goodness around you by doing one good deed a day and spreading the message through facebook. Register with us at http://tinyurl.com/30daysofgoodness and post the good deeds you do with #leadersfortomorrow #30daysofgoodness #gooddeed(no.) on Facebook\n";

            emailComposeTask.To = tb2.ToString();
            //emailComposeTask.Cc = "cc@example.com";
            emailComposeTask.Bcc = "coreteam.lft@gmail.com";

            emailComposeTask.Show();
        }
    }
}