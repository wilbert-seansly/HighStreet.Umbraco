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
	// Mixin content Type 1157 with alias "navElement"
	/// <summary>Nav Element</summary>
	public partial interface INavElement : IPublishedContent
	{
		/// <summary>Always show color?</summary>
		bool AlwaysShowColor { get; }

		/// <summary>Color</summary>
		string Color { get; }

		/// <summary>Display Name</summary>
		string DisplayName { get; }

		/// <summary>Page</summary>
		IPublishedContent Page { get; }
	}

	/// <summary>Nav Element</summary>
	[PublishedContentModel("navElement")]
	public partial class NavElement : PublishedContentModel, INavElement
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "navElement";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NavElement(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NavElement, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Always show color?: default will show on hover
		///</summary>
		[ImplementPropertyType("alwaysShowColor")]
		public bool AlwaysShowColor
		{
			get { return GetAlwaysShowColor(this); }
		}

		/// <summary>Static getter for Always show color?</summary>
		public static bool GetAlwaysShowColor(INavElement that) { return that.GetPropertyValue<bool>("alwaysShowColor"); }

		///<summary>
		/// Color
		///</summary>
		[ImplementPropertyType("color")]
		public string Color
		{
			get { return GetColor(this); }
		}

		/// <summary>Static getter for Color</summary>
		public static string GetColor(INavElement that) { return that.GetPropertyValue<string>("color"); }

		///<summary>
		/// Display Name: Will be displayed in nav bar instead of page name.
		///</summary>
		[ImplementPropertyType("displayName")]
		public string DisplayName
		{
			get { return GetDisplayName(this); }
		}

		/// <summary>Static getter for Display Name</summary>
		public static string GetDisplayName(INavElement that) { return that.GetPropertyValue<string>("displayName"); }

		///<summary>
		/// Page
		///</summary>
		[ImplementPropertyType("page")]
		public IPublishedContent Page
		{
			get { return GetPage(this); }
		}

		/// <summary>Static getter for Page</summary>
		public static IPublishedContent GetPage(INavElement that) { return that.GetPropertyValue<IPublishedContent>("page"); }
	}
}
