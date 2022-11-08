namespace MelonToggler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (Directory.Exists(@".\MelonLoaderDisabled"))
                {
                    Directory.Move(@".\MelonLoaderDisabled", @".\MelonLoader");
                };
                if (Directory.Exists(@".\ModsDisabled"))
                {
                    Directory.Move(@".\ModsDisabled", @".\Mods");
                };
            }

            if (!checkBox1.Checked)
            {
                if (Directory.Exists(@".\MelonLoader"))
                {
                    Directory.Move(@".\MelonLoader", @".\MelonLoaderDisabled");
                };
                if (Directory.Exists(@".\Mods"))
                {
                    Directory.Move(@".\Mods", @".\ModsDisabled");
                };
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}