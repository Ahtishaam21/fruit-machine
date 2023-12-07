namespace fruit_machine
{
    public partial class Form1 : Form
    {
        static Image apple = fruit_machine.Properties.Resources.apple;
        static Image banana = fruit_machine.Properties.Resources.banana;
        static Image cherries = fruit_machine.Properties.Resources.cherries;
        static Image diamond = fruit_machine.Properties.Resources.diamond;
        static Image[] items = { apple, banana, cherries, diamond };
        static Image appleT = fruit_machine.Properties.Resources.appleT;
        static Image appleB = fruit_machine.Properties.Resources.appleB;
        static Image bananaT = fruit_machine.Properties.Resources.bananaT;
        static Image bananaB = fruit_machine.Properties.Resources.bananaB;
        static Image cherriesT = fruit_machine.Properties.Resources.cherriesA;
        static Image cherriesB = fruit_machine.Properties.Resources.cherriesB;
        static Image diamondT = fruit_machine.Properties.Resources.diamondT;
        static Image diamondB = fruit_machine.Properties.Resources.diamondB;
        static Image[] itemsT = { appleT, bananaT, cherriesT, diamondT };
        static Image[] itemsB = { appleB, bananaB, cherriesB, diamondB };
        static bool spin = false;
        static Random rnd = new Random();

        static int pickpointer1 = rnd.Next(6);

        static int pickpointer2 = rnd.Next(6);  //check in case of fail

        static int pickpointer3 = rnd.Next(6);
        static Image slot1hold;
        static Image slot2hold;
        static Image slot3hold;
        public Form1()
        {
            InitializeComponent();
        }


        private void Slot1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pickpointer1++;
            Slot1.BackgroundImage = items[pickpointer1 % items.Length];
            slot1b.BackgroundImage = itemsB[(pickpointer1 + 1) % items.Length];
            slot1t.BackgroundImage = itemsT[(pickpointer1 - 1) % items.Length];
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            if (spin == true) spin = false;
            else spin = true;
            if (spin == true) Start.BackColor = Color.Red;
            else Start.BackColor = Color.Green;
            if (spin) timer1.Start();
            if (!spin) timer1.Stop();
            if (spin) timer3.Start();
            if (!spin) timer3.Stop();
            if (spin) timer4.Start();
            if (!spin) timer4.Stop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pickpointer3++;
            Slot3.BackgroundImage = items[pickpointer3 % items.Length];
            slot3b.BackgroundImage = itemsB[(pickpointer3 + 1) % items.Length];
            slot3t.BackgroundImage = itemsT[(pickpointer3 - 1) % items.Length];

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pickpointer2++;
            Slot2.BackgroundImage = items[pickpointer2 % items.Length];
            slot2b.BackgroundImage = itemsB[(pickpointer2 + 1) % items.Length];
            slot2t.BackgroundImage = itemsT[(pickpointer2 - 1) % items.Length];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            slot1hold = Slot1.BackgroundImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            slot2hold = Slot2.BackgroundImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            slot3hold = Slot3.BackgroundImage;
        }
    }
}