//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Defines a finite sequence of primal values
    /// </summary>
    /// <typeparam name="T">The storage cell type</typeparam>
    [Free]
    public interface IVector<T> : IPrimitive<T>
        where T : unmanaged
    {
        /// <summary>
        /// The vector dimension/length
        /// </summary>
        uint N {get;}

        /// <summary>
        /// Access a vector component i where i=0,...,N-1
        /// </summary>
        ref T this[uint i] {get;}

        TypeKind IPrimitive.TypeKind
            => TypeKind.Vector;
    }
}