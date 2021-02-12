//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    /// <summary>
    /// Characterizes a sequence of bits with external semantics
    /// </summary>
    public interface ISymbol : ITextual
    {

    }

    /// <summary>
    /// Characterizes a parametric <see cref='ISymbol'/> value
    /// </summary>
    /// <typeparam name="S">The symbol value type</typeparam>
    public interface ISymbol<S> : ISymbol
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        S Value {get;}

        string ITextual.Format()
            => string.Format("{0}", Value);
    }

    public interface ISymbol<S,T> : ISymbol<S>
        where T : unmanaged
    {
        /// <summary>
        /// The <typeparamref name='T' /> cell bit-width
        /// </summary>
        ushort SegWidth
            => (ushort)width<T>();

    }

    public interface ISymbol<S,T,N> : ISymbol<S,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// The bit-width value determined by <typeparamref name='N' />
        /// </summary>
        ushort SymWidth
            => (ushort)nat64u<N>();

        /// <summary>
        /// The maximum number of symbols that can be packed into a storage cell
        /// </summary>
        ushort Capacity
            => (ushort)(SegWidth/SymWidth);
    }

    public interface ISymbol<H,S,T,N> : ISymbol<S,T,N>
        where H : unmanaged, ISymbol<H,S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}