//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = DataLayouts;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct DataLayout<T> : IDataLayout<DataLayout<T>,LayoutPartition<T>,T>
        where T : unmanaged
    {
        public LayoutIdentity<T> Id {get;}

        readonly TableSpan<LayoutPartition<T>> Data;

        [MethodImpl(Inline)]
        public DataLayout(LayoutIdentity<T> id, LayoutPartition<T>[] parts)
        {
            Id = id;
            Data = parts;
        }

        public uint Index
        {
            [MethodImpl(Inline)]
            get => Id.Index;
        }

        public uint PartitionCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public TableSpan<LayoutPartition<T>> Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<LayoutPartition<T>> Partitions
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref LayoutPartition<T> FirstPartition
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref LayoutPartition<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => api.width(Partitions);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DataLayout(DataLayout<T> src)
            => api.untyped(src);
    }
}