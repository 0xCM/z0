//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static zfunc;

    public static class CodeGenX
    {
        public static string FormatDataProp<T>(this Vector128<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.ToSpan().AsBytes(), propname);

        public static string FormatDataProp<T>(this Vector256<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.ToSpan().AsBytes(), propname);

        public static string FormatDataProp<T>(this Span<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.AsBytes(), propname);

        public static string FormatDataProp<T>(this ReadOnlySpan<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.AsBytes(), propname);

        /// <summary>
        /// Formats a property declaration that specifies the span content
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="name">The property name</param>
        /// <typeparam name="T">The serialization type</typeparam>
        static string FormatProperty_other<T>(this ReadOnlySpan<T> src, string name)
            where T : unmanaged
        {
            var bytes = src.AsBytes();
            var decl = $"public static ReadOnlySpan<byte> {name}{bitsize<T>()}{Classified.primalsig(PrimalType.kind<T>())}";
            var data = embrace(bytes.FormatHexBytes(sep: AsciSym.Comma, specifier:true));
            var rhs = $"new byte[{bytes.Length}]" + data;
            return $"{decl} => {rhs};";
        }

    }

}