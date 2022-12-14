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
	/// <summary>Grid Page</summary>
	[PublishedContentModel("gridPage")]
	public partial class GridPage : PublishedContentModel, IBasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "gridPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GridPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GridPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
		}

		///<summary>
		/// Content Grid Background Color: Any css color (rgb, hex, name)
		///</summary>
		[ImplementPropertyType("contentGridBackgroundColor")]
		public string ContentGridBackgroundColor
		{
			get { return this.GetPropertyValue<string>("contentGridBackgroundColor"); }
		}

		///<summary>
		/// Headline Background Color: Any css color (rgb, hex, name)
		///</summary>
		[ImplementPropertyType("headlineBackgroundColor")]
		public string HeadlineBackgroundColor
		{
			get { return this.GetPropertyValue<string>("headlineBackgroundColor"); }
		}

		///<summary>
		/// Headline Text Color: Any css color (rgb, hex, name)
		///</summary>
		[ImplementPropertyType("headlineTextColor")]
		public string HeadlineTextColor
		{
			get { return this.GetPropertyValue<string>("headlineTextColor"); }
		}

		///<summary>
		/// Metadata Description
		///</summary>
		[ImplementPropertyType("metadataDescription")]
		public string MetadataDescription
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetMetadataDescription(this); }
		}

		///<summary>
		/// SEO Title
		///</summary>
		[ImplementPropertyType("sEOTitle")]
		public string SEotitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetSEotitle(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("test")]
		public string Test
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetTest(this); }
		}

		///<summary>
		/// Theme
		///</summary>
		[ImplementPropertyType("theme")]
		public IPublishedContent Theme
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetTheme(this); }
		}
	}
}
