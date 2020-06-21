//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class Root
    {     
        /// <summary>
        /// Gets type typecode of a parametrically-identified type
        /// </summary>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static TypeCode typecode<T>()
            => Type.GetTypeCode(typeof(T));

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => Imagine.bytes(src);        

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => Imagine.bytes(src);        

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => Imagine.bytes(src);
    }
}