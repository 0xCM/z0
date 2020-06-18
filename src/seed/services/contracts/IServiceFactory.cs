//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IContextReceiver<C>
        where C : IContext
    {

        void AcceptContext(C context);
    }
    
    public interface IServiceFactory<C>
        where C : IContext
    {
        C Context {get;}        
    }

    public interface IServiceFactory<C,I> : IServiceFactory<C>
        where C : IContext
    {        
    
    }

    public readonly struct ServiceFactory<I> 
    {
        [MethodImpl(Inline)]
        public I CreateService<H>(H host = default)
            where H : I, new()
                => host ?? new H();
    }
    
    public readonly struct ServiceFactory<C,I> : IServiceFactory<C,I>
        where C : IContext
    {
        public C Context {get;}

        [MethodImpl(Inline)]
        ServiceFactory(C context)
        {
            Context = context;
        }

        [MethodImpl(Inline)]
        public I CreateService<H>(C context)
            where H : I, IContextReceiver<C>,  new()
        {
            var host = new H();
            host.AcceptContext(Context);
            return host;
        }
    }

    public readonly struct ServiceFactory<C,H,I> : IServiceFactory<C,I>
        where C : IContext
        where H : I, IContextReceiver<C>,  new()
    {
        public C Context {get;}
        
        [MethodImpl(Inline)]
        ServiceFactory(C context)
        {
            Context = context;
        }
        
        [MethodImpl(Inline)]
        public I CreateService()
        {
            var host = new H();
            host.AcceptContext(Context);
            return host;
        }
    }
}