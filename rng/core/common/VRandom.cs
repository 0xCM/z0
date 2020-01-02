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
        readonly IPolyrand Random;

        public const string Name = "vrandom";

        public string Moniker => moniker<N128,T>(Name);

        [MethodImpl(Inline)]
        public VRandom128(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public Vector128<T> Invoke() => Random.CpuVector<T>(n128);
    }

    public readonly struct VRandom256<T> : IVEmitter256<T>
        where T : unmanaged
    {
        readonly IPolyrand Random;

        public const string Name = "vrandom";

        public string Moniker => moniker<N256,T>(Name);

        [MethodImpl(Inline)]
        public VRandom256(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public Vector256<T> Invoke() => Random.CpuVector<T>(n256);
    }
}