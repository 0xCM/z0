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
        public static H Host => new H();

        public WfStepId Id {get;}

        public Type Type {get;}

        public StringRef Name {get;}

        [MethodImpl(Inline)]
        protected WfHost()
        {
            Type = typeof(H);
            Id = Type;
            Name = Type.Name;
        }

        public virtual void Run(IWfShell shell) {}

        public virtual string Format()
            => Id.Format();
    }
}