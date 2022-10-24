//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Meta Tag</summary>
	[PublishedContentModel("metaTag")]
	public partial class MetaTag : MetaTags
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "metaTag";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MetaTag(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MetaTag, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Tag Name
		///</summary>
		[ImplementPropertyType("tagName")]
		public string TagName
		{
			get { return this.GetPropertyValue<string>("tagName"); }
		}

		///<summary>
		/// Tag Value
		///</summary>
		[ImplementPropertyType("tagValue")]
		public string TagValue
		{
			get { return this.GetPropertyValue<string>("tagValue"); }
		}
	}
}
