using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 运营巡检规则管理工具.用户界面.基础组件.窗体;

namespace 运营巡检规则管理工具.用户界面.基础组件.窗体
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BaseForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体状态
        /// </summary>
        public enum FormStatus
        {
            /// <summary>
            /// 正常
            /// </summary>
            Normal,

            /// <summary>
            /// 添加
            /// </summary>
            Add,

            /// <summary>
            /// 修改
            /// </summary>
            Modify,

            /// <summary>
            /// 查看
            /// </summary>
            View
        }

        /// <summary>
        /// 状态
        /// </summary>
        [DefaultValue(FormStatus.Normal)]
        [Localizable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [RefreshProperties(RefreshProperties.All)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("窗体状态")]
        public FormStatus Status { get; set; }
       

        private void buttonExist_Click(object sender, EventArgs e)
        {
            Exist();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Save();
        }


        #region 公共方法

        /// <summary>
        /// 退出
        /// </summary>
        public virtual void Exist()
        {
            this.Close();
        }

        /// <summary>
        /// 保存
        /// </summary>
        public virtual void Save()
        {
            MessageBox.Show(@"保存成功！");
        }

        #endregion
    }
}

static class FormHelper
{
    static Dictionary<BaseForm.FormStatus,string> _formTitle = new Dictionary<BaseForm.FormStatus, string>()
    {
        {BaseForm.FormStatus.Normal,string.Empty},
        {BaseForm.FormStatus.Add,"新增"},
        {BaseForm.FormStatus.Modify,"编辑"},
        {BaseForm.FormStatus.View,"查看"},
    };

    /// <summary>
    /// 显示
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string ShowText(string text) => $@"{text?? "状态"}";
}
