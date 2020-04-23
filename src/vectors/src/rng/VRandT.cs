//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    
    public readonly struct VRandom128<T> : ISVEmitter128<T>
        where T : unmanaged
    {
        public const string Name = "vrandom";

        public Vec128Kind<T> VKind => default;

        readonly IPolyrand Random;

        public OpIdentity Id => Identify.sfunc(Name, VKind);

        [MethodImpl(Inline)]
        internal VRandom128(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public Vector128<T> Invoke() => Random.CpuVector<T>(VKind);
    }

    public readonly struct VRandom256<T> : ISVEmitter256<T>
        where T : unmanaged
    {
        public const string Name = "vrandom";

        readonly IPolyrand Random;

        public Vec256Kind<T> VKind => default;

        public OpIdentity Id => Identify.sfunc(Name,VKind);

        [MethodImpl(Inline)]
        internal VRandom256(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public Vector256<T> Invoke() => Random.CpuVector<T>(VKind);
    }
}