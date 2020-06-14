//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
        
    partial class XTend
    {
        /// <summary>
        /// For a closed generic method, returns the supplied arguments; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="effective">Whether to yield effective types or types as reported by the framework reflection api</param>
        public static Type[] SuppliedTypeArgs(this MethodInfo m, bool effective = true)
            => m.IsConstructedGenericMethod ? 
                m.GenericParameters(effective) : Array.Empty<Type>();
    }
}