using Senparc.Weixin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJY.API
{
    /// <summary>
    /// 获取企业号应用返回结果
    /// </summary>
    public class GetExUserinfoResult : QyJsonResult
    {
        public external_contact external_contact { get; set; }
    }

    public class external_contact
    {
        public string external_userid { get; set; }
        public string name { get; set; }
        public string position { get; set; }

        public string avatar { get; set; }

        public string corp_name { get; set; }

        public string corp_full_name { get; set; }

        public int type { get; set; }
        public int gender { get; set; }

        public string unionid { get; set; }
       
    }

   
}
