using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0509.Modle
{
    public class TodoItem
    {
        /// <summary>
        /// 識別id
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 代辦事項名稱
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 是否完成
        /// </summary>
        public bool isComplete { get; set; }
    }
}
