//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="index">The 0-based part index</param>
        public static Option<SegmentedIdentity> segmented(OpIdentity src, int index)
            => from p in component(src, index)
                from s in identify(p)
                select s;

        /// <summary>
        /// Defines a segmented type identity predicated on type width numeric kind specifications
        /// </summary>
        /// <param name="name">The type name</param>
        /// <param name="wk">The width kind</param>
        /// <param name="nk">The numeric kind</param>
        [MethodImpl(Inline), Op]
        public static TypeIdentity segmented(string name, TypeWidth wk, NumericKind nk)
            => new TypeIdentity($"{name}{wk.FormatValue()}x{nk.Format()}");
    }
}