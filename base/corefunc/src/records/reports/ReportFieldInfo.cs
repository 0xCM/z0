//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    public class ReportFieldInfo
    {
        public static ReportFieldInfo Define(PropertyInfo src)
        {
            var attrib = src.CustomAttribute<ReportFieldAttribute>();
            return attrib.Map(a => new ReportFieldInfo(src, a.Name.IfBlank(src.Name), a.Width), () => new ReportFieldInfo(src, src.Name,null));
        }

        ReportFieldInfo(PropertyInfo src, string name, int? width)
        {
            this.Source = src;
            this.Name = name;
            this.Width = width;
        }
        
        public string Name {get;}

        public int? Width {get;}

        public PropertyInfo Source {get;}         
    }
}