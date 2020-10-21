//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface IWfController
    {
        Assembly Component {get;}
    }

    public interface IWfControl<P> : IWfController
        where P : IPart<P>, new()
    {

    }

    public readonly struct WfController<P> : IWfControl<P>
        where P : IPart<P>, new()
    {
        public Assembly Component
        {
            [MethodImpl(Inline)]
            get => typeof(P).Assembly;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfController(WfController<P> src)
            => new WfController(src.Component);
    }

    public readonly struct WfController
    {
        public Assembly Component {get;}

        [MethodImpl(Inline)]
        public WfController(Assembly src)
        {
            Component = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfController(Assembly src)
            => new WfController(src);

        [MethodImpl(Inline)]
        public static implicit operator Assembly(WfController src)
            => src.Component;

        public string Name
        {
            [MethodImpl(Inline)]
            get => Component.GetSimpleName();
        }

        public PartId Id
        {
            [MethodImpl(Inline)]
            get => Component.Id();
        }
    }
}