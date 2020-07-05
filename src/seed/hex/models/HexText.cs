//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    public readonly struct HexText
    {        
        public readonly StringRef Ref;

        [MethodImpl(Inline)]
        public HexText(StringRef src)
            => Ref = src;
        
        public static HexText Empty 
            => new HexText(StringRef.Empty);        
    }

    public readonly struct HexText<K>
        where K : unmanaged, Enum
    {        
        public readonly StringRef Ref;

        [MethodImpl(Inline)]
        public HexText(StringRef src)
            => Ref = src;
        
        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Chars(uint index)
            => cover((char*)(Ref.Address + index*8), 2);

        [MethodImpl(Inline)]        
        public unsafe string String(uint index)
            => @as<char,string>(ref @ref<char>((char*)(Ref.Address + index*8)));

        public static HexText<K> Empty 
            => new HexText<K>(StringRef.Empty);
    }
}