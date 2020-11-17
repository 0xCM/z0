//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ICellBits<T>
        where T : struct, IDataCell<T>
    {

    }

    public interface IScalarBits<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value over which the bitvector is defined
        /// </summary>
        T Scalar {get;}

        TypeWidth Width => (TypeWidth)z.bitwidth<T>();
    }

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
        [MethodImpl(Inline)]
        ref byte Byte(uint index)
            => ref seek(Bytes, index);
    }

    public interface IBitVector<V> : IBitVector, IEquatable<V>
        where V : struct, IBitVector
    {

    }

    public interface IBitVector<V,T> : IScalarBits<T>, IBitVector<V>
        where V : unmanaged, IBitVector
        where T : unmanaged
    {

    }
}