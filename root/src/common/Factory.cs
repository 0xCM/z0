//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFactory
    {
        
    }
    public interface IFactory<T> : IFactory
    {


    }
    
    public readonly struct Factory<T> : IFactory<T>
    {


    }

}