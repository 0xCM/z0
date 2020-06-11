//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct MemBlock<T>
        where T : struct
    {
        internal readonly MemoryRef Ref;

        public static MemBlock<T> Empty => From(MemoryRef.Empty);

        [MethodImpl(Inline)]
        public static implicit operator MemBlock(MemBlock<T> src)
            => MemBlock.From(src.Ref);

        [MethodImpl(Inline)]
        public static MemBlock<T> From(MemoryRef src)
            => new MemBlock<T>(src);

        [MethodImpl(Inline)]
        public MemBlock(MemoryRef src)
            => Ref = src;
    }
}