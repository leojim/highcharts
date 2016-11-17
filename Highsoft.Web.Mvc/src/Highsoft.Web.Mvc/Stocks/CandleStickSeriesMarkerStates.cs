﻿
// Type: Highsoft.Web.Mvc.Stocks.CandleStickSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class CandleStickSeriesMarkerStates : BaseObject
  {
    public CandleStickSeriesMarkerStatesHover Hover { get; set; }

    private CandleStickSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public CandleStickSeriesMarkerStatesSelect Select { get; set; }

    private CandleStickSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public CandleStickSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new CandleStickSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new CandleStickSeriesMarkerStatesSelect();
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