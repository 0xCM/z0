//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    using api = DataLayouts;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct DataLayout<T,R> : IDataLayout<DataLayout<T,R>,LayoutPart<T,R>,T>
        where T : unmanaged
        where R : unmanaged
    {
        public LayoutIdentity<T> Id {get;}

        readonly TableSpan<LayoutPart<T,R>> Data;

        [MethodImpl(Inline)]
        public DataLayout(LayoutIdentity<T> id, LayoutPart<T,R>[] parts)
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

        public TableSpan<LayoutPart<T,R>> Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<LayoutPart<T,R>> Partitions
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref LayoutPart<T,R> FirstPartition
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref LayoutPart<T,R> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public BitSize Width
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
        public static implicit operator DataLayout(DataLayout<T,R> src)
            => api.untyped(src);
    }
}