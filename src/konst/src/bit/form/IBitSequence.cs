//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IBitSequence : ITextual, IHashed
    {
        bool IsZero {get;}

        bool IsNonZero 
            => !IsZero;
    }

    public interface IBitSequence<S> : IBitSequence, IEquatable<S>    
        where S : unmanaged, IBitSequence<S>
    {
        
    }    

    public interface IBitSequence<S,T> : IBitSequence<S>, INullary<S,T>
        where S : unmanaged, IBitSequence<S,T>
        where T : unmanaged         
    {
        T Value {get;}
    }    

    public interface IBitSequence<S,W,T> : IBitSequence<S,T> 
        where S : unmanaged, IBitSequence<S,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged         
    {
        
    }

    public interface IBitSequence<F,W,K,T> : IBitSequence<F,W,T>
        where F : unmanaged, IBitSequence<F,W,K,T>
        where W : unmanaged, IDataWidth
        where K : unmanaged, Enum
        where T : unmanaged         
    {
        K Kind {get;}
    }    
}