//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.ComponentModel;
    using System.Collections.Concurrent;

    using static RootShare;
    
    partial class RootReflections
    {        

        /// <summary>
        /// Gets the type attributions for the specified assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IDictionary<Type, A> TypeAttributions<A>(this Assembly a, Func<Type,bool> pred = null)
            where A : Attribute
        {
            var f = pred ?? (t => true);
            var q = from t in a.GetTypes()
                    where Attribute.IsDefined(t, typeof(A)) && f(t)
                    let attrib = t.GetCustomAttribute<A>()
                    select new
                    {
                        Type = t,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Type, x => x.Attribute);
        }

    }

}