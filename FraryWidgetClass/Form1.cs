namespace FraryWidgetClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Blue");
            cboColor.Items.Add("Green");
            cboColor.Items.Add("Black");
            cboColor.Items.Add("White");
            cboColor.Text = "Blue";
            cboSize.Items.Add(Widget.SMALL);
            cboSize.Items.Add(Widget.MEDIUM);
            cboSize.Items.Add(Widget.LARGE);
            cboSize.Text = Widget.MEDIUM;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
