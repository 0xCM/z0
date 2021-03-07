//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPipeline : IWfService
    {
        void Run();
    }

    [Free]
    public interface IPipeline<S,T> : IPipeline
    {
        IEmitter<S> Emitter {get;}

        IProjector<S,T> Projector {get;}

        IReceiver<T> Receiver {get;}

        bool Connected {get;}

    }

    [Free]
    public interface IPipeline<C,S,T> : IPipeline<S,T>
        where C : IPipeline<C,S,T>
    {
        C Connect(IEmitter<S> emitter, IProjector<S,T> projector, IReceiver<T> receiver);
    }
}