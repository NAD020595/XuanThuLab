using CS021_Asynchronous;

// DownloadWebsite01.TestDownloadWebpage();

// ---------------------------------------------------------------------------------- //

// Console.WriteLine($"{' ',5} {Thread.CurrentThread.ManagedThreadId,3} MainThread");
// Task<string> t1 = TestAsync01.Async1("A", "B");
// Task t2 = TestAsync01.Async2();

// Console.WriteLine("Làm gì đó ở thread chính sau khi 2 task chạy");

// // Chờ t1 kết thúc và đọc kết quả trả về
// t1.Wait();
// String s = t1.Result;
// TestAsync01.WriteLine(s, ConsoleColor.Red);

// // Ngăn không cho thread chính kết thúc
// // Nếu thread chính kết thúc mà t2 đang chạy nó sẽ bị ngắt
// Console.ReadKey();

// ---------------------------------------------------------------------------------- //

// var t1 = TestAsyncAwait.Async1("x", "y");
// var t2 = TestAsyncAwait.Async2();

// // Làm gì đó khi t1, t2 đang chạy
// Console.WriteLine("Task1, Task2 đang chạy");


// await t1; // chờ t1 kết thúc
// Console.WriteLine("Làm gì đó khi t1 kết thúc");

// await t2; // chờ t2 kết thúc

// ---------------------------------------------------------------------------------- //

// string url = "https://github.com/microsoft/vscode/archive/1.48.0.tar.gz";
// var taskdonload = DownloadAsync.DownloadFile(url);
// //..
// Console.WriteLine("Làm gì đó khi file đang tải");
// //..
// await taskdonload;
// Console.WriteLine("Làm gì đó khi file tải xong");

// ---------------------------------------------------------------------------------- //

CancellationTokenTest.Test();