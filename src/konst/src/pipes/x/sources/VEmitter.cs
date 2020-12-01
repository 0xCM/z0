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

    public readonly struct VEmitter128<T> : SFx.IEmitter128<T>
        where T : unmanaged
    {
        public const string Name = "vemitter";

        public Vec128Kind<T> VKind => default;

        readonly ISource Source;

        [MethodImpl(Inline)]
        public VEmitter128(ISource source)
            => Source = source;

        public OpIdentity Id
            => ApiIdentify.sfunc(Name, VKind);

        [MethodImpl(Inline)]
        public Vector128<T> Invoke()
            => Source.CpuVector<T>(VKind);
    }

    public readonly struct VEmitter256<T> : SFx.IEmitter256<T>
        where T : unmanaged
    {
        public const string Name = "vemitter";

        readonly ISource Source;

        public Vec256Kind<T> VKind => default;

        [MethodImpl(Inline)]
        public VEmitter256(ISource source)
            => Source = source;
        public OpIdentity Id
            => ApiIdentify.sfunc(Name,VKind);

        [MethodImpl(Inline)]
        public Vector256<T> Invoke()
            => Source.CpuVector<T>(VKind);
    }
}