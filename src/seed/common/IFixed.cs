//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a type that occupies a fixed amount of space at runtime
    /// </summary>
    public interface IFixed
    {
        /// <summary>
        /// The invariant number of bits covered by the reifying type
        /// </summary>
        int BitWidth {get;}

        int ByteCount {get;}
    }

    /// <summary>
    ///  Characterizes a fixed type with storage and reification types of equal size
    /// </summary>
    /// <typeparam name="S">The storage type</typeparam>
    public interface IFixed<W> : IFixed
        where W : unmanaged, ITypeWidth
    {
        TypeWidth TypeWidth { [MethodImpl(Inline)] get => Widths.type<W>(); }

        int IFixed.BitWidth { [MethodImpl(Inline)] get => (int)TypeWidth; }

        int IFixed.ByteCount { [MethodImpl(Inline)] get=> ((int)TypeWidth)/8; }
    }


    public interface IFixed<F,W> : IFixed<W>, ITextual<F>
        where F : unmanaged, IFixed<F,W>
        where W : unmanaged, ITypeWidth  
    {
    
    }
    
    public interface IFixed<F,W,T> : IFixed<F,W>, IEquatable<F>, IContented<W,T>
        where F : unmanaged, IFixed<F,W,T>
        where W : unmanaged, ITypeWidth  
        where T : unmanaged      
    {
        
    }

    public interface IFixedNumeric<F,T> : IFixed, IEquatable<F>, IContented<T>
        where F : unmanaged, IFixedNumeric<F,T>
    {

        int IFixed.BitWidth { [MethodImpl(Inline)] get => bitsize<T>(); }

        int IFixed.ByteCount { [MethodImpl(Inline)] get=> size<T>(); }

        NumericKind NumericKind { [MethodImpl(Inline)] get => NumericKinds.kind<T>(); }

        NumericWidth NumericWidth { [MethodImpl(Inline)] get => (NumericWidth)bitsize<T>(); }
    }

    public interface IFixedNumeric<F,W,T> : IFixedNumeric<F,T>, IContented<W,T>
        where F : unmanaged, IFixedNumeric<F,W,T>
        where W : unmanaged, ITypeWidth  
        where T : unmanaged        
    {
        
    }    
}