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

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Queries literal fields for their values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<object> LiteralValues(this IEnumerable<FieldInfo> src)
            => src.Literals().Select(f => f.GetRawConstantValue());

        /// <summary>
        /// Queries literal fields for their values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static object[] LiteralValues(this FieldInfo[] src)
            => src.Literals().Select(f => f.GetRawConstantValue()).ToArray();

        /// <summary>
        /// Queries literal fields for values of parametric type
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<T> LiteralValues<T>(this IEnumerable<FieldInfo> src)
            where T : unmanaged        
                => src.LiteralValues().Select(v => (T)v);
    }
}