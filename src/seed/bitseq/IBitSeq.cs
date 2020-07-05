//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IBitSeq : ITextual, IHashed
    {
        bool IsZero {get;}

        bool IsNonZero 
            => !IsZero;
    }

    public interface IBitSeq<S> : IBitSeq, IEquatable<S>    
        where S : unmanaged, IBitSeq<S>
    {
        
    }    

    public interface IBitSeq<S,T> : IBitSeq<S>, INullary<S,T>
        where S : unmanaged, IBitSeq<S,T>
        where T : unmanaged         
    {
        T Value {get;}
    }    

    public interface IBitSeq<S,W,T> : IBitSeq<S,T> 
        where S : unmanaged, IBitSeq<S,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged         
    {
        
    }

    public interface IBitSeq<F,W,K,T> : IBitSeq<F,W,T>
        where F : unmanaged, IBitSeq<F,W,K,T>
        where W : unmanaged, IDataWidth
        where K : unmanaged, Enum
        where T : unmanaged         
    {
        K Kind {get;}
    }    
}