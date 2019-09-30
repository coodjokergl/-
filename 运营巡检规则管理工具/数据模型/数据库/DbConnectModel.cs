using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运营巡检规则管理工具.数据模型.数据库
{
    /// <summary>
    /// 数据库链接信息
    /// </summary>
    public class DbConnectModel :BaseModel
    {
        /// <summary>
        /// 链接名称
        /// </summary>
        public virtual string ConnectName { get;set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public virtual string DbName { get;set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public virtual string PassWord { get;set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get;set; }
    }
}
