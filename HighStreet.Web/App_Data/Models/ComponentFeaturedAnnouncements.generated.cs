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
	/// <summary>Component--Featured Announcements</summary>
	[PublishedContentModel("componentFeaturedAnnouncements")]
	public partial class ComponentFeaturedAnnouncements : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "componentFeaturedAnnouncements";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ComponentFeaturedAnnouncements(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ComponentFeaturedAnnouncements, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Anchor Links
		///</summary>
		[ImplementPropertyType("anchorLinks")]
		public IPublishedContent AnchorLinks
		{
			get { return this.GetPropertyValue<IPublishedContent>("anchorLinks"); }
		}

		///<summary>
		/// Announcements
		///</summary>
		[ImplementPropertyType("announcements")]
		public IPublishedContent Announcements
		{
			get { return this.GetPropertyValue<IPublishedContent>("announcements"); }
		}

		///<summary>
		/// Main Story: Latest featured announcement will be show if left empty
		///</summary>
		[ImplementPropertyType("mainStory")]
		public IPublishedContent MainStory
		{
			get { return this.GetPropertyValue<IPublishedContent>("mainStory"); }
		}
	}
}
