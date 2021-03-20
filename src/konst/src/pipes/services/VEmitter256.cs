//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    public readonly struct VEmitter256<T> : IEmitter256<T>
        where T : unmanaged
    {
        public const string Name = "vemitter";

        readonly ISource Source;

        static Vec256Kind<T> Kind => default;

        [MethodImpl(Inline)]
        public VEmitter256(ISource src)
            => Source = src;

        public OpIdentity Id
            => SFx.identity(Name, Kind);

        [MethodImpl(Inline)]
        public Vector256<T> Invoke()
            => Source.CpuVector<T>(Kind);
    }
}