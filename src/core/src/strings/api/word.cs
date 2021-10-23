//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Strings;

    using static Root;

    partial struct strings
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Word<S> word<S>(in StringBuffer<S> src, long index, long length)
            where S : unmanaged
                => new Word<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Word<S> word<S>(in StringBuffer<S> src, ulong index, ulong length)
            where S : unmanaged
                => new Word<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstWord<S> word<S>(in EmbeddedWord<S> src, ulong index, ulong length)
            where S : unmanaged
                => new ConstWord<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ConstWord<S> word<S>(in EmbeddedWord<S> src, long index, long length)
            where S : unmanaged
                => new ConstWord<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static ConstWord word(in EmbeddedWord src, ulong index, ulong length)
            => new ConstWord(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static ConstWord word(in EmbeddedWord src, long index, long length)
            => new ConstWord(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static Word word(in StringBuffer src, long index, long length)
            => new Word(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static Word word(in StringBuffer src, ulong index, ulong length)
            => new Word(src.Address(index), (uint)length);
    }
}