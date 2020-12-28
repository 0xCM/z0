//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XClrQuery
    {
        /// <summary>
        /// Returns the <see cref='Enum'/> types defined in a specified <see cref='Assembly'/> sequence
        /// </summary>
        /// <param name="src">The assemblies to search</param>
        [MethodImpl(Inline), Op]
        public static Type[] Enums(this Assembly[] src)
            => src.Types().Enums();
    }
}