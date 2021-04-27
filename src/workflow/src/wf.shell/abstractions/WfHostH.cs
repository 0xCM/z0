//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public abstract class WfHost<H> : IWfHost<H>
        where H : WfHost<H>, new()
    {
        [MethodImpl(Inline)]
        public static H create() => new H();

        public virtual WfStepId Id {get;}

        public Type Type {get;}

        public StringRef Name
            => Identifier;

        public virtual string Identifier
            => typeof(H).Name;

        [MethodImpl(Inline)]
        protected WfHost()
        {
            Type = typeof(H);
            Id = Type;
        }

        public virtual void Run(IWfRuntime wf)
        {
            try
            {
                Execute(wf.WithHost(this));
            }
            catch(Exception e)
            {
                wf.Error(Id, e);
            }
        }

        protected virtual void Init() { }

        protected abstract void Execute(IWfRuntime shell);

        public virtual string Format()
            => Id.Format();

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfHost<H> src)
            => src.Id;

        [MethodImpl(Inline)]
        public static implicit operator WfHost(WfHost<H> src)
            => new WfHost(src.Id, src.Type);
    }
}