﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models
{

	[JsonObject(MemberSerialization.OptIn)]
	public partial class cms_channel
	{

		/// <summary>
		/// 外链
		/// </summary>
		[JsonProperty]
		public string channel_href { get; set; } = string.Empty;

		/// <summary>
		/// 栏目图片
		/// </summary>
		[JsonProperty]
		public string channel_image { get; set; } = string.Empty;

		/// <summary>
		/// 栏目索引
		/// </summary>
		[JsonProperty]
		public string channel_index { get; set; } = string.Empty;

		/// <summary>
		/// 栏目名称
		/// </summary>
		[JsonProperty]
		public string channel_name { get; set; } = string.Empty;

		[JsonProperty, Column(IsIdentity = true)]
		public int id { get; set; }

		[JsonProperty]
		public long insert_id { get; set; }

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime insert_time { get; set; }

		[JsonProperty]
		public int parent_id { get; set; }
		[JsonProperty]
		public int sort_num { get; set; }

		/// <summary>
		/// 0-的时候取默认模板,栏目模板
		/// </summary>
		public int channel_template { get; set; }
		/// <summary>
		/// 0-的时候取默认模板，内容模板
		/// </summary>
		public int content_template { get; set; }


	}

}

