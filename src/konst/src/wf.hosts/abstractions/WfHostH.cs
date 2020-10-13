//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public abstract class WfHost<H> : IWfHost<H>
        where H : WfHost<H>, new()
    {
        [MethodImpl(Inline)]
        public static H create() => new H();

        public virtual WfStepId Id {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfHost<H> src)
            => src.Id;

        [MethodImpl(Inline)]
        public static implicit operator WfHost(WfHost<H> src)
            => new WfHost(src.Id, src.Type, src.Execute);

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

        public virtual void Run(IWfShell shell)
        {
            try
            {
                Execute(shell);
            }
            catch(Exception e)
            {
                shell.Error(Id,e);
            }
        }

        protected virtual void Execute(IWfShell shell)
            => throw new NotImplementedException();

        public virtual string Format()
            => Id.Format();
    }
}