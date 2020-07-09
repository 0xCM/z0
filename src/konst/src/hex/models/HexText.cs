//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;

    /// <summary>
    /// Defines a sequence of K-kinded hex chars
    /// </summary>
    public readonly struct HexText<K>
        where K : unmanaged, Enum
    {        
        public readonly StringRef Ref;

        [MethodImpl(Inline)]
        public HexText(StringRef src)
            => Ref = src;
        
        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Chars(K index)
            => cover((char*)(Ref.Address + core.uint8(index)*8), 2);

        [MethodImpl(Inline)]        
        public unsafe string String(K index)
            => @as<char,string>(@ref<char>((char*)(Ref.Address + core.uint8(index)*8)));

        public static HexText<K> Empty 
            => new HexText<K>(StringRef.Empty);
    }
}