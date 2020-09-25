//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfEventReceiver : IWfReceiver<IWfEvent>
    {

    }

    [Free]
    public interface IWfEventReceiver<E> : IWfReceiver<E>
        where E : struct, IWfEvent<E>
    {

    }
}