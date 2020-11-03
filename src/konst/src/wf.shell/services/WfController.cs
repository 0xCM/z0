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