//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFlow : ITextual
    {
        IChannel Source {get;}

        IChannel Target {get;}
    }

    [Free]
    public interface IFlow<S,T> : IFlow
        where S : IChannel
        where T : IChannel
    {
        new S Source {get;}

        new T Target {get;}

        IChannel IFlow.Source
            => Source;

        IChannel IFlow.Target
            => Target;
    }

    [Free]
    public interface IFlow<K,S,T> : IFlow<S,T>
        where K : unmanaged
        where S : IChannel
        where T : IChannel
    {

    }
}