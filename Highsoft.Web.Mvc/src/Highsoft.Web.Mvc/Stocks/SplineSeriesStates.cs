﻿
// Type: Highsoft.Web.Mvc.Stocks.SplineSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class SplineSeriesStates : BaseObject
  {
    public SplineSeriesStatesHover Hover { get; set; }

    private SplineSeriesStatesHover Hover_DefaultValue { get; set; }

    public SplineSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new SplineSeriesStatesHover();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Hover.IsDirty())
        hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
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