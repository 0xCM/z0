//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Characterizes types/kinds with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind : IKind<FixedWidth>
    {
        
    }

    public interface IFixedNumericKind : IKind<FixedWidth>, IKind<NumericKind>
    {

    }

    public interface IFixedKind<F> : IFixedKind, IFixedWidth
        where F : unmanaged, IFixed
    {
        FixedWidth IFixedWidth.FixedWidth 
        {
            [MethodImpl(Inline)]
            get =>  (FixedWidth)bitsize<F>();
        }
   
        FixedWidth IKind<FixedWidth>.Classifier 
            => (FixedWidth)bitsize<F>();

    }

    public interface IFixedKind<F,T> : IFixedNumericKind, IFixedWidth
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
            => NumericType.kind<T>();


    }

}