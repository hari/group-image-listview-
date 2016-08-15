using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set view type to image
            ListViewImg.View = View.LargeIcon;

            //this imagelist was added in designer mode
            ListViewImg.LargeImageList = DesignerImageList;
            int max = DesignerImageList.Images.Count;
            for (int i = 0; i < max; i++)
            {
                //create a group or row
                ListViewGroup grp = new ListViewGroup(string.Format("Group {0}", i + 1));
                ListViewImg.Groups.Add(grp);
                for (int j = 0; j < max; j++)
                {
                    //create listview item with text and image, the second argument(index) is index of image in ImageList i.e DesignerImageList here
                    ListViewItem ImgItem = new ListViewItem(string.Format("Item {0}", j + 1), j);
                    ImgItem.Group = ListViewImg.Groups[i];
                    ListViewImg.Items.Add(ImgItem);
                }
            }
        }

        private void BtnUseDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadImageDialog = new OpenFileDialog();
            if (loadImageDialog.ShowDialog(this) != DialogResult.OK) return;
            ListViewImg.Items.Clear();
            //we are creating it by code, but this can be done visually in visual studio
            //add an instance of imagelist and then from properties add the images in imagelist
            //then finally set the LargeImagelist = yourimagelist
            ImageList ImagesList = new ImageList();
            //these properties can be tweaked using visual studio's designer mode 
            //if you've added it in visual mode
            ImagesList.ImageSize = new Size(64, 64);
            ImagesList.Images.Add(Image.FromFile(loadImageDialog.FileName));

            ListViewImg.Groups.Add(new ListViewGroup("First Row"));
            ListViewImg.Groups.Add(new ListViewGroup("Second Row"));
            ListViewImg.LargeImageList = ImagesList;
            //for group based
            ListViewItem singleItem = new ListViewItem("First", 0);
            singleItem.Group = ListViewImg.Groups[0];
            ListViewImg.Items.Add(singleItem);
            singleItem = new ListViewItem("Second", 0);
            singleItem.Group = ListViewImg.Groups[1];
            ListViewImg.Items.Add(singleItem);
        }
    }
}
