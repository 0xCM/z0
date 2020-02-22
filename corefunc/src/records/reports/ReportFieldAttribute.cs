//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    [AttributeUsage(AttributeTargets.Property)]
    public class ReportFieldAttribute : Attribute
    {
        public ReportFieldAttribute()
        {
            this.Name = string.Empty;
        }

        public ReportFieldAttribute(object Width)
        {
            this.Name = string.Empty;
            this.Width = (int)Convert.ChangeType(Width, typeof(int));
        }

        public ReportFieldAttribute(string name, object width = null, int? position = null)
        {
            this.Name = name;
            this.Position = position;
            this.Width = width != null ? (int)Convert.ChangeType(width, typeof(int)) : (int?)null;
        }

        public string Name {get;}

        public int? Position {get;}
        
        public int? Width {get;}
    }
}