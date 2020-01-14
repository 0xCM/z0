//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    public readonly struct VRandom128<T> : IVEmitter128<T>
        where T : unmanaged
    {
        public const string Name = "vrandom";

        static N128 w => default;

        readonly IPolyrand Random;

        public Moniker Moniker => moniker(Name,w);

        [MethodImpl(Inline)]
        internal VRandom128(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public Vector128<T> Invoke() => Random.CpuVector<T>(w);
    }

    public readonly struct VRandom256<T> : IVEmitter256<T>
        where T : unmanaged
    {
        public const string Name = "vrandom";

        readonly IPolyrand Random;

        static N256 w => default;

        public Moniker Moniker => moniker(Name,w);

        [MethodImpl(Inline)]
        internal VRandom256(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public Vector256<T> Invoke() => Random.CpuVector<T>(w);
    }
}