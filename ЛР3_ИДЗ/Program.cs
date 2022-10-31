using LIB;
namespace ЛР3_ИДЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(2, 2);
            Matrix.PrintMatrix(matrix);
            Console.WriteLine(Matrix.GetSrArif(matrix));
            Console.WriteLine();
            Matrix.PrintResultMatrix(matrix);
        }
    }
}