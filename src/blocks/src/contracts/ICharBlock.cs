//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public interface ICharBlock<T> : ITextual, IComparable<T>, IEquatable<T>, IBlittable<T>, IDataBlock<T>
        where T : unmanaged, ICharBlock<T>
    {
        Span<char> Data {get;}

        ReadOnlySpan<char> String {get;}

        int Length {get;}

        uint Capacity {get;}

        ByteSize IDataBlock.Size
            => Length*2;

        Span<byte> IDataBlock.Bytes
            => recover<byte>(Data);

        Span<byte> IBlittable.Edit
            => recover<byte>(Data);

        ReadOnlySpan<byte> IBlittable.View
            => recover<byte>(Data);

        int IComparable<T>.CompareTo(T src)
            => Data.SequenceCompareTo(src.Data);

        bool IEquatable<T>.Equals(T src)
            => Data.SequenceEqual(src.Data);
        ref char First
            => ref first(Data);
    }
}