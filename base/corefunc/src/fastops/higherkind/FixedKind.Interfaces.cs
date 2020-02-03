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
    public interface IFixedKind : IKind<FixedKind>
    {
        
    }

    public interface IFixedNumericKind : IKind<FixedKind,NumericKind>
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
   
        FixedKind IKind<FixedKind>.Classifier 
        {
             [MethodImpl(Inline)]
             get  => (FixedKind)FixedWidth;
        }
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

        /// <summary>
        /// The classification value
        /// </summary>
        FixedKind IKind<FixedKind,NumericKind>.Class1 
        {
            [MethodImpl(Inline)]
            get => (FixedKind)FixedWidth;
        }

        /// <summary>
        /// The classification value
        /// </summary>
        NumericKind IKind<FixedKind,NumericKind>.Class2 
        {
            [MethodImpl(Inline)]
            get => NumericType.kind<T>();
        }
    }

}