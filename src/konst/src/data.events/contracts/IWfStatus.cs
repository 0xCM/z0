//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfStatus : IWfEvent
    {

    }

    [Free]
    public interface IWfStatus<T> : IWfStatus
    {
        WfPayload<T> Content {get;}
    }


    [Free]
    public interface IWfTrace<T> : IWfEvent
    {
        WfPayload<T> Content {get;}
    }
}