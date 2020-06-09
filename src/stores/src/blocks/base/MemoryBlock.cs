//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct MemoryBlock
    {
        internal readonly MemoryRef Ref;

        public static MemoryBlock Empty => From(MemoryRef.Empty);

        [MethodImpl(Inline)]
        public static MemoryBlock From(MemoryRef src)
            => new MemoryBlock(src);

        [MethodImpl(Inline)]
        public static MemoryBlock<T> From<T>(MemoryRef src)
            where T : struct
                => new MemoryBlock<T>(src);

        [MethodImpl(Inline)]
        public MemoryBlock(MemoryRef src)
            => Ref = src;
    }

    public readonly struct MemoryBlock<T>
        where T : struct
    {
        internal readonly MemoryRef Ref;

        public static MemoryBlock<T> Empty => From(MemoryRef.Empty);

        [MethodImpl(Inline)]
        public static implicit operator MemoryBlock(MemoryBlock<T> src)
            => MemoryBlock.From(src.Ref);

        [MethodImpl(Inline)]
        public static MemoryBlock<T> From(MemoryRef src)
            => new MemoryBlock<T>(src);

        [MethodImpl(Inline)]
        public MemoryBlock(MemoryRef src)
            => Ref = src;
    }
}