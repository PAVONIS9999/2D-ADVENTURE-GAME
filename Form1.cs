using System.Drawing.Text;

namespace _2D_ADVENTURE_GAME
{
    public partial class Form1 : Form
    {
        private GameEngine gameengine;

        public Form1()
        {
           
            gameengine = new GameEngine(10);
            InitializeComponent();
            UpdateDisplays();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        
        public void UpdateDisplays() // assigns game engine to sting method to the level text
        {
            labelDisplay.Text = gameengine.ToString();
        }

    }
}
