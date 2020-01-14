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
    
    public readonly struct PrimalEmitter<T> : IEmitter<T>
        where T : unmanaged
    {
        public const string Name = "random";

        readonly IPolyrand Random;

        public Moniker Moniker => moniker<T>(Name);

        [MethodImpl(Inline)]
        internal PrimalEmitter(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public T Invoke() => Random.Next<T>();
    }
}