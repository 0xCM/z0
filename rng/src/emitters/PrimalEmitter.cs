//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    public readonly struct PrimalEmitter<T> : IEmitter<T>
        where T : unmanaged
    {
        public const string Name = "random";

        readonly IPolyrand Random;

        public OpIdentity Id => Identity.contracted<T>(Name);

        [MethodImpl(Inline)]
        internal PrimalEmitter(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public T Invoke() => Random.Next<T>();
    }
}