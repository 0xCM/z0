//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a sorted <see cref='MemoryAddress'/> index
    /// </summary>
    public readonly struct MemoryAddresses : ISortedIndex<MemoryAddress>
    {
        readonly Index<MemoryAddress> Data;

        [MethodImpl(Inline)]
        internal MemoryAddresses(MemoryAddress[] src)
            => Data = src;

        public ReadOnlySpan<MemoryAddress> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref readonly MemoryAddress First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }
    }
}