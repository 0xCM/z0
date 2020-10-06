//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a resolver that produces values over bitwise-equivalent <typeparamref name='T'/> and <typeparamref name='C'/> domains
    /// </summary>
    /// <typeparam name="W">The common resolution width</typeparam>
    /// <typeparam name="C">The cell type, bitwise equivalent to the primitive resolution type</typeparam>
    /// <typeparam name="T">The primitive resolution type, bitwise equivalent to the cellular type</typeparam>
    [Free]
    public interface ICellResolver<W,C,T> : IPrimalResolver<W,T>
        where W : unmanaged, ITypeWidth
        where C : unmanaged, IDataCell<C,W,T>
        where T : unmanaged
    {

        void Resolve(ref C dst);

        void Resolve(uint count, Span<C> dst);
    }
}