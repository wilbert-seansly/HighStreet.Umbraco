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
	/// <summary>Next Prev Buttons</summary>
	[PublishedContentModel("nextPrevButtons")]
	public partial class NextPrevButtons : SliderNavigationStyle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "nextPrevButtons";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NextPrevButtons(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NextPrevButtons, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Next Image: Overrides Default
		///</summary>
		[ImplementPropertyType("nextImage")]
		public IPublishedContent NextImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("nextImage"); }
		}

		///<summary>
		/// Prev Image: Overrides Default
		///</summary>
		[ImplementPropertyType("prevImage")]
		public IPublishedContent PrevImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("prevImage"); }
		}
	}
}
