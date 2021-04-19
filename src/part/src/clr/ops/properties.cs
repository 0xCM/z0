//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static memory;

    partial struct Clr
    {
        /// <summary>
        /// Selects all instance/static and public/non-public properties declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrProperty> properties(Type src)
            => recover<PropertyInfo,ClrProperty>(properties(src, out var _));

        [MethodImpl(Inline), Op]
        public static PropertyInfo[] properties(Type src, out PropertyInfo[] dst)
            => dst = src.GetProperties(BF);
    }
}