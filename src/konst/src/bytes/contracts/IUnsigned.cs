//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IUnsigned : ITextual, IHashed
    {
        bool IsZero {get;}

        bool IsNonZero 
            => !IsZero;
    }

    public interface IUnsigned<S> : IUnsigned, IEquatable<S>    
        where S : unmanaged, IUnsigned<S>
    {
        
    }    

    public interface IUnsigned<S,T> : IUnsigned<S>, INullary<S,T>
        where S : unmanaged, IUnsigned<S,T>
        where T : unmanaged         
    {
        T Value {get;}
    }    

    public interface IUnsigned<S,W,T> : IUnsigned<S,T> 
        where S : unmanaged, IUnsigned<S,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged         
    {
        
    }

    public interface IUnsigned<F,W,K,T> : IUnsigned<F,W,T>
        where F : unmanaged, IUnsigned<F,W,K,T>
        where W : unmanaged, IDataWidth
        where K : unmanaged, Enum
        where T : unmanaged         
    {
        K Kind {get;}
    }    
}