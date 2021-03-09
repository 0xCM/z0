//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    using api = SymbolStores;

    /// <summary>
    /// Characterizes a sequence of bits with external semantics
    /// </summary>
    public interface ISymbol : ITextual
    {
        Identifier Name {get;}
    }

    /// <summary>
    /// Characterizes a parametric <see cref='ISymbol'/> value
    /// </summary>
    /// <typeparam name="S">The symbol value type</typeparam>
    public interface ISymbol<S> : ISymbol
        where S : unmanaged
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        S Value {get;}

        Identifier ISymbol.Name
            => api.name(this);

        string ITextual.Format()
            => string.Format("{0}", Value);
    }

    public interface ISymbol<S,T> : ISymbol<S>
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The <typeparamref name='T' /> cell bit-width
        /// </summary>
        ushort SegWidth
            => (ushort)width<T>();
    }

    public interface ISymbol<S,T,N> : ISymbol<S,T>
        where S : unmanaged
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