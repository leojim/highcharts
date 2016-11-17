﻿
// Type: Highsoft.Web.Mvc.Charts.Legend




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class Legend : BaseObject
  {
    public LegendAlign Align { get; set; }

    private LegendAlign Align_DefaultValue { get; set; }

    public string BackgroundColor { get; set; }

    private string BackgroundColor_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderRadius { get; set; }

    private double? BorderRadius_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public bool? Floating { get; set; }

    private bool? Floating_DefaultValue { get; set; }

    public double? ItemDistance { get; set; }

    private double? ItemDistance_DefaultValue { get; set; }

    public Hashtable ItemHiddenStyle { get; set; }

    private Hashtable ItemHiddenStyle_DefaultValue { get; set; }

    public Hashtable ItemHoverStyle { get; set; }

    private Hashtable ItemHoverStyle_DefaultValue { get; set; }

    public double? ItemMarginBottom { get; set; }

    private double? ItemMarginBottom_DefaultValue { get; set; }

    public double? ItemMarginTop { get; set; }

    private double? ItemMarginTop_DefaultValue { get; set; }

    public Hashtable ItemStyle { get; set; }

    private Hashtable ItemStyle_DefaultValue { get; set; }

    public double? ItemWidth { get; set; }

    private double? ItemWidth_DefaultValue { get; set; }

    public string LabelFormat { get; set; }

    private string LabelFormat_DefaultValue { get; set; }

    public string LabelFormatter { get; set; }

    private string LabelFormatter_DefaultValue { get; set; }

    public LegendLayout Layout { get; set; }

    private LegendLayout Layout_DefaultValue { get; set; }

    public double? LineHeight { get; set; }

    private double? LineHeight_DefaultValue { get; set; }

    public string[] Margin { get; set; }

    private string[] Margin_DefaultValue { get; set; }

    public double? MaxHeight { get; set; }

    private double? MaxHeight_DefaultValue { get; set; }

    public LegendNavigation Navigation { get; set; }

    private LegendNavigation Navigation_DefaultValue { get; set; }

    public double? Padding { get; set; }

    private double? Padding_DefaultValue { get; set; }

    public bool? Reversed { get; set; }

    private bool? Reversed_DefaultValue { get; set; }

    public bool? Rtl { get; set; }

    private bool? Rtl_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public double? SymbolHeight { get; set; }

    private double? SymbolHeight_DefaultValue { get; set; }

    public double? SymbolPadding { get; set; }

    private double? SymbolPadding_DefaultValue { get; set; }

    public double? SymbolRadius { get; set; }

    private double? SymbolRadius_DefaultValue { get; set; }

    public double? SymbolWidth { get; set; }

    private double? SymbolWidth_DefaultValue { get; set; }

    public LegendTitle Title { get; set; }

    private LegendTitle Title_DefaultValue { get; set; }

    public bool? UseHTML { get; set; }

    private bool? UseHTML_DefaultValue { get; set; }

    public LegendVerticalAlign VerticalAlign { get; set; }

    private LegendVerticalAlign VerticalAlign_DefaultValue { get; set; }

    public double? Width { get; set; }

    private double? Width_DefaultValue { get; set; }

    public double? X { get; set; }

    private double? X_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public Legend()
    {
      this.Align = this.Align_DefaultValue = LegendAlign.Center;
      this.BackgroundColor = this.BackgroundColor_DefaultValue = (string) null;
      this.BorderColor = this.BorderColor_DefaultValue = "#909090";
      double? nullable1 = new double?(0.0);
      this.BorderRadius_DefaultValue = nullable1;
      this.BorderRadius = nullable1;
      nullable1 = new double?(0.0);
      this.BorderWidth_DefaultValue = nullable1;
      this.BorderWidth = nullable1;
      bool? nullable2 = new bool?(true);
      this.Enabled_DefaultValue = nullable2;
      this.Enabled = nullable2;
      nullable2 = new bool?(false);
      this.Floating_DefaultValue = nullable2;
      this.Floating = nullable2;
      nullable1 = new double?(20.0);
      this.ItemDistance_DefaultValue = nullable1;
      this.ItemDistance = nullable1;
      this.ItemHiddenStyle = this.ItemHiddenStyle_DefaultValue = (Hashtable) null;
      this.ItemHoverStyle = this.ItemHoverStyle_DefaultValue = (Hashtable) null;
      nullable1 = new double?(0.0);
      this.ItemMarginBottom_DefaultValue = nullable1;
      this.ItemMarginBottom = nullable1;
      nullable1 = new double?(0.0);
      this.ItemMarginTop_DefaultValue = nullable1;
      this.ItemMarginTop = nullable1;
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "color", (object) "#333333");
      hashtable1.Add((object) "cursor", (object) "pointer");
      hashtable1.Add((object) "fontSize", (object) "12px");
      hashtable1.Add((object) "fontWeight", (object) "bold");
      Hashtable hashtable2 = hashtable1;
      this.ItemStyle_DefaultValue = hashtable1;
      this.ItemStyle = hashtable2;
      double? nullable3 = new double?();
      this.ItemWidth_DefaultValue = nullable3;
      this.ItemWidth = nullable3;
      this.LabelFormat = this.LabelFormat_DefaultValue = "{name}";
      this.LabelFormatter = this.LabelFormatter_DefaultValue = "";
      this.Layout = this.Layout_DefaultValue = LegendLayout.Horizontal;
      nullable3 = new double?(16.0);
      this.LineHeight_DefaultValue = nullable3;
      this.LineHeight = nullable3;
      this.Margin = this.Margin_DefaultValue = new string[0];
      double? nullable4 = new double?();
      this.MaxHeight_DefaultValue = nullable4;
      this.MaxHeight = nullable4;
      this.Navigation = this.Navigation_DefaultValue = new LegendNavigation();
      nullable4 = new double?(8.0);
      this.Padding_DefaultValue = nullable4;
      this.Padding = nullable4;
      nullable2 = new bool?(false);
      this.Reversed_DefaultValue = nullable2;
      this.Reversed = nullable2;
      nullable2 = new bool?(false);
      this.Rtl_DefaultValue = nullable2;
      this.Rtl = nullable2;
      Shadow shadow1 = new Shadow();
      shadow1.Enabled = false;
      Shadow shadow2 = shadow1;
      this.Shadow_DefaultValue = shadow1;
      this.Shadow = shadow2;
      double? nullable5 = new double?();
      this.SymbolHeight_DefaultValue = nullable5;
      this.SymbolHeight = nullable5;
      nullable5 = new double?(5.0);
      this.SymbolPadding_DefaultValue = nullable5;
      this.SymbolPadding = nullable5;
      nullable5 = new double?(2.0);
      this.SymbolRadius_DefaultValue = nullable5;
      this.SymbolRadius = nullable5;
      nullable5 = new double?(16.0);
      this.SymbolWidth_DefaultValue = nullable5;
      this.SymbolWidth = nullable5;
      this.Title = this.Title_DefaultValue = new LegendTitle();
      nullable2 = new bool?(false);
      this.UseHTML_DefaultValue = nullable2;
      this.UseHTML = nullable2;
      this.VerticalAlign = this.VerticalAlign_DefaultValue = LegendVerticalAlign.Bottom;
      double? nullable6 = new double?();
      this.Width_DefaultValue = nullable6;
      this.Width = nullable6;
      nullable6 = new double?(0.0);
      this.X_DefaultValue = nullable6;
      this.X = nullable6;
      nullable6 = new double?(0.0);
      this.Y_DefaultValue = nullable6;
      this.Y = nullable6;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Align != this.Align_DefaultValue)
        hashtable.Add((object) "align", (object) Highcharts.FirstCharacterToLower(this.Align.ToString()));
      if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
        hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? nullable1 = this.BorderRadius;
      double? nullable2 = this.BorderRadius_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
      nullable2 = this.BorderWidth;
      nullable1 = this.BorderWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      bool? nullable3 = this.Enabled;
      bool? nullable4 = this.Enabled_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      nullable4 = this.Floating;
      nullable3 = this.Floating_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "floating", (object) this.Floating);
      nullable1 = this.ItemDistance;
      nullable2 = this.ItemDistance_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "itemDistance", (object) this.ItemDistance);
      if (this.ItemHiddenStyle != this.ItemHiddenStyle_DefaultValue)
        hashtable.Add((object) "itemHiddenStyle", (object) this.ItemHiddenStyle);
      if (this.ItemHoverStyle != this.ItemHoverStyle_DefaultValue)
        hashtable.Add((object) "itemHoverStyle", (object) this.ItemHoverStyle);
      nullable2 = this.ItemMarginBottom;
      nullable1 = this.ItemMarginBottom_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "itemMarginBottom", (object) this.ItemMarginBottom);
      nullable1 = this.ItemMarginTop;
      nullable2 = this.ItemMarginTop_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "itemMarginTop", (object) this.ItemMarginTop);
      if (this.ItemStyle != this.ItemStyle_DefaultValue)
        hashtable.Add((object) "itemStyle", (object) this.ItemStyle);
      nullable2 = this.ItemWidth;
      nullable1 = this.ItemWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "itemWidth", (object) this.ItemWidth);
      if (this.LabelFormat != this.LabelFormat_DefaultValue)
        hashtable.Add((object) "labelFormat", (object) this.LabelFormat);
      if (this.LabelFormatter != this.LabelFormatter_DefaultValue)
      {
        hashtable.Add((object) "labelFormatter", (object) this.LabelFormatter);
        Highcharts.AddFunction("LegendLabelFormatter.labelFormatter", this.LabelFormatter);
      }
      if (this.Layout != this.Layout_DefaultValue)
        hashtable.Add((object) "layout", (object) Highcharts.FirstCharacterToLower(this.Layout.ToString()));
      nullable1 = this.LineHeight;
      nullable2 = this.LineHeight_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineHeight", (object) this.LineHeight);
      if (this.Margin != this.Margin_DefaultValue)
        hashtable.Add((object) "margin", (object) this.Margin);
      nullable2 = this.MaxHeight;
      nullable1 = this.MaxHeight_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "maxHeight", (object) this.MaxHeight);
      if (this.Navigation.IsDirty())
        hashtable.Add((object) "navigation", (object) this.Navigation.ToHashtable());
      nullable1 = this.Padding;
      nullable2 = this.Padding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "padding", (object) this.Padding);
      nullable3 = this.Reversed;
      nullable4 = this.Reversed_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "reversed", (object) this.Reversed);
      nullable4 = this.Rtl;
      nullable3 = this.Rtl_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "rtl", (object) this.Rtl);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable2 = this.SymbolHeight;
      nullable1 = this.SymbolHeight_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "symbolHeight", (object) this.SymbolHeight);
      nullable1 = this.SymbolPadding;
      nullable2 = this.SymbolPadding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "symbolPadding", (object) this.SymbolPadding);
      nullable2 = this.SymbolRadius;
      nullable1 = this.SymbolRadius_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "symbolRadius", (object) this.SymbolRadius);
      nullable1 = this.SymbolWidth;
      nullable2 = this.SymbolWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "symbolWidth", (object) this.SymbolWidth);
      if (this.Title.IsDirty())
        hashtable.Add((object) "title", (object) this.Title.ToHashtable());
      nullable3 = this.UseHTML;
      nullable4 = this.UseHTML_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "useHTML", (object) this.UseHTML);
      if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
        hashtable.Add((object) "verticalAlign", (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
      nullable2 = this.Width;
      nullable1 = this.Width_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "width", (object) this.Width);
      nullable1 = this.X;
      nullable2 = this.X_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "x", (object) this.X);
      nullable2 = this.Y;
      nullable1 = this.Y_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "y", (object) this.Y);
      return hashtable;
    }

    internal override string ToJSON()
    {
      if (this.ToHashtable().Count > 0)
        return JsonConvert.SerializeObject((object) this.ToHashtable());
      return "";
    }

    internal override bool IsDirty()
    {
      return this.ToHashtable().Count > 0;
    }
  }
}