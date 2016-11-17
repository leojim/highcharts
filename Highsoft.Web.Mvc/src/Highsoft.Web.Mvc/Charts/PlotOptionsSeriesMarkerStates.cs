﻿
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsSeriesMarkerStates : BaseObject
  {
    public PlotOptionsSeriesMarkerStatesHover Hover { get; set; }

    private PlotOptionsSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsSeriesMarkerStatesSelect Select { get; set; }

    private PlotOptionsSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsSeriesMarkerStatesSelect();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Hover.IsDirty())
        hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
      if (this.Select.IsDirty())
        hashtable.Add((object) "select", (object) this.Select.ToHashtable());
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