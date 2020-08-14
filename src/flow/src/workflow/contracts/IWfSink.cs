//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    public interface IWfSink : ISink
    {
        
    }
    
    public interface IWfSink<T> : IWfSink, IDataSink<T>
        where T : struct
    {

    }

    public interface IWfSink<H,T> : IWfSink, IWfSink<T>
        where T : struct
        where H : struct, IWfSink<H,T>
    {

    }
}