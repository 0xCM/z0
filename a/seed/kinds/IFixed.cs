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

    }

    public interface IFixed<F,W> : IFixed<W>, IEquatable<F>, IFormattable<F>
        where F : unmanaged, IFixed<F,W>
        where W : unmanaged, ITypeWidth  
    {
    
    }
    
    public interface IFixed<F,W,S> : IFixed<F,W>
        where F : unmanaged, IFixed<F,W,S>
        where W : unmanaged, ITypeWidth  
        where S : unmanaged      
    {
    
    }

    public interface IFixedNumeric<W,S> : IFixed<W>
        where S : unmanaged        
        where W : unmanaged, ITypeWidth  
    {
        S Data {get;}

        NumericKind NumericKind
        {
            [MethodImpl(Inline)]
            get => typeof(S).NumericKind();
        }

    }

    public interface IFixedNumeric<F,W,S> : IFixed<F,W,S>, IFixedNumeric<W,S>
        where F : unmanaged, IFixed<F,W,S>
        where S : unmanaged        
        where W : unmanaged, ITypeWidth  
    {


    }    
}