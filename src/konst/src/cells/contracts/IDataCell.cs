//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    /// <summary>
    /// Characterizes a type that occupies a fixed amount of space at runtime
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IDataCell : ITextual
    {
        /// <summary>
        /// The invariant number of bits covered by the reifying type
        /// </summary>
        int BitWidth {get;}

        int ByteCount {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDataCell<F,T> : IDataCell, IContented<T>, IEquatable<F>, INullary<F,T>
        where F : struct, IDataCell<F,T>
        where T : struct
    {
        int IDataCell.BitWidth
            => Unsafe.SizeOf<T>()*8;

        int IDataCell.ByteCount
            => Unsafe.SizeOf<T>();

        NumericKind NumericKind
            => NumericKinds.kind<T>();

        NumericWidth NumericWidth
            => (NumericWidth)(z.size<T>()*8);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDataCell<F,W,T> : IDataCell<F,T>//, IDataCellW<F,W,T>
        where F : unmanaged, IDataCell<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : struct
    {
        TypeWidth TypeWidth
            => Widths.type<W>();

        int IDataCell.BitWidth
            => (int)TypeWidth;

        int IDataCell.ByteCount
            => ((int)TypeWidth)/8;
    }
}