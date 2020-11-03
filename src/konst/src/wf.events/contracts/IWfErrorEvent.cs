//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfErrorEvent : IWfEvent
    {
        bool IAppEvent.IsError
            => true;

        string FormatSummary();
    }
}