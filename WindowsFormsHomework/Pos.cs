using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Pos : MyForm
    {
        private readonly Menu wine, Tequila, whisky, beer;

        private string wineShow = "", tequilaShow, whiskyShow, beerShow;
        private readonly string caption = "確認付款";

        public Pos()
        {
            InitializeComponent();
            wine = new Menu(0, 320);
            Tequila = new Menu(0, 180);
            whisky = new Menu(0, 350);
            beer = new Menu(0, 120);
        }

        private void wineButton_Click(object sender, EventArgs e)
        {
            wine.count++;
            wine.price = wine.count * wine.unitprice;
            wineShow = "紅酒x" + wine.count + "," + "共NT$" + wine.price + "元" + "\n";
            listLabel.Text = wineShow + tequilaShow + whiskyShow + beerShow;
        }

        private void tequilaButton_Click(object sender, EventArgs e)
        {
            Tequila.count++;
            Tequila.price = Tequila.count * Tequila.unitprice;
            tequilaShow = "龍舌蘭x" + Tequila.count + "," + "共NT$" + Tequila.price + "元" + "\n";
            listLabel.Text = wineShow + tequilaShow + whiskyShow + beerShow;
        }

        private void whisyButton_Click(object sender, EventArgs e)
        {
            whisky.count++;
            whisky.price = whisky.count * whisky.unitprice;
            whiskyShow = "威士忌x" + whisky.count + "," + "共NT$" + whisky.price + "元" + "\n";

            listLabel.Text = wineShow + tequilaShow + whiskyShow + beerShow;
        }

        private void beerButton_Click(object sender, EventArgs e)
        {
            beer.count++;
            beer.price = beer.count * beer.unitprice;
            beerShow = "啤酒x" + beer.count + "," + "共NT$" + beer.price + "元";

            listLabel.Text = wineShow + tequilaShow + whiskyShow + beerShow;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listLabel.Text = "尚未點餐";
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            if (listLabel.Text != "尚未點餐")
            {
                string total = wine.price + Tequila.price + whisky.price + beer.price + "元";
                MessageBox.Show(total, caption, MessageBoxButtons.OKCancel);
            }
            else MessageBox.Show("尚未點餐", caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            if (listLabel.Text != "尚未點餐")
            {
                string total = (wine.price + Tequila.price + whisky.price + beer.price) * 0.9 + "元";
                MessageBox.Show(total, caption, MessageBoxButtons.OKCancel);
            }
            else MessageBox.Show("尚未點餐", caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }

    public class Menu
    {
        public int count;
        public int unitprice;
        public int price;

        public Menu(int count, int unitprice)
        {
            this.count = count;
            this.unitprice = unitprice;
        }
    }
}
