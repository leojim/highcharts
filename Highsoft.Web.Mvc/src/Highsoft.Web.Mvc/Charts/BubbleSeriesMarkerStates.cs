﻿
// Type: Highsoft.Web.Mvc.Charts.BubbleSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class BubbleSeriesMarkerStates : BaseObject
  {
    public BubbleSeriesMarkerStatesHover Hover { get; set; }

    private BubbleSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public BubbleSeriesMarkerStatesSelect Select { get; set; }

    private BubbleSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public BubbleSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new BubbleSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new BubbleSeriesMarkerStatesSelect();
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