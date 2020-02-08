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
        /// Determines whether a parameter has a parametrically-identified attribute
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <typeparam name="A">The attribute type to check</typeparam>
        public static bool Attributed<A>(this ParameterInfo p)
            where A : Attribute
                => Attribute.IsDefined(p,typeof(A));


    }
}