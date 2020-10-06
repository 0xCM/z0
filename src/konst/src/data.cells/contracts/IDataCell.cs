//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a type that occupies a fixed amount of space at runtime
    /// </summary>
    [Free]
    public interface IDataCell : ITextual
    {
        /// <summary>
        /// The invariant number of bits covered by the reifying type
        /// </summary>
        uint BitWidth {get;}

        ByteSize Size {get;}
    }

    [Free]
    public interface IDataCell<T> : IDataCell
        where T : struct
    {
        uint IDataCell.BitWidth
            => (uint)Unsafe.SizeOf<T>()*8;

        ByteSize IDataCell.Size
            => Unsafe.SizeOf<T>();

        NumericKind NumericKind
            => NumericKinds.kind<T>();

        NumericWidth NumericWidth
            => (NumericWidth)(z.size<T>()*8);
    }

    [Free]
    public interface IDataCell<C,T> : IDataCell<T>, IEquatable<C>, INullary<C,T>
        where C : struct, IDataCell<C,T>
        where T : struct
    {

    }

    [Free]
    public interface IDataCell<C,W,T> : IDataCell<C,T>
        where C : unmanaged, IDataCell<C,W,T>
        where W : unmanaged, ITypeWidth
        where T : struct
    {
        TypeWidth TypeWidth
            => Widths.type<W>();

        uint IDataCell.BitWidth
            => (uint)TypeWidth;

        ByteSize IDataCell.Size
            => ((int)TypeWidth)/8;
    }
}