//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a type that occupies a fixed amount of space at runtime
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IFixedCell : ITextual
    {
        /// <summary>
        /// The invariant number of bits covered by the reifying type
        /// </summary>
        int BitWidth {get;}

        int ByteCount {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedCell<T> : IFixedCell, IContented<T>
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedCell<F,T> : IFixedCell<T>, IEquatable<F>, INullary<F,T>
        where F : struct, IFixedCell<F,T>
    {

    }
}