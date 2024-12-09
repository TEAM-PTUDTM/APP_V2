using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using BLL;
using component;
using DTO;

namespace GUI.ProductGUI
{
    public partial class FormProductDetail : Form
    {
        ProductBLL Product_BLL = new ProductBLL();
        CategoryBLL Category_BLL = new CategoryBLL();
        ProductImageBLL ProductImage_BLL = new ProductImageBLL();
        private int _MaSP;
        private string imagePath;
        public FormProductDetail(int MaSP)
        {
            InitializeComponent();
            _MaSP = MaSP;
            ShowImageProduct();
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            btn_create.Enabled = false;
        }

        private  void ShowImageProduct()
        {

            Panel_Image.Controls.Clear();

            List<hinhanh> ListImage = ProductImage_BLL.getImageByMaSP(_MaSP);

            int xOffset = 0; // Vị trí hiện tại theo chiều ngang
            int yOffset = 0; // Vị trí hiện tại theo chiều dọc
            int itemWidth = 111; // Chiều rộng UC
            int itemHeight = 133;// Chiều cao UC
            int spacing = 2; // khoảng cách 


            Panel_Image.AutoScroll = true;

            foreach (var img in ListImage)
            {
                UC_Image imageItem = new UC_Image()
                {
                    MaHinhAnh = img.MaHinhAnh,
                    UrlImage = img.hinhanh1,
                };

                imageItem.ImageDeleted += ShowImageProduct;

                if (xOffset + itemWidth > Panel_Image.Width)
                {
                    xOffset = 0; 
                    yOffset += itemHeight + spacing;
                }

                imageItem.Location = new System.Drawing.Point(xOffset, yOffset);

                xOffset += itemWidth + spacing;

                Panel_Image.Controls.Add(imageItem);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            // Configure Cloudinary
            Account account = new Account(
                "dkcizqsb3", // Cloud name
                "949665292283997", // API Key
                "YiDW4WfWgWa9GiY_gtpp95DQwvo" // API Secret
            );
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);

            // Upload the image to Cloudinary
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imagePath)
            };
            var uploadResult = cloudinary.Upload(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string imageUrl = uploadResult.SecureUrl.ToString();


                hinhanh product = new hinhanh
                {
                    MaSp = _MaSP,
                    hinhanh1 = imageUrl,
                };

                ProductImage_BLL.addImageProduct(product);

                imagePath = null;
                btn_create.Visible = false;

                MessageBox.Show("Image uploaded successfully and URL saved to the database.");
                ShowImageProduct();
            }
            else
            {
                MessageBox.Show("Failed to upload image to Cloudinary.");
            }
        }

        private void Panel_Image_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;

                    pictureBox1.Image = Image.FromFile(imagePath);

                    btn_create.Enabled = true;
                }
            }
        }
    }
}
