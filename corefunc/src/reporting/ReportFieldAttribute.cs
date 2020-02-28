//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ReportFieldAttribute : Attribute
    {
        public string Name {get;}

        public int? Index {get;}
        
        public int? Width {get;}

        public ReportFieldAttribute(object id)
        {
            var evalue = (Enum)id;
            var ivalue = Enums.numeric<ulong>(evalue);
            Name = $"{evalue}";
            Index = (int)ivalue;
            Width = (int)(ivalue >> 32);
        }
    }
}