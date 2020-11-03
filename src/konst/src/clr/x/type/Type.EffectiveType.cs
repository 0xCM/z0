//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XClrQuery
    {
        /// <summary>
        /// Computes the effective type of the source <see cref='Type'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.ElementType() : src;
    }
}