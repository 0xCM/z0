//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IHubClient : IDataSink
    {
        IEventHub Hub {get;}
        
        void Connect();
    }    
}