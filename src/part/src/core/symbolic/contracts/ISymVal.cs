//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    /// <summary>
    /// Characterizes a sequence of bits with external semantics
    /// </summary>
    public interface ISymVal : ITextual
    {

    }

    /// <summary>
    /// Characterizes a parametric <see cref='ISymVal'/> value
    /// </summary>
    /// <typeparam name="S">The symbol value type</typeparam>
    public interface ISymVal<S> : ISymVal
        where S : unmanaged
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        S Value {get;}

        string ITextual.Format()
            => Value.ToString();
    }

    public interface ISymVal<S,T> : ISymVal<S>
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The <typeparamref name='T' /> cell bit-width
        /// </summary>
        ushort SegWidth
            => (ushort)width<T>();
    }

    public interface ISymVal<S,T,N> : ISymVal<S,T>
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

    public interface ISymbol<H,S,T,N> : ISymVal<S,T,N>
        where H : unmanaged, ISymbol<H,S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}