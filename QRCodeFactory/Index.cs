using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QRCodeFactory
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void txt_codes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txt_path.Text = path.SelectedPath;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            var path = this.txt_path.Text;
            var excelPath = this.txt_excelPath.Text;
            var codes = this.txt_codes.Text;
            if (string.IsNullOrWhiteSpace(path)) {
                this.lab_alert.Text = "请指定二维码生成的目标地址";
                return;
            }
            if (string.IsNullOrWhiteSpace(codes) && string.IsNullOrWhiteSpace(excelPath))
            {
                this.lab_alert.Text = "请将要生成的内容填在上方的文本域或者上传excel";
                return;
            }
            var ret = false;
            if (!string.IsNullOrWhiteSpace(codes)) {
                //执行生成操作
                ret = QrCodeFactory.GenerateCoder(codes, path);
            }else
            {
                //根据excel执行生成操作
                var data = ExcelHelper.ExcelImport(excelPath);
                var codeList = (from r in data.AsEnumerable()
                                select r.Field<string>("code")).ToList<string>();
                ret = QrCodeFactory.GenerateCoder(codeList, path);
            }
            if (ret)
                this.lab_alert.Text = "全部操作成功";
            else
                this.lab_alert.Text = "本次生成失败，请检查输入的code是否符合要求";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*xls*)|*.xls*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_excelPath.Text = fileDialog.FileName;//返回文件的完整路径                
            }
        }
    }
}
