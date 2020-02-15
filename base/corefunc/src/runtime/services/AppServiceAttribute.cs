//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    [AttributeUsage(AttributeTargets.Class)]
    public class AppServiceAttribute : Attribute
    {
        public static string GetLabel(Type host)
            => host.CustomAttribute<AppServiceAttribute>().TryMap(x => x.Label).ValueOrDefault(string.Empty);
            
        public AppServiceAttribute(string Label = null)
        {
            this.Label = Label ?? string.Empty;
        }

        public string Label {get;}
    }
}