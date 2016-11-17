﻿
// Type: Highsoft.Web.Mvc.Charts.XAxis




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class XAxis : BaseObject
  {
    public bool? AllowDecimals { get; set; }

    private bool? AllowDecimals_DefaultValue { get; set; }

    public string AlternateGridColor { get; set; }

    private string AlternateGridColor_DefaultValue { get; set; }

    public XAxisBreaks Breaks { get; set; }

    private XAxisBreaks Breaks_DefaultValue { get; set; }

    public List<string> Categories { get; set; }

    private List<string> Categories_DefaultValue { get; set; }

    public double? Ceiling { get; set; }

    private double? Ceiling_DefaultValue { get; set; }

    public Hashtable DateTimeLabelFormats { get; set; }

    private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

    public bool? EndOnTick { get; set; }

    private bool? EndOnTick_DefaultValue { get; set; }

    public XAxisEvents Events { get; set; }

    private XAxisEvents Events_DefaultValue { get; set; }

    public double? Floor { get; set; }

    private double? Floor_DefaultValue { get; set; }

    public string GridLineColor { get; set; }

    private string GridLineColor_DefaultValue { get; set; }

    public XAxisGridLineDashStyle GridLineDashStyle { get; set; }

    private XAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }

    public double? GridLineWidth { get; set; }

    private double? GridLineWidth_DefaultValue { get; set; }

    public double? GridZIndex { get; set; }

    private double? GridZIndex_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public XAxisLabels Labels { get; set; }

    private XAxisLabels Labels_DefaultValue { get; set; }

    public string LineColor { get; set; }

    private string LineColor_DefaultValue { get; set; }

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public double? LinkedTo { get; set; }

    private double? LinkedTo_DefaultValue { get; set; }

    public double? Max { get; set; }

    private double? Max_DefaultValue { get; set; }

    public double? MaxPadding { get; set; }

    private double? MaxPadding_DefaultValue { get; set; }

    public double? Min { get; set; }

    private double? Min_DefaultValue { get; set; }

    public double? MinPadding { get; set; }

    private double? MinPadding_DefaultValue { get; set; }

    public double? MinRange { get; set; }

    private double? MinRange_DefaultValue { get; set; }

    public double? MinTickInterval { get; set; }

    private double? MinTickInterval_DefaultValue { get; set; }

    public string MinorGridLineColor { get; set; }

    private string MinorGridLineColor_DefaultValue { get; set; }

    public XAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }

    private XAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }

    public double? MinorGridLineWidth { get; set; }

    private double? MinorGridLineWidth_DefaultValue { get; set; }

    public string MinorTickColor { get; set; }

    private string MinorTickColor_DefaultValue { get; set; }

    public string MinorTickInterval { get; set; }

    private string MinorTickInterval_DefaultValue { get; set; }

    public double? MinorTickLength { get; set; }

    private double? MinorTickLength_DefaultValue { get; set; }

    public XAxisMinorTickPosition MinorTickPosition { get; set; }

    private XAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }

    public double? MinorTickWidth { get; set; }

    private double? MinorTickWidth_DefaultValue { get; set; }

    public double? Offset { get; set; }

    private double? Offset_DefaultValue { get; set; }

    public bool? Opposite { get; set; }

    private bool? Opposite_DefaultValue { get; set; }

    public List<XAxisPlotBands> PlotBands { get; set; }

    private List<XAxisPlotBands> PlotBands_DefaultValue { get; set; }

    public List<XAxisPlotLines> PlotLines { get; set; }

    private List<XAxisPlotLines> PlotLines_DefaultValue { get; set; }

    public bool? Reversed { get; set; }

    private bool? Reversed_DefaultValue { get; set; }

    public bool? ShowEmpty { get; set; }

    private bool? ShowEmpty_DefaultValue { get; set; }

    public bool? ShowFirstLabel { get; set; }

    private bool? ShowFirstLabel_DefaultValue { get; set; }

    public bool? ShowLastLabel { get; set; }

    private bool? ShowLastLabel_DefaultValue { get; set; }

    public double? StartOfWeek { get; set; }

    private double? StartOfWeek_DefaultValue { get; set; }

    public bool? StartOnTick { get; set; }

    private bool? StartOnTick_DefaultValue { get; set; }

    public double? TickAmount { get; set; }

    private double? TickAmount_DefaultValue { get; set; }

    public string TickColor { get; set; }

    private string TickColor_DefaultValue { get; set; }

    public double? TickInterval { get; set; }

    private double? TickInterval_DefaultValue { get; set; }

    public double? TickLength { get; set; }

    private double? TickLength_DefaultValue { get; set; }

    public double? TickPixelInterval { get; set; }

    private double? TickPixelInterval_DefaultValue { get; set; }

    public XAxisTickPosition TickPosition { get; set; }

    private XAxisTickPosition TickPosition_DefaultValue { get; set; }

    public string TickPositioner { get; set; }

    private string TickPositioner_DefaultValue { get; set; }

    public List<double> TickPositions { get; set; }

    private List<double> TickPositions_DefaultValue { get; set; }

    public double? TickWidth { get; set; }

    private double? TickWidth_DefaultValue { get; set; }

    public XAxisTickmarkPlacement TickmarkPlacement { get; set; }

    private XAxisTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }

    public XAxisTitle Title { get; set; }

    private XAxisTitle Title_DefaultValue { get; set; }

    public XAxisType Type { get; set; }

    private XAxisType Type_DefaultValue { get; set; }

    public XAxis()
    {
      bool? nullable1 = new bool?(true);
      this.AllowDecimals_DefaultValue = nullable1;
      this.AllowDecimals = nullable1;
      this.AlternateGridColor = this.AlternateGridColor_DefaultValue = (string) null;
      this.Breaks = this.Breaks_DefaultValue = new XAxisBreaks();
      this.Categories = this.Categories_DefaultValue = (List<string>) null;
      double? nullable2 = new double?();
      this.Ceiling_DefaultValue = nullable2;
      this.Ceiling = nullable2;
      this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
      nullable1 = new bool?(false);
      this.EndOnTick_DefaultValue = nullable1;
      this.EndOnTick = nullable1;
      this.Events = this.Events_DefaultValue = new XAxisEvents();
      double? nullable3 = new double?();
      this.Floor_DefaultValue = nullable3;
      this.Floor = nullable3;
      this.GridLineColor = this.GridLineColor_DefaultValue = "#D8D8D8";
      this.GridLineDashStyle = this.GridLineDashStyle_DefaultValue = XAxisGridLineDashStyle.Solid;
      nullable3 = new double?(0.0);
      this.GridLineWidth_DefaultValue = nullable3;
      this.GridLineWidth = nullable3;
      nullable3 = new double?(1.0);
      this.GridZIndex_DefaultValue = nullable3;
      this.GridZIndex = nullable3;
      this.Id = this.Id_DefaultValue = (string) null;
      this.Labels = this.Labels_DefaultValue = new XAxisLabels();
      this.LineColor = this.LineColor_DefaultValue = "#C0D0E0";
      nullable3 = new double?(1.0);
      this.LineWidth_DefaultValue = nullable3;
      this.LineWidth = nullable3;
      double? nullable4 = new double?();
      this.LinkedTo_DefaultValue = nullable4;
      this.LinkedTo = nullable4;
      double? nullable5 = new double?();
      this.Max_DefaultValue = nullable5;
      this.Max = nullable5;
      nullable5 = new double?(0.01);
      this.MaxPadding_DefaultValue = nullable5;
      this.MaxPadding = nullable5;
      double? nullable6 = new double?();
      this.Min_DefaultValue = nullable6;
      this.Min = nullable6;
      nullable6 = new double?(0.01);
      this.MinPadding_DefaultValue = nullable6;
      this.MinPadding = nullable6;
      double? nullable7 = new double?();
      this.MinRange_DefaultValue = nullable7;
      this.MinRange = nullable7;
      double? nullable8 = new double?();
      this.MinTickInterval_DefaultValue = nullable8;
      this.MinTickInterval = nullable8;
      this.MinorGridLineColor = this.MinorGridLineColor_DefaultValue = "#E0E0E0";
      this.MinorGridLineDashStyle = this.MinorGridLineDashStyle_DefaultValue = XAxisMinorGridLineDashStyle.Solid;
      nullable8 = new double?(1.0);
      this.MinorGridLineWidth_DefaultValue = nullable8;
      this.MinorGridLineWidth = nullable8;
      this.MinorTickColor = this.MinorTickColor_DefaultValue = "#A0A0A0";
      this.MinorTickInterval = this.MinorTickInterval_DefaultValue = (string) null;
      nullable8 = new double?(2.0);
      this.MinorTickLength_DefaultValue = nullable8;
      this.MinorTickLength = nullable8;
      this.MinorTickPosition = this.MinorTickPosition_DefaultValue = XAxisMinorTickPosition.Outside;
      nullable8 = new double?(0.0);
      this.MinorTickWidth_DefaultValue = nullable8;
      this.MinorTickWidth = nullable8;
      nullable8 = new double?(0.0);
      this.Offset_DefaultValue = nullable8;
      this.Offset = nullable8;
      nullable1 = new bool?(false);
      this.Opposite_DefaultValue = nullable1;
      this.Opposite = nullable1;
      this.PlotBands = this.PlotBands_DefaultValue = new List<XAxisPlotBands>();
      this.PlotLines = this.PlotLines_DefaultValue = new List<XAxisPlotLines>();
      nullable1 = new bool?(false);
      this.Reversed_DefaultValue = nullable1;
      this.Reversed = nullable1;
      nullable1 = new bool?(true);
      this.ShowEmpty_DefaultValue = nullable1;
      this.ShowEmpty = nullable1;
      nullable1 = new bool?(true);
      this.ShowFirstLabel_DefaultValue = nullable1;
      this.ShowFirstLabel = nullable1;
      nullable1 = new bool?(true);
      this.ShowLastLabel_DefaultValue = nullable1;
      this.ShowLastLabel = nullable1;
      nullable8 = new double?(1.0);
      this.StartOfWeek_DefaultValue = nullable8;
      this.StartOfWeek = nullable8;
      nullable1 = new bool?(false);
      this.StartOnTick_DefaultValue = nullable1;
      this.StartOnTick = nullable1;
      double? nullable9 = new double?();
      this.TickAmount_DefaultValue = nullable9;
      this.TickAmount = nullable9;
      this.TickColor = this.TickColor_DefaultValue = "#C0D0E0";
      double? nullable10 = new double?();
      this.TickInterval_DefaultValue = nullable10;
      this.TickInterval = nullable10;
      nullable10 = new double?(10.0);
      this.TickLength_DefaultValue = nullable10;
      this.TickLength = nullable10;
      double? nullable11 = new double?();
      this.TickPixelInterval_DefaultValue = nullable11;
      this.TickPixelInterval = nullable11;
      this.TickPosition = this.TickPosition_DefaultValue = XAxisTickPosition.Outside;
      this.TickPositioner = this.TickPositioner_DefaultValue = "";
      this.TickPositions = this.TickPositions_DefaultValue = (List<double>) null;
      nullable11 = new double?(1.0);
      this.TickWidth_DefaultValue = nullable11;
      this.TickWidth = nullable11;
      this.TickmarkPlacement = this.TickmarkPlacement_DefaultValue = XAxisTickmarkPlacement.Null;
      this.Title = this.Title_DefaultValue = new XAxisTitle();
      this.Type = this.Type_DefaultValue = XAxisType.Linear;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      bool? allowDecimals = this.AllowDecimals;
      bool? decimalsDefaultValue = this.AllowDecimals_DefaultValue;
      if ((allowDecimals.GetValueOrDefault() == decimalsDefaultValue.GetValueOrDefault() ? (allowDecimals.HasValue != decimalsDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "allowDecimals", (object) this.AllowDecimals);
      if (this.AlternateGridColor != this.AlternateGridColor_DefaultValue)
        hashtable.Add((object) "alternateGridColor", (object) this.AlternateGridColor);
      if (this.Breaks.IsDirty())
        hashtable.Add((object) "breaks", (object) this.Breaks.ToHashtable());
      if (this.Categories != this.Categories_DefaultValue)
        hashtable.Add((object) "categories", (object) this.Categories);
      double? ceiling = this.Ceiling;
      double? nullable1 = this.Ceiling_DefaultValue;
      if ((ceiling.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (ceiling.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "ceiling", (object) this.Ceiling);
      if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
        hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
      bool? endOnTick = this.EndOnTick;
      bool? nullable2 = this.EndOnTick_DefaultValue;
      if ((endOnTick.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (endOnTick.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "endOnTick", (object) this.EndOnTick);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      nullable1 = this.Floor;
      double? nullable3 = this.Floor_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "floor", (object) this.Floor);
      if (this.GridLineColor != this.GridLineColor_DefaultValue)
        hashtable.Add((object) "gridLineColor", (object) this.GridLineColor);
      if (this.GridLineDashStyle != this.GridLineDashStyle_DefaultValue)
        hashtable.Add((object) "gridLineDashStyle", (object) Highcharts.FirstCharacterToLower(this.GridLineDashStyle.ToString()));
      nullable3 = this.GridLineWidth;
      nullable1 = this.GridLineWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "gridLineWidth", (object) this.GridLineWidth);
      nullable1 = this.GridZIndex;
      nullable3 = this.GridZIndex_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "gridZIndex", (object) this.GridZIndex);
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      if (this.Labels.IsDirty())
        hashtable.Add((object) "labels", (object) this.Labels.ToHashtable());
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      nullable3 = this.LineWidth;
      nullable1 = this.LineWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      nullable1 = this.LinkedTo;
      nullable3 = this.LinkedTo_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      nullable3 = this.Max;
      nullable1 = this.Max_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "max", (object) this.Max);
      nullable1 = this.MaxPadding;
      nullable3 = this.MaxPadding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "maxPadding", (object) this.MaxPadding);
      nullable3 = this.Min;
      nullable1 = this.Min_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "min", (object) this.Min);
      nullable1 = this.MinPadding;
      nullable3 = this.MinPadding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minPadding", (object) this.MinPadding);
      nullable3 = this.MinRange;
      nullable1 = this.MinRange_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minRange", (object) this.MinRange);
      nullable1 = this.MinTickInterval;
      nullable3 = this.MinTickInterval_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minTickInterval", (object) this.MinTickInterval);
      if (this.MinorGridLineColor != this.MinorGridLineColor_DefaultValue)
        hashtable.Add((object) "minorGridLineColor", (object) this.MinorGridLineColor);
      if (this.MinorGridLineDashStyle != this.MinorGridLineDashStyle_DefaultValue)
        hashtable.Add((object) "minorGridLineDashStyle", (object) Highcharts.FirstCharacterToLower(this.MinorGridLineDashStyle.ToString()));
      nullable3 = this.MinorGridLineWidth;
      nullable1 = this.MinorGridLineWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minorGridLineWidth", (object) this.MinorGridLineWidth);
      if (this.MinorTickColor != this.MinorTickColor_DefaultValue)
        hashtable.Add((object) "minorTickColor", (object) this.MinorTickColor);
      if (this.MinorTickInterval != this.MinorTickInterval_DefaultValue)
        hashtable.Add((object) "minorTickInterval", (object) this.MinorTickInterval);
      nullable1 = this.MinorTickLength;
      nullable3 = this.MinorTickLength_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minorTickLength", (object) this.MinorTickLength);
      if (this.MinorTickPosition != this.MinorTickPosition_DefaultValue)
        hashtable.Add((object) "minorTickPosition", (object) Highcharts.FirstCharacterToLower(this.MinorTickPosition.ToString()));
      nullable3 = this.MinorTickWidth;
      nullable1 = this.MinorTickWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minorTickWidth", (object) this.MinorTickWidth);
      nullable1 = this.Offset;
      nullable3 = this.Offset_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "offset", (object) this.Offset);
      nullable2 = this.Opposite;
      bool? nullable4 = this.Opposite_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "opposite", (object) this.Opposite);
      if (this.PlotBands != this.PlotBands_DefaultValue)
        hashtable.Add((object) "plotBands", (object) this.HashifyList((IEnumerable) this.PlotBands));
      if (this.PlotLines != this.PlotLines_DefaultValue)
        hashtable.Add((object) "plotLines", (object) this.HashifyList((IEnumerable) this.PlotLines));
      hashtable.Add((object) "reversed", (object) this.Reversed);
      nullable4 = this.ShowEmpty;
      nullable2 = this.ShowEmpty_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showEmpty", (object) this.ShowEmpty);
      nullable2 = this.ShowFirstLabel;
      nullable4 = this.ShowFirstLabel_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showFirstLabel", (object) this.ShowFirstLabel);
      nullable4 = this.ShowLastLabel;
      nullable2 = this.ShowLastLabel_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showLastLabel", (object) this.ShowLastLabel);
      nullable3 = this.StartOfWeek;
      nullable1 = this.StartOfWeek_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "startOfWeek", (object) this.StartOfWeek);
      nullable2 = this.StartOnTick;
      nullable4 = this.StartOnTick_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "startOnTick", (object) this.StartOnTick);
      nullable1 = this.TickAmount;
      nullable3 = this.TickAmount_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "tickAmount", (object) this.TickAmount);
      if (this.TickColor != this.TickColor_DefaultValue)
        hashtable.Add((object) "tickColor", (object) this.TickColor);
      nullable3 = this.TickInterval;
      nullable1 = this.TickInterval_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "tickInterval", (object) this.TickInterval);
      nullable1 = this.TickLength;
      nullable3 = this.TickLength_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "tickLength", (object) this.TickLength);
      nullable3 = this.TickPixelInterval;
      nullable1 = this.TickPixelInterval_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "tickPixelInterval", (object) this.TickPixelInterval);
      if (this.TickPosition != this.TickPosition_DefaultValue)
        hashtable.Add((object) "tickPosition", (object) Highcharts.FirstCharacterToLower(this.TickPosition.ToString()));
      if (this.TickPositioner != this.TickPositioner_DefaultValue)
      {
        hashtable.Add((object) "tickPositioner", (object) this.TickPositioner);
        Highcharts.AddFunction("XAxisTickPositioner.tickPositioner", this.TickPositioner);
      }
      if (this.TickPositions != this.TickPositions_DefaultValue)
        hashtable.Add((object) "tickPositions", (object) this.TickPositions);
      nullable1 = this.TickWidth;
      nullable3 = this.TickWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "tickWidth", (object) this.TickWidth);
      if (this.TickmarkPlacement != this.TickmarkPlacement_DefaultValue)
        hashtable.Add((object) "tickmarkPlacement", (object) Highcharts.FirstCharacterToLower(this.TickmarkPlacement.ToString()));
      if (this.Title.IsDirty())
        hashtable.Add((object) "title", (object) this.Title.ToHashtable());
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
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