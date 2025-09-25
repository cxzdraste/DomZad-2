

namespace Latypova.AllStruct
{
    struct Students
    {
        public string firstname;
        public string lastname;
        public int id;
        public string birthdayDate;
        public string alcCategory;
        public float vol;

    }
    struct Drinks
    {
        public float vodka;
        public float jackDaniels;
        public float vino;
        public float limonad;

        public Drinks()
        {
            vodka = 0.6f;
            limonad = 0;
            jackDaniels = 0.4f;
            vino = 0.2f;
        }

    }
}
