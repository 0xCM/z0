//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static memory;

    /// <summary>
    /// Characterizes a type that occupies a fixed amount of space at runtime
    /// </summary>
    [Free]
    public interface IDataCell : ITextual
    {
        /// <summary>
        /// The invariant number of bits covered by the reifying type
        /// </summary>
        uint Width {get;}

        ByteSize Size {get;}

        uint EffectiveWidth
            => Width;
    }

    [Free]
    public interface IDataCell<T> : IDataCell
        where T : struct
    {
        Span<byte> CellBytes
            => bytes((T)this);

        uint IDataCell.Width
            => width<T>();

        ByteSize IDataCell.Size
            => size<T>();

        NumericKind NumericKind
            => Numeric.kind<T>();

        NumericWidth NumericWidth
            => (NumericWidth)(size<T>()*8);
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

        uint IDataCell.Width
            => (uint)TypeWidth;

        ByteSize IDataCell.Size
            => ((int)TypeWidth)/8;
    }
}