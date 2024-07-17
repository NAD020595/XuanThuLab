using CS021_Asynchronous;

// DownloadWebsite01.TestDownloadWebpage();

Console.WriteLine($"{' ',5} {Thread.CurrentThread.ManagedThreadId,3} MainThread");
Task<string> t1 = TestAsync01.Async1("A", "B");
Task t2 = TestAsync01.Async2();

Console.WriteLine("Làm gì đó ở thread chính sau khi 2 task chạy");

// Chờ t1 kết thúc và đọc kết quả trả về
t1.Wait();
String s = t1.Result;
TestAsync01.WriteLine(s, ConsoleColor.Red);

// Ngăn không cho thread chính kết thúc
// Nếu thread chính kết thúc mà t2 đang chạy nó sẽ bị ngắt
Console.ReadKey();