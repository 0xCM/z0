//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct strings
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringRef<S> substring<S>(in StringBuffer<S> src, long index, long length)
            where S : unmanaged
                => new StringRef<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringRef<S> substring<S>(in StringBuffer<S> src, ulong index, ulong length)
            where S : unmanaged
                => new StringRef<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstStringRef<S> substring<S>(in EmbeddedString<S> src, ulong index, ulong length)
            where S : unmanaged
                => new ConstStringRef<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstStringRef<S> substring<S>(in EmbeddedString<S> src, long index, long length)
            where S : unmanaged
                => new ConstStringRef<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static ConstStringRef substring(in EmbeddedString src, ulong index, ulong length)
            => new ConstStringRef(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static ConstStringRef substring(in EmbeddedString src, long index, long length)
            => new ConstStringRef(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static StringRef substring(in StringBuffer src, long index, long length)
            => new StringRef(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static StringRef substring(in StringBuffer src, ulong index, ulong length)
            => new StringRef(src.Address(index), (uint)length);
    }
}