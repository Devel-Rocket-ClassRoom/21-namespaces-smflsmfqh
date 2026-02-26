using System;
using casual = Casual.Message;
using formal = Formal.Message;

Console.WriteLine("=== 인사 테스트 ===");
Console.WriteLine("[격식체]");
formal.SayHello("홍길동");
formal.SayBye("홍길동");
Console.WriteLine();
Console.WriteLine("[비격식체]");
casual.SayHello("철수");
casual.SayBye("철수");
