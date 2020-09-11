//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;




    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitShiftKind<K,W,T> : IBitShiftKind<K,T>
        where W : unmanaged, ITypeWidth
        where K : unmanaged, IBitShiftKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric canonical operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface ICanonicalKind<F,W,T> : ICanonicalKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, ICanonicalKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }
}