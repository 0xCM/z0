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
    public interface IFixedW<W> : IFixed
        where W : struct, ITypeWidth
    {
        TypeWidth TypeWidth         
            => Widths.type<W>(); 

        int IFixed.BitWidth 
            => (int)TypeWidth;

        int IFixed.ByteCount 
            => ((int)TypeWidth)/8; 
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedW<F,W> : IFixedW<W>
        where F : struct, IFixedW<F,W>
        where W : struct, ITypeWidth  
    {
    
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface IFixedW<F,W,T> : IFixed<F,T>, IFixedW<F,W>
        where F : struct, IFixedW<F,W,T>
        where W : struct, ITypeWidth  
        where T : struct      
    {
        
    }
}