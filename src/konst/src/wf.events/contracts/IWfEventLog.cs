//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWfEventLog : IWfEventSink, IDataSink<WfTermEvent>, ISink<IAppEvent>, ISink<IAppMsg>, ISink<IWfEvent>, IDisposable
    {

    }
}