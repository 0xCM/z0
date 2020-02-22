//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    public static partial class Identity
    {
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string host(Type t)
        {
            var defaultName = t.Name.ToLower();
            var query = from a in t.CustomAttribute<ApiHostAttribute>()
                        where a.HostName.IsNotBlank()
                        select a.HostName;
            return query.ValueOrDefault(defaultName);            
        }    
    }
}