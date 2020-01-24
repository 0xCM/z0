//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    [AttributeUsage(AttributeTargets.Property)]
    public class ReportFieldAttribute : Attribute
    {
        public ReportFieldAttribute()
        {
            this.Name = string.Empty;
        }

        public ReportFieldAttribute(int Width)
        {
            this.Width = Width;
            this.Name = string.Empty;
        }

        public ReportFieldAttribute(int Width, int Position)
        {
            this.Width = Width;
            this.Position = Position;
        }

        public ReportFieldAttribute(string Name)
        {
            this.Name = Name;
        }

        public ReportFieldAttribute(string Name, int Width)
        {
            this.Name = Name;
            this.Width = Width;
        }

        public ReportFieldAttribute(string Name, int Width, int Position)
        {
            this.Name = Name;
            this.Width = Width;
            this.Position = Position;
        }

        public string Name {get;}

        public int? Position {get;}
        
        public int? Width {get;}

    }
}