//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a key-parametric indexed view over <see cref='MemSeg'/> values
    /// </summary>
    public readonly struct MemorySlots<K>
        where K : unmanaged
    {
        readonly MemSeg[] Data;

        [MethodImpl(Inline)]
        public MemorySlots(MemSeg[] slots)
            => Data = slots;

        [MethodImpl(Inline)]
        public ref readonly MemSeg Lookup(K index)
            => ref skip(Data, uint32(index));

        public ref readonly MemSeg this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref MemSeg First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public MemSeg[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref MemSeg this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}