//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IRef : INullity
    {        
        uint DataSize  {get;}
        
        bool INullity.IsEmpty 
            => DataSize == 0;

        uint CellCount  
            => DataSize * CellSize;

        uint CellSize 
            => 1;         
    }
            
    public interface IRef<T> : IRefBuffer<T>
    {

    }

    public interface IRef<F,T> : IRef<T>, INullary<F>, IEquatable<F>
        where F : IRef<F,T>, new()
    {
        F INullary<F>.Zero 
            => new F();
    }

}