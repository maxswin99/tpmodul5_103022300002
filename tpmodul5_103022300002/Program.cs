class HaloGeneric
{
    public void SapaUser<T>(T data)
    {
        Console.WriteLine("Halo " + data);
    }
}
class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Aloy");
        halo.SapaUser("Atong");

        DataGeneric<string> dataNim = new DataGeneric<string>("103022300003");
        dataNim.PrintData();

        DataGeneric<long> dataNimInt = new DataGeneric<long>(103022300090);
        dataNimInt.PrintData();
    }
}