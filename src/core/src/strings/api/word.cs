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
        [MethodImpl(Inline), Op]
        public static Word word(char[] src)
            => new Word(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static WordRef<S> word<S>(in WordRefs<S> src, ulong index, ulong length)
            where S : unmanaged
                => new WordRef<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static WordRef<S> word<S>(in WordRefs<S> src, long index, long length)
            where S : unmanaged
                => new WordRef<S>(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static WordRef word(in WordRefs src, ulong index, ulong length)
            => new WordRef(src.Address(index), (uint)length);

        [MethodImpl(Inline), Op]
        public static WordRef word(in WordRefs src, long index, long length)
            => new WordRef(src.Address(index), (uint)length);
    }
}