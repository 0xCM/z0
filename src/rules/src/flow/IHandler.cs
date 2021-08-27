//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHandler
    {
        void Handle(object src);
    }

    public interface IHandler<T> : IHandler
    {
        void Handle(T src);

        void IHandler.Handle(object src)
            => Handle((T)src);
    }

    public interface IFlowHandler<PK,S,SK,T,TK>
    {
        PK PipeKind {get;}

        SK SourceKind {get;}

        TK TargetKind {get;}

        void Handle(Arrow<S,T> flow);
    }

    public class HandlerAttribute : Attribute
    {
        public HandlerAttribute()
        {
            PayloadType = typeof(void);
        }

        public HandlerAttribute(Type t)
        {
            PayloadType = t;
        }

        public Type PayloadType {get;}
    }
}