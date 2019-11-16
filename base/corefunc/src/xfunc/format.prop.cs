//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Formats a property declaration that specifies the span content
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="name">The property name</param>
        /// <typeparam name="T">The serialization type</typeparam>
        public static string FormatProperty<T>(this ReadOnlySpan<T> src, string name)
            where T : unmanaged
        {
            var bytes = src.AsBytes();
            var decl = $"public static ReadOnlySpan<byte> {name}{bitsize<T>()}{suffix<T>()}";
            var data = embrace(bytes.FormatHex(sep: AsciSym.Comma, specifier:true));
            var rhs = $"new byte[{bytes.Length}]" + data;
            return $"{decl} => {rhs};";
        }

        /// <summary>
        /// Formats a property declaration that specifies the span content
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="name">The property name</param>
        /// <typeparam name="T">The serialization type</typeparam>
        public static string FormatProperty<T>(this Span<T> src, string name)
            where T : unmanaged
                => src.ReadOnly().FormatProperty<T>(name);
    }

}