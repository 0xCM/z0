//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    /// <summary>
    /// Characterizes a numeric kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedNumericKind : IKind<FixedWidth>, IKind<NumericKind>
    {

    }

    /// <summary>
    /// Characterizes a reified numeric kind with which a fixed type is associated
    /// </summary>
    public interface IFixedNumericKind<F,T> : IFixedNumericKind, IFixedWidth
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        FixedWidth IFixedWidth.FixedWidth 
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)bitsize<F>();
        }

        FixedWidth IKind<FixedWidth>.Classifier 
            => (FixedWidth)bitsize<F>();

        NumericKind IKind<NumericKind>.Classifier 
            => Numeric.kind<T>();
    }
}