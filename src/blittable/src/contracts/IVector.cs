//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVector : IPrimitive
    {
        /// <summary>
        /// The vector dimension/length
        /// </summary>
        uint N {get;}
    }

    /// <summary>
    /// Defines a finite sequence of primal values
    /// </summary>
    /// <typeparam name="T">The storage cell type</typeparam>
    [Free]
    public interface IVector<T> : IVector, IPrimitive<T>
        where T : unmanaged
    {
        /// <summary>
        /// Access a vector component i where i=0,...,N-1
        /// </summary>
        ref T this[uint i] {get;}

        Span<T> Cells {get;}

        BlittableKind IPrimitive.TypeKind
            => BlittableKind.Vector;
    }
}