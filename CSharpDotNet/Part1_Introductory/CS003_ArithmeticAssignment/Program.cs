// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Phép cộng +, phép trừ -
int a = 28;
int b = 10;

Console.WriteLine(a + b);  // In ra: 38
Console.WriteLine(a - b);  // In ra: 18

// Phép nhân *
float a = 1.2f;
int b = 3;
Console.WriteLine(a * b);  // In ra 3.6

// Phép chia /
float a = 1.2f;
int b = 3;
Console.WriteLine(a / b);  // In ra 0.4

// Nếu số chia và số bị chia thì phép toán / sẽ lấy phần nguyên. Nếu muốn lấy giá trị thực chính xác, cần chuyển số chia, hoặc bị chia thành số thực.
int a = 10;
int b = 3;
Console.WriteLine(a / b);          // In ra 3

// Chuyển số chia thành số thực
Console.WriteLine(a / (float)b);   // In ra 3.333333

// Phép chia lấy dư %
int a = 8;
int b = 3;
Console.WriteLine(a % b);  // In ra 2

// Độ ưu tiên từ cao xuống thấp là: 1 trong ngoặc (), 2 số mũ - căn, 3 nhân hoặc chia * /, 4 cộng hoặc trừ + -
// Khi độ ưu tiên ngang nhau, sẽ tính từ trái qua phải

Console.WriteLine(5 + 3 * 2);         // 11
Console.WriteLine(6 / 2 + 3 * 2);     // 9
Console.WriteLine(6 / (2 + 3) * 2);   // 2

