//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Defines a sequence of K-kinded hex chars
    /// </summary>
    public readonly struct HexString<K>
        where K : unmanaged
    {
        readonly StringRef Ref;

        [MethodImpl(Inline)]
        public HexString(StringRef src)
            => Ref = src;

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Chars(K index)
            => cover((char*)(Ref.BaseAddress + z.uint8(index)*8), 2);

        [MethodImpl(Inline)]
        public unsafe string String(K index)
            => @as<char,string>(@ref<char>((char*)(Ref.BaseAddress + z.uint8(index)*8)));

        public static HexString<K> Empty
            => new HexString<K>(StringRef.Empty);
    }
}