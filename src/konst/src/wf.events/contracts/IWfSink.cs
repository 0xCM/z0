//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfSink : ISink
    {
        Type InputType {get;}

        Type HostType {get;}

        void Deliver(object src);

        IWfSink Init(IWfShell wf);
    }

    [Free]
    public interface IWfSink<T> : IWfSink, ISink<T>, IWfClient
        where T : struct, IRecord<T>
    {
        void Deliver(T src);

        Type IWfSink.InputType
            => typeof(T);

        void IWfSink.Deliver(object src)
            => Deliver((T)src);
    }

    [Free]
    public interface IWfSink<H,T> : IWfSink<T>, IWfClient<H>
        where H : IWfSink<H,T>, new()
        where T : struct, IRecord<T>
    {
        Type IWfSink.HostType
            => typeof(H);

        IWfSink IWfSink.Init(IWfShell wf)
        {
            var client = new H();
            return (client as IWfClient<H>).Init(wf);
        }
    }

    public class WfSinkAttribute : SinkAttribute
    {

    }

}