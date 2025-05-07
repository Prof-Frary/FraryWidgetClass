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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // no error checking
            Widget w = new Widget(txtName.Text, 
                cboSize.Text,
                cboColor.Text,
                double.Parse(txtPrice.Text));
            lstOut.Items.Add(w);
            lstOut.Items.Add(w.WidgetName);
            lstOut.Items.Add(w.WidgetColor);
            lstOut.Items.Add(w.WidgetSize);
            lstOut.Items.Add(w.WidgetPrice);
        }
    }
}
