using Tymakov;
using Tumakovvvv;
using Tymakov.AllEnum;
using Tymakov.AllStruct;

namespace Tumakov
{
    class Programm
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("#1");
            Bankk ts = Bankk.tekuchSch;
            Bankk ss = Bankk.sberSch;
            Console.WriteLine($"текущий счёт: {ts}\nсберегательный счёт: {ss}");

            //2
            Console.WriteLine("#2");
            Bank account;
            account.numSch = 1234;
            account.typeOfCount = "сберегательный счёт";
            account.balance= 77777;
            Console.WriteLine($"Номер счёта: {account.numSch}\nТип счёта: {account.typeOfCount}\nБаланс: {account.balance}");

            //3
            Console.WriteLine("#3");
            Worker worker;
            worker.name = "Игорь";
            worker.VuzName = Vuz.KAI;
            Console.WriteLine($"Имя работника: {worker.name}\nНазвание Вуза: {worker.VuzName}");




        }

    }
}