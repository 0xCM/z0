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

        public virtual void Run() {}

        public virtual string Format()
            => Id.Format();
    }

    public abstract class WfHost<H,C> : WfHost<H>, IWfHost<H,C>
        where H : WfHost<H,C>, new()
        where C : struct
    {
        C _Config;

        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {
            _Config = default;
        }

        [MethodImpl(Inline)]
        protected WfHost(in C config)
            : base()
        {
            _Config = config;
        }

        public ref readonly C Config
        {
            [MethodImpl(Inline)]
            get => ref _Config;
        }

        [MethodImpl(Inline)]
        public void Configure(in C config)
        {
            _Config = config;
        }
    }

    public abstract class WfHost<H,C,S,T> : WfHost<H,C>
        where H : WfHost<H,C,S,T>, new()
        where C : struct
        where S : struct
        where T : struct
    {

        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {

        }

        [MethodImpl(Inline)]
        protected WfHost(in C config)
            : base(config)
        {

        }

        public override void Run()
            => Run(new S());

        public abstract T Run(in S src);
    }
}