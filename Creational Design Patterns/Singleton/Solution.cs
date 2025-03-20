/// Giải pháp là sử dụng tĩnh để chỉ tạo 1 đối tượng duy nhất
/// Construtor để phạm vi truy cập là private để chặn tạo đối tượng ở bên ngoài

namespace Singleton
{
    public class Solution
    {
        public class Database
        {
            private static Database? _instance;
            private static readonly object _lock = new();

            private Database()
            {
                Console.WriteLine("Kết nối đến database (chỉ một lần)...");
            }

            public static Database Instance
            {
                get
                {
                    lock (_lock)
                    {
                        return _instance ??= new Database();
                    }
                }
            }
        }

        public static void Run()
        {
            var db1 = Database.Instance;
            var db2 = Database.Instance;

            ///Kiểm tra xem hai ref có giống nhau không (cùng trỏ tới 1 địa chỉ)
            if (ReferenceEquals(db1, db2))
            {
                Console.WriteLine("Cả hai biến đều trỏ đến cùng một instance.");
            }
        }
    }
}
