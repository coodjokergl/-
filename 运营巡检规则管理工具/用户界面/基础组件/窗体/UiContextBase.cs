using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 运营巡检规则管理工具.用户界面.基础组件.窗体
{
    /// <summary>
    /// 上下文
    /// </summary>
    public abstract class UiContextBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="control"></param>
        /// <param name="parentContextBase"></param>
        protected  UiContextBase(Control control,UiContextBase parentContextBase)
        {
            ControlInstance = control;
            ParentContext = parentContextBase;
        }

        /// <summary>
        /// 前次Ui上下文
        /// </summary>
        public UiContextBase ParentContext { get;  }

        /// <summary>
        /// Ui实例
        /// </summary>
        public Control ControlInstance { get; }
    }
}
