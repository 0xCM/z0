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

    public readonly struct VRand128<T> : SFx.IEmitter128<T>
        where T : unmanaged
    {
        public const string Name = "vrandom";

        public Vec128Kind<T> VKind => default;

        readonly IPolyStream Random;

        public OpIdentity Id => ApiIdentify.sfunc(Name, VKind);

        [MethodImpl(Inline)]
        internal VRand128(IPolyStream random)
            => this.Random = random;

        [MethodImpl(Inline)]
        public Vector128<T> Invoke() => Random.CpuVector<T>(VKind);
    }

    public readonly struct VRand256<T> : SFx.IEmitter256<T>
        where T : unmanaged
    {
        public const string Name = "vrandom";

        readonly IPolyStream Random;

        public Vec256Kind<T> VKind => default;

        public OpIdentity Id => ApiIdentify.sfunc(Name,VKind);

        [MethodImpl(Inline)]
        internal VRand256(IPolyStream random)
            => this.Random = random;

        [MethodImpl(Inline)]
        public Vector256<T> Invoke() => Random.CpuVector<T>(VKind);
    }
}