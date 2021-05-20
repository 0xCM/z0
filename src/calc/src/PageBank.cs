//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = PageBlocks;

    public interface IPageBank<N,T>
        where T : unmanaged, IPageBlock<T>
        where N : unmanaged, ITypeNat
    {
        MemoryAddress BaseAddress {get;}

        uint PageCount
            => api.PageCount<T>();

        ByteSize Size => size<T>();

        MemoryRange Range
            => (BaseAddress, BaseAddress + Size);
    }


    public struct PageBank<N,T> : IPageBank<N,T>
        where T : unmanaged, IPageBlock<T>
        where N : unmanaged, ITypeNat
    {
        public ByteSize Size => size<T>();

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => address(Storage);
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => (BaseAddress, BaseAddress + Size);
        }

        public uint PageCount
        {
            [MethodImpl(Inline)]
            get => api.PageCount<T>();
        }

        [FixedAddressValueType]
        static T Storage;
    }
}