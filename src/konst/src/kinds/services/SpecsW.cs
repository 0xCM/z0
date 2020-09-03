//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IArithmeticKind<F,W,T> : IArithmeticKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IArithmeticKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }    

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitLogicKind<F,W,T> : IBitLogicKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IBitLogicKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }

    public interface IFixedOpClass<W,E> : IFixedOpClass<E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {
        TypeWidth IFixedOpClass.Width => Widths.type<W>();
    }
    
    public interface IFixedOpClassF<F,W,E> : IFixedOpClass<W,E>, IOpClassF<F,E>
        where F : struct, IFixedOpClassF<F,W,E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IBitFunctionKind<F,W,T> : IBitFunctionKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IBitFunctionKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }    

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric comparison operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IComparisonKind<F,W,T> : IComparisonKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IComparisonKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth => Widths.type<W>();
    }    


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