using Assignment.Q2;
using Assignment.Q3;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region testQ1
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();
            #endregion
            #region TestQ2
            IAuthenticationService authService = new BasicAuthenticationService();

            // Test authentication and authorization
            string username = "mahmo";
            string password = "456";
            string roleToCheck = "mnm";

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine($"{username} authenticated.");
                Console.WriteLine(authService.AuthorizeUser(username, roleToCheck)
                    ? $"{username} is authorized as {roleToCheck}."
                    : $"{username} is not authorized as {roleToCheck}.");
            }
            else
            {
                Console.WriteLine($"{username} failed to authenticate.");
            }
     }
        #endregion
        #region TestQ3
        //EmailNotificationService emailService = new EmailNotificationService();
        //INotificationService smsService = new SmsNotificationService();
        //INotificationService pushService = new PushNotificationService();

    
        //string email = "Me1673@fayoum.edu.eg";
        //string sms= "01128305311";
        //string pushRecipient = "mahmoud eid";
        //string message = "Hello test notification!";

      
        //emailService.SendNotification(email, message);
        //smsService.SendNotification(sms, message);
        // pushService.SendNotification(pushRecipient, message);

        #endregion
    }
 }  

