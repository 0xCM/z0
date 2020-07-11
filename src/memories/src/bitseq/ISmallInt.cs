//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface ISmallInt : ITextual, IHashed
    {
        bool IsZero {get;}

        bool IsNonZero 
            => !IsZero;
    }

    public interface ISmallInt<S> : ISmallInt, IEquatable<S>    
        where S : unmanaged, ISmallInt<S>
    {
        
    }    

    public interface ISmalInt<S,T> : ISmallInt<S>, INullary<S,T>
        where S : unmanaged, ISmalInt<S,T>
        where T : unmanaged         
    {
        T Value {get;}
    }    

    public interface ISmallInt<S,W,T> : ISmalInt<S,T> 
        where S : unmanaged, ISmallInt<S,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged         
    {
        
    }

    public interface ISmallInt<F,W,K,T> : ISmallInt<F,W,T>
        where F : unmanaged, ISmallInt<F,W,K,T>
        where W : unmanaged, IDataWidth
        where K : unmanaged, Enum
        where T : unmanaged         
    {
        K Kind {get;}
    }    
}