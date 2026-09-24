namespace GUI26092402;

#nullable disable

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();

        lblCornflowerBlue.Click += LblColoring_Click;
        lblGold.Click += LblColoring_Click;
        lblHotPink.Click += LblColoring_Click;
        lblSpringGreen.Click += LblColoring_Click;

        btnExit.Click += BtnExit_Click;
        btnReset.Click += BtnReset_Click;
    }

    private void BtnReset_Click(object sender, EventArgs e) =>
        this.BackColor = Color.White;

    private void BtnExit_Click(object sender, EventArgs e) => 
        Application.Exit();

    private void LblColoring_Click(object sender, EventArgs e) =>
        this.BackColor = (sender as Label).BackColor;
}
