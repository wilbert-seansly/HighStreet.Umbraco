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
	/// <summary>Pagination Buttons</summary>
	[PublishedContentModel("paginationButtons")]
	public partial class PaginationButtons : SliderNavigationStyle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "paginationButtons";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PaginationButtons(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PaginationButtons, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Active Background Color
		///</summary>
		[ImplementPropertyType("activeBackgroundColor")]
		public string ActiveBackgroundColor
		{
			get { return this.GetPropertyValue<string>("activeBackgroundColor"); }
		}

		///<summary>
		/// Buttons Position
		///</summary>
		[ImplementPropertyType("buttonsPosition")]
		public string ButtonsPosition
		{
			get { return this.GetPropertyValue<string>("buttonsPosition"); }
		}

		///<summary>
		/// Button Style
		///</summary>
		[ImplementPropertyType("buttonStyle")]
		public string ButtonStyle
		{
			get { return this.GetPropertyValue<string>("buttonStyle"); }
		}

		///<summary>
		/// Inactive Background Color
		///</summary>
		[ImplementPropertyType("inactiveBackgroundColor")]
		public string InactiveBackgroundColor
		{
			get { return this.GetPropertyValue<string>("inactiveBackgroundColor"); }
		}

		///<summary>
		/// Pagination Title
		///</summary>
		[ImplementPropertyType("paginationTitle")]
		public string PaginationTitle
		{
			get { return this.GetPropertyValue<string>("paginationTitle"); }
		}

		///<summary>
		/// Text Color
		///</summary>
		[ImplementPropertyType("textColor")]
		public string TextColor
		{
			get { return this.GetPropertyValue<string>("textColor"); }
		}
	}
}
