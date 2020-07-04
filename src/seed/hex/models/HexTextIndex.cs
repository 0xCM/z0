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

    public readonly struct HexTextIndex<K>
        where K : unmanaged, Enum
    {        
        public readonly StringRef[] Refs;

        [MethodImpl(Inline)]
        public HexTextIndex(params StringRef[] src)
            => Refs = src;
        
        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Chars(uint index)
        {
            ref var src = ref Refs[index];
            return cover(src.Address.Pointer<char>(), src.Length);
        }

        [MethodImpl(Inline)]        
        public unsafe string String(uint index)    
           => Refs[index].Text;    
        
        public unsafe string this[uint index]
        {
            [MethodImpl(Inline)]        
            get => String(index);
        }

        public static HexTextIndex<K> Empty 
            => new HexTextIndex<K>(StringRef.Empty);
    }
}