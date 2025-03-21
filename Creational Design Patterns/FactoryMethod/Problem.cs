/// Vấn đề khi chưa có FactoryMethod là khi tạo các class cần phải new chính đối tượng đó
/// Khi đó sẽ cần phải biết chính xác class để tạo, dẫn đến khó tiếp cận 
/// Khi thêm loại mới ta cần phải thêm ở tất cả các chổ dẫn đến việc khó mở rộng
/// Lặp lại code rất nhiều

namespace FactoryMethod
{
    public class Problem
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

        public static void Run()
        {
            Console.WriteLine("=== Vấn đề khi không dùng Factory Method ===");

            // Tạo các đối tượng trực tiếp bằng `new`
            INotification email = new EmailNotification();
            INotification sms = new SMSNotification();
            INotification push = new PushNotification();

            email.Send("Welcome to Factory Method!");
            sms.Send("You have a new message.");
            push.Send("Your order has been shipped.");

            ///Khi thêm cái mới phải sửa trực tiếp vào đây và các nơi khác 
            ///Ví dụ
            ///INotification yahoo = new EmailNotification();
            ///yahoo.Send("New Yahoo");
        }
    }
}
