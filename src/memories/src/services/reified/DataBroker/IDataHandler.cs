//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IDataHandler
    {

    }    
   
    public interface IDataHandler<T> : IDataHandler
    {
        void Handle(T data);    
    }

    public interface IDataHandler<C,T> : IDataHandler
    {
        void Handle(C context, T data);    
    }
}