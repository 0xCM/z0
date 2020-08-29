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

    /// <summary>
    /// Characterizes a sequence of bits with external semantics
    /// </summary>
    public interface ISymbol
    {
        /// <summary>
        /// The encoded symbol value
        /// </summary>
        BinaryCode Encoded {get;}
    }

    /// <summary>
    /// Characterizes a
    /// </summary>
    /// <typeparam name="S"></typeparam>
    public interface ISymbol<S> : ISymbol
        where S : unmanaged
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        S Value {get;}

        BinaryCode ISymbol.Encoded
            => bytes(Value);
    }

    public interface ISymbol<S,T> : ISymbol<S>
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The <typeparamref name='T' />-cell bit-width
        /// </summary>
        ushort SegWidth => (ushort)bitsize<T>();

        /// <summary>
        /// The <typeparamref name='T' />-cell value
        /// </summary>
        T Cell => Unsafe.As<S,T>(ref edit(Value));

    }

    public interface ISymbol<S,N,T> : ISymbol<S,T>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// The bit-width value determined by <typeparamref name='N' />
        /// </summary>
        ushort SymWidth
            => (ushort)value<N>();

        /// <summary>
        /// The maximum number of symbols that can be packed into a storage cell
        /// </summary>
        ushort Capacity
            => (ushort)(SegWidth/SymWidth);
    }
}