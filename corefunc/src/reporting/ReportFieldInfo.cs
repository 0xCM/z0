//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ReportFieldInfo
    {
        public readonly string Name;

        public readonly int? Width;

        public static ReportFieldInfo Define(string name, int? width)
            => new ReportFieldInfo(name,width);
       
        ReportFieldInfo(string name, int? width)
        {
            this.Name = name;
            this.Width = width;
        }        
    }
}