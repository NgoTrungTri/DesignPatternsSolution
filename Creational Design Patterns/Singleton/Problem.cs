/// Vấn đề khi chưa có Singleton là khi ta tạo class Database để giả lập kết nối cơ sỡ dữ liệu
/// Khi gọi new đối tượng sẽ tạo ra đối tượng mới
/// Điều này có thể không tốt vì khó quản lý và tốn tài nguyên
/// Thay vì thế ta chỉ nên tạo đúng 1 đối tượng duy nhất trong

namespace Singleton
{
    public class Problem
    {
        public class Database
        {
            public Database()
            {
                Console.WriteLine("Kết nối đến database...");
            }
        }

        public static void Run()
        {
            var db1 = new Database();
            var db2 = new Database();
        }
    }
}
