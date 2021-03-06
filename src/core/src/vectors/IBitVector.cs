//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public interface IBitVector : ITextual<IBitVector,BitFormat>
    {
        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        Span<byte> Bytes {get;}

        /// <summary>
        /// Selects an index-identified mutable 8-bit segment from the source vector
        /// </summary>
        /// <param name="index">The byte-relative segment index</param>
        ref byte Byte(uint index)
            => ref seek(Bytes, index);
    }

    public interface IBitVector<T> : IBitVector
        where T : unmanaged
    {
        /// <summary>
        /// The value over which the bitvector is defined
        /// </summary>
        T State {get;}

        Span<byte> IBitVector.Bytes
            => bytes(State);

        TypeWidth Width
            => (TypeWidth)width<T>();
    }

    public interface IBitVector<V,T> : IBitVector<T>, IEquatable<V>
        where V : unmanaged, IBitVector
        where T : unmanaged
    {

    }
}