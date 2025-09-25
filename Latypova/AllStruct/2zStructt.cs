
namespace Latypova.AllStruct
{
    struct Person
    {
        public string name;
        public int age;
        public string city;
        public int pincode;
        public void Print()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}\nГород: {city}\nPIN-код: {pincode}");
        }


    }
}
