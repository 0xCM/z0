//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMultiSink : ISink<IWfEvent> , ISink<IAppEvent>, ISink<IAppMsg>,  IDisposable
    {

    }

}