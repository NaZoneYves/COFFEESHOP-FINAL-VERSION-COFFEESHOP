using PROJECT.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PROJECT.Table.PRODUCT;
using PROJECT.Table.PRODUCT.FOOD;

namespace PROJECT
{
    public partial class fManageSell : Form
    {
        public fManageSell()
        {
            InitializeComponent();

            LoadTable();

            //hàm đưa lên info cho Product Category
            LoadProductCategory();
        }
        #region Method
        void LoadTable()
        {
            fnlTable.Controls.Clear();
            List<TableInfoStored> tableList = ProcessTable.Instance.LoadListTable();
            foreach (TableInfoStored item in tableList)
            {
                BunifuThinButton2 btn = new BunifuThinButton2()
                { Width = ProcessTable.TableWidth, Height = ProcessTable.TableHeight };
                btn.ButtonText = item.Name + Environment.NewLine + item.Status;

                //mỗi khi click vào button thì sẽ hiển thị bill của bàn đó
                btn.Click += Btn_Click;
                
                btn.Tag = item; //lưu thông tin của bàn vào trong button

                switch (item.Status)
                {
                    case "Trống":
                        {
                            btn.IdleFillColor = Color.Ivory;
                            break;
                        }
                    default:
                        {
                            btn.IdleFillColor = Color.LightGreen;
                            break;
                        }
                }
                fnlTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id) //id = idBill vừa lấy từ function GetUncheckOutBillByTableID()
        {
            lsvBill.Items.Clear();
            List<OneMenu> listMenu = ProcessMenu.Instance.GetListMenuByTable(id);

            float totalePrice = 0;

            foreach (OneMenu item in listMenu)
            {
                ListViewItem listViewItem = new ListViewItem(item.ProductName.ToString());
                listViewItem.SubItems.Add((item.Price.ToString()));
                listViewItem.SubItems.Add((item.Quantity.ToString()));
                listViewItem.SubItems.Add((item.TotalPrice.ToString()));
                totalePrice += item.TotalPrice; //tính tổng tiền
                lsvBill.Items.Add(listViewItem);
            }
            txbTotalPrice.Text = totalePrice.ToString();

        }

        void LoadProductCategory() //chỉ lấy IDDrinkCate vừa truy vấn được, để đưa vào combobox.text
        {
            // //hàm này sẽ trả về 1 danh sách bao gồm tất cả các thông tin về DrinkCate
            List<ProductCategory> listCategoryID = ProcessProductCategory.Instance.GetListProductCategoryID();
            cbCategory.DataSource = listCategoryID;
            //chỉ hiển thị tên của Category lên cb
            cbCategory.DisplayMember = "IDCategory";
        }

        void LoadProductByCategoryID(string ID) //ID = (IDFoodCate / IDdrinkCate)
        {
            List<ProductInfomation> listProInfo
                = ProcessProductInformation.Instance.GetProductInfoByIDCate(ID);
            cbProduct.DataSource = listProInfo;
            cbProduct.DisplayMember = "NameProduct";
        }

        #endregion  

        #region Event  

        void Btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as BunifuThinButton2).Tag as TableInfoStored).ID; //lấy IDTable tương ứng với button đã chọn
            lsvBill.Tag = (sender as BunifuThinButton2).Tag; //Tag is ??? (1)
            lbTable.Text = ((sender as BunifuThinButton2).Tag as TableInfoStored).Name;
            ShowBill(TableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManageAccount f = new fManageAccount();
            f.ShowDialog();
            this.Show();

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
            this.Show();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID; ;//ID = IDProductCategory (IDDrinkCategory / IDFoodCategory/ ...)

            //lấy ID của Product Category để truyền vào phương thức load thông tin produt
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null) return;

            ProductCategory productCategory = cb.SelectedItem as ProductCategory;
            ID = productCategory.IdCategory;

            LoadProductByCategoryID(ID);
        }
      
        
        #endregion

        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string ID; ;//ID = IDProductCategory (IDDrinkCategory / IDFoodCategory/ ...)

            //lấy ID của Product Category để truyền vào phương thức load thông tin produt
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null) return;

            ProductCategory productCategory = cb.SelectedItem as ProductCategory;
            ID = productCategory.IdCategory;

            LoadProductByCategoryID(ID);
        }

        private void btnPaid_Click_1(object sender, EventArgs e)
        {
            //lấy IDbill từ idtable
            TableInfoStored table = lsvBill.Tag as TableInfoStored;

            int IdBill = ProcessBillOverview.Instance.GetUncheckBillByTableID(table.ID);

            //nếu idbill = -1 thì bill chưa tồn tại
            if (IdBill != -1)
            {
                if (MessageBox.Show("Bạn muốn thanh toán hóa đơn cho " + table.Name, "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                //nếu người dùng nhấn ok thì sẽ thanh toán
                {
                    ProcessBillOverview.Instance.CheckOut(IdBill);
                }
                ShowBill(table.ID);
            }
            LoadTable();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            //lấy table từ tag của lsvBill (lvsBill chứa button, button lại chứ table)
            TableInfoStored table = lsvBill.Tag as TableInfoStored;

            //lấy IdBill hiện tại từ IDtable
            int IdBill = ProcessBillOverview.Instance.GetUncheckBillByTableID(table.ID);
            string idProduct = (cbProduct.SelectedItem as ProductInfomation).IdProduct; //lấy từ combobox
            int quantity = (int)nmCount.Value;

            //TH1: bill chưa tồn tại
            if (IdBill == -1)
            {
                ProcessBillOverview.Instance.InsertBillOverView(table.ID);
                int newIdBill = ProcessBillOverview.Instance.GetMaxIDBillValue();
                ProcessBillDetailInfo.Instance.InsertBillDetailInfo(newIdBill, idProduct, quantity);
                //sau khi p.thức thực hiện -> tạo ra IDBill mới (tự tạo)
                //=> IDBill truyền vào InsertBillDetailInfo sẽ là IDBill có giá trị lớn nhất
                //=> cần thêm 1 p.thức để lấy Max(IDBill)
            }
            else
            {
                ProcessBillDetailInfo.Instance.InsertBillDetailInfo(IdBill, idProduct, quantity);
            }

            //load bill lại ngay lập tức
            ShowBill(table.ID);
            LoadTable();
        }

    }
}
