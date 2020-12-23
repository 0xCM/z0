//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static SFx;

    public readonly struct VEmitter256<T> : IEmitter256<T>
        where T : unmanaged
    {
        public const string Name = "vemitter";

        readonly IDataSource Source;

        public Vec256Kind<T> VKind => default;

        [MethodImpl(Inline)]
        public VEmitter256(IDataSource src)
            => Source = src;

        public OpIdentity Id
            => ApiIdentify.sfunc(Name, VKind);

        [MethodImpl(Inline)]
        public Vector256<T> Invoke()
            => Source.CpuVector<T>(VKind);
    }
}