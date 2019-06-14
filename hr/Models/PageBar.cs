using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace hr.Models
{
    public class PageBar
    {    
        /// <summary>
        /// 无限分页
        /// </summary>
        /// <param name="PI">当前页</param>
        /// <param name="PC">数据总页</param>
        /// <returns></returns>
        #region  原有方法
        public static string GetpageBar(int PI, int PC) 
        {
            if (PC == 1)
                return null;
            int start = PI - 5;
            if (start < 1)
                start = 1;
            int end = start + 9;
            if (end > PC)
                end = PC;
            StringBuilder hr = new StringBuilder();
            if (PI > 1)
                hr.Append(string.Format("<a href='?PI={0}'>上一页</a>", PI - 1));
            for (int i = start; i <= end; i++) 
            {
                if (i == PI)
                    hr.Append(i);
                else
                    hr.Append(string.Format("<a href='?PI={0}'>{0}</a>", i));
               
            } if (PI < PC) { hr.Append(string.Format("<a href='?PI={0}'>下一页</a>", PI +1)); } 
            return hr.ToString();
        }
        #endregion
    }
}