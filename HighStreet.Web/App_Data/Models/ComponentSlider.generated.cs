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
	/// <summary>Component--Slider</summary>
	[PublishedContentModel("componentSlider")]
	public partial class ComponentSlider : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "componentSlider";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ComponentSlider(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ComponentSlider, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Aspect Ratio
		///</summary>
		[ImplementPropertyType("aspectRatio")]
		public string AspectRatio
		{
			get { return this.GetPropertyValue<string>("aspectRatio"); }
		}

		///<summary>
		/// Autoplay
		///</summary>
		[ImplementPropertyType("autoplay")]
		public bool Autoplay
		{
			get { return this.GetPropertyValue<bool>("autoplay"); }
		}

		///<summary>
		/// Background Color
		///</summary>
		[ImplementPropertyType("backgroundColor")]
		public string BackgroundColor
		{
			get { return this.GetPropertyValue<string>("backgroundColor"); }
		}

		///<summary>
		/// Background Size
		///</summary>
		[ImplementPropertyType("backgroundSize")]
		public string BackgroundSize
		{
			get { return this.GetPropertyValue<string>("backgroundSize"); }
		}

		///<summary>
		/// Fade Transition: Default is swiped
		///</summary>
		[ImplementPropertyType("fadeTransition")]
		public bool FadeTransition
		{
			get { return this.GetPropertyValue<bool>("fadeTransition"); }
		}

		///<summary>
		/// Full Width
		///</summary>
		[ImplementPropertyType("fullWidth")]
		public bool FullWidth
		{
			get { return this.GetPropertyValue<bool>("fullWidth"); }
		}

		///<summary>
		/// Height: Overrides aspect ratio
		///</summary>
		[ImplementPropertyType("height")]
		public string Height
		{
			get { return this.GetPropertyValue<string>("height"); }
		}

		///<summary>
		/// Images Clickable
		///</summary>
		[ImplementPropertyType("imagesClickable")]
		public bool ImagesClickable
		{
			get { return this.GetPropertyValue<bool>("imagesClickable"); }
		}

		///<summary>
		/// Margin Top
		///</summary>
		[ImplementPropertyType("marginTop")]
		public string MarginTop
		{
			get { return this.GetPropertyValue<string>("marginTop"); }
		}

		///<summary>
		/// Next/Prev Inside
		///</summary>
		[ImplementPropertyType("nextPrevInside")]
		public bool NextPrevInside
		{
			get { return this.GetPropertyValue<bool>("nextPrevInside"); }
		}

		///<summary>
		/// Page Buttons Instead
		///</summary>
		[ImplementPropertyType("pageButtonsInstead")]
		public bool PageButtonsInstead
		{
			get { return this.GetPropertyValue<bool>("pageButtonsInstead"); }
		}

		///<summary>
		/// Pan Background
		///</summary>
		[ImplementPropertyType("panBackground")]
		public bool PanBackground
		{
			get { return this.GetPropertyValue<bool>("panBackground"); }
		}

		///<summary>
		/// Slider Direction
		///</summary>
		[ImplementPropertyType("sliderDirection")]
		public string SliderDirection
		{
			get { return this.GetPropertyValue<string>("sliderDirection"); }
		}

		///<summary>
		/// Slider Id
		///</summary>
		[ImplementPropertyType("sliderId")]
		public string SliderId
		{
			get { return this.GetPropertyValue<string>("sliderId"); }
		}

		///<summary>
		/// Slider Navigation Style
		///</summary>
		[ImplementPropertyType("sliderNavigationStyle")]
		public IPublishedContent SliderNavigationStyle
		{
			get { return this.GetPropertyValue<IPublishedContent>("sliderNavigationStyle"); }
		}

		///<summary>
		/// Slides: Folder containing slides
		///</summary>
		[ImplementPropertyType("slides")]
		public IPublishedContent Slides
		{
			get { return this.GetPropertyValue<IPublishedContent>("slides"); }
		}
	}
}
