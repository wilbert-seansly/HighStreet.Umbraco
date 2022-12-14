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
	/// <summary>Slide With Centered Text</summary>
	[PublishedContentModel("slideWithCenteredText")]
	public partial class SlideWithCenteredText : Slide
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "slideWithCenteredText";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SlideWithCenteredText(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideWithCenteredText, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Color: Color of slide text
		///</summary>
		[ImplementPropertyType("color")]
		public string Color
		{
			get { return this.GetPropertyValue<string>("color"); }
		}

		///<summary>
		/// Text: This text will be centered in the slide.
		///</summary>
		[ImplementPropertyType("text")]
		public string Text
		{
			get { return this.GetPropertyValue<string>("text"); }
		}
	}
}
