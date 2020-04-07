//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a persistent application message sink
    /// </summary>
    public interface IAppMsgLog : IAppMsgSink, IMessageLog<AppMsg>
    {

    }    
}