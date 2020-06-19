//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDataProcessor
    {
        void Connect() {}
    }
    
    public interface IDataProcessor<T> : IDataProcessor
    {
        void Process(T src);
    }

    public interface IDataProcessor<C,T> : IDataProcessor
    {
        void Process(C context, T src);
    }    
}