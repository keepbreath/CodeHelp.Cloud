using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeHelp.Cloud.Dto.Project_Report_Dto
{
    /// <summary>
    /// 报告信息
    /// IsNullable表示表字段是否可空
    /// IsIgnore 为true表示不会生成字段到数据库
    /// IsIdentity表示为自增列
    /// IsPrimaryKey表示为主键
    /// Length 表示字段长度
    /// DecimalDigits 表示字段的精度 4.4
    /// ColumnDataType 强制设置数据库字段的类型（考虑到切换数据库有些类型其它库没有最新版本支持多个以逗号隔离，比如=“number,int”）
    /// </summary>
    public class Report
    {
        /// <summary>
        /// 报告id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, Length = 36)]
        public String Id { get; set; }
        /// <summary>
        /// 作者id
        /// </summary>
        [SugarColumn(IsNullable = false, Length = 36)]
        public String AuthorId { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public DateTime PublishTime { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [SugarColumn(IsNullable = false, ColumnDataType="text")]
        public String Content { get; set; }
        /// <summary>
        /// 附件路径
        /// </summary>
        [SugarColumn(IsNullable = false, Length = 1024)]
        public String FilePath { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        [SugarColumn(IsNullable = true, Length = 36)]
        public string CreatUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        [SugarColumn(IsNullable = true, Length = 36)]
        public string UpdateUser { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime UpdateTime { get; set; }
    }
}
