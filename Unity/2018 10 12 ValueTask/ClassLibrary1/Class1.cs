using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static ValueTask M1() => new ValueTask(Task.Delay(1));
        public static async ValueTask M2() => await Task.Delay(1);
        public static ValueTask<object> M3() => new ValueTask<object>(Task.Delay(1).ContinueWith(_ => default(object)));
        public static async ValueTask<object> M4() { await Task.Delay(1); return null; }
        public static Task M5() => M1().AsTask();
        public static async Task M6() => await M2();
    }
}
