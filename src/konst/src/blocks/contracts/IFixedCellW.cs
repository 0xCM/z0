//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using static Konst;

    /// <summary>
    ///  Characterizes a fixed type with storage and reification types of equal size
    /// </summary>
    /// <typeparam name="S">The storage type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFixedCellW<W> : IFixedCell
        where W : struct, ITypeWidth
    {
        TypeWidth TypeWidth
            => Widths.type<W>();

        int IFixedCell.BitWidth
            => (int)TypeWidth;

        int IFixedCell.ByteCount
            => ((int)TypeWidth)/8;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedCellW<F,W> : IFixedCellW<W>
        where F : struct, IFixedCellW<F,W>
        where W : struct, ITypeWidth
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedCellW<F,W,T> : IFixedCell<F,T>, IFixedCellW<F,W>
        where F : struct, IFixedCellW<F,W,T>
        where W : struct, ITypeWidth
        where T : struct
    {

    }
}