internal class Program
{
    private static void Main(string[] args)
    {
        // //Thực hành hiển thị thời gian hệ thống
        // DateTime dateTime = DateTime.Now;
        // System.Console.WriteLine(dateTime);

        // //Thực hành sử dụng toán tử
        // float width;
        // float height;
        // Console.Write("Enter width: ");
        // width = float.Parse(Console.ReadLine());
        // Console.Write("Enter height: ");
        // height = float.Parse(Console.ReadLine());
        // float area = width * height;
        // Console.WriteLine("Area is: " + area);

        // //Bài tập hiển thị lời chào
        // System.Console.WriteLine("Enter your name: ");
        // string yourName = Console.ReadLine();
        // Console.WriteLine("Hello: " + yourName);

        // //Bài tập chuyển đổi tiền tệ
        // double vnd = 23000;
        // double usd;
        // System.Console.Write("Enter USD: ");
        // double result = (usd = double.Parse(Console.ReadLine())) * vnd;
        // System.Console.WriteLine(usd + " USD after convert in to VND is: " + result);

        // //Thực hành giải phương trình bậc nhất
        // Console.WriteLine("Linear Equation Resolver");
        // Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
        // Console.Write("a: ");
        // double a = Convert.ToDouble(Console.ReadLine());
        // Console.Write("b: ");
        // double b = Convert.ToDouble(Console.ReadLine());
        // if (a != 0)
        // {
        //     double solution = -b / a;
        //     Console.Write("The solution is: {0}!", solution);
        // }
        // else
        // {
        //     if (b == 0)
        //     {
        //         Console.Write("The solution is all x!");
        //     }
        //     else
        //     {
        //         Console.Write("Nod solution!");
        //     }
        // }

        // //Thực hành tính chỉ số cân nặng
        // double heightBody;
        // double weightBody;
        // Console.WriteLine("Please enter a height");
        // height = float.Parse(Console.ReadLine());
        // Console.WriteLine("Please enter your weight");
        // weightBody = float.Parse(Console.ReadLine());
        // double bmi = weightBody / Math.Pow(height, 2);
        // bmi = Math.Round(bmi, 1);
        // Console.Write("BMI: " + bmi);
        // if (bmi < 18)
        //     Console.WriteLine(" Underweight");
        // else if (bmi < 25.0)
        //     Console.WriteLine(" Normal");
        // else if (bmi < 30.0)
        //     Console.WriteLine(" Overweight");
        // else
        //     Console.WriteLine(" Obese");

        //Bài tập đọc số thành chữ
        System.Console.WriteLine("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber <= 10)
        {
            switch (inputNumber)
            {
                case 0:
                    System.Console.WriteLine("Zero");
                    break;
                case 1:
                    System.Console.WriteLine("One");
                    break;
                case 2:
                    System.Console.WriteLine("Two");
                    break;
                case 3:
                    System.Console.WriteLine("Three");
                    break;
                case 4:
                    System.Console.WriteLine("Four");
                    break;
                case 5:
                    System.Console.WriteLine("Five");
                    break;
                case 6:
                    System.Console.WriteLine("Six");
                    break;
                case 7:
                    System.Console.WriteLine("Seven");
                    break;
                case 8:
                    System.Console.WriteLine("Eight");
                    break;
                case 9:
                    System.Console.WriteLine("Nine");
                    break;
                case 10:
                    System.Console.WriteLine("Ten");
                    break;
                default:
                    break;
            }
        }
        else if (inputNumber > 10 && inputNumber <= 20)
        {
            switch (inputNumber)
            {
                case 11:
                    System.Console.WriteLine("Eleven");
                    break;
                case 12:
                    System.Console.WriteLine("Twelve");
                    break;
                case 13:
                    System.Console.WriteLine("Thirdteen");
                    break;
                case 14:
                    System.Console.WriteLine("Fourteen");
                    break;
                case 15:
                    System.Console.WriteLine("Fiveteen");
                    break;
                case 16:
                    System.Console.WriteLine("Sixteen");
                    break;
                case 17:
                    System.Console.WriteLine("Seventeen");
                    break;
                case 18:
                    System.Console.WriteLine("Eighteen");
                    break;
                case 19:
                    System.Console.WriteLine("Nineteen");
                    break;
                case 20:
                    System.Console.WriteLine("Twelvety");
                    break;
                default:
                    break;
            }
        }
        else if (inputNumber > 20)
        {
            int inputNumber1 = (int)inputNumber / 10;
            int inputNumber2 = (int)inputNumber % 10;
            switch (inputNumber1)
            {
                case 2:
                    System.Console.WriteLine("Two");
                    break;
                case 3:
                    System.Console.WriteLine("Three");
                    break;
                case 4:
                    System.Console.WriteLine("Four");
                    break;
                case 5:
                    System.Console.WriteLine("Five");
                    break;
                case 6:
                    System.Console.WriteLine("Six");
                    break;
                case 7:
                    System.Console.WriteLine("Seven");
                    break;
                case 8:
                    System.Console.WriteLine("Eight");
                    break;
                case 9:
                    System.Console.WriteLine("Nine");
                    break;
                default:
                    break;
            }
            System.Console.Write(" and ");
            switch (inputNumber2)
            {
                case 0:
                    System.Console.Write("Zero");
                    break;
                case 1:
                    System.Console.Write("One");
                    break;
                case 2:
                    System.Console.Write("Two");
                    break;
                case 3:
                    System.Console.Write("Three");
                    break;
                case 4:
                    System.Console.Write("Four");
                    break;
                case 5:
                    System.Console.Write("Five");
                    break;
                case 6:
                    System.Console.Write("Six");
                    break;
                case 7:
                    System.Console.Write("Seven");
                    break;
                case 8:
                    System.Console.Write("Eight");
                    break;
                case 9:
                    System.Console.Write("Nine");
                    break;
                default:
                    break;
            }
        }
    }
}