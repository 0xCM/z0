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

    using static PartIdentity;

    partial class XTend
    {
        /// <summary>
        /// Selects the literal fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Literal(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsLiteral);

        /// <summary>
        /// Selects the literal fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Literal(this FieldInfo[] src)
            => src.Where(x => x.IsLiteral).ToArray();
    }
}