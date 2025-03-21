///Giải pháp là tạo đối tượng mà không cần dùng new Obj

namespace FactoryMethod
{
    public class Solution
    {
        // Interface chung cho các loại thông báo
        public interface INotification
        {
            void Send(string message);
        }

        // Các class cụ thể (Concrete Classes)
        public class EmailNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        public class SMSNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine($"SMS sent: {message}");
            }
        }

        public class PushNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine($"Push Notification sent: {message}");
            }
        }

        // Factory Method - Tạo đối tượng mà không dùng `new`
        public class NotificationFactory
        {
            public static INotification CreateNotification(string type)
            {
                return type switch
                {
                    "email" => new EmailNotification(),
                    "sms" => new SMSNotification(),
                    "push" => new PushNotification(),
                    ///Những cái còn lại
                    _ => throw new ArgumentException("Invalid notification type"),
                };
            }
        }

        public static void Run()
        {
            Console.WriteLine("\n=== Giải pháp dùng Factory Method ===");

            // Tạo đối tượng mà không cần `new`
            INotification email = NotificationFactory.CreateNotification("email");
            INotification sms = NotificationFactory.CreateNotification("sms");
            INotification push = NotificationFactory.CreateNotification("push");

            email.Send("Welcome to Factory Method!");
            sms.Send("You have a new message.");
            push.Send("Your order has been shipped.");
        }
    }
}

