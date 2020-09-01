//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface INumericCell<F,T> : IFixedCell<F,T>
        where F : struct, INumericCell<F,T>
        where T : struct
    {
        int IFixedCell.BitWidth
            => Unsafe.SizeOf<T>()*8;

        int IFixedCell.ByteCount
            => Unsafe.SizeOf<T>();

        NumericKind NumericKind
            => NumericKinds.kind<T>();

        NumericWidth NumericWidth
            => (NumericWidth)(Unsafe.SizeOf<T>()*8);
    }

    public interface INumericCell<F,W,T> : INumericCell<F,T>
        where F : unmanaged, INumericCell<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : struct
    {

    }
}