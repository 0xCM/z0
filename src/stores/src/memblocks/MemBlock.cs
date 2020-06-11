//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct MemBlock
    {
        internal readonly MemoryRef Ref;

        public static MemBlock Empty => From(MemoryRef.Empty);

        [MethodImpl(Inline)]
        public static MemBlock From(MemoryRef src)
            => new MemBlock(src);

        [MethodImpl(Inline)]
        public static MemBlock<T> From<T>(MemoryRef src)
            where T : struct
                => new MemBlock<T>(src);

        [MethodImpl(Inline)]
        public MemBlock(MemoryRef src)
            => Ref = src;
    }
}