//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct NumericRngEmitter<T> : IEmitter<T>
        where T : unmanaged
    {
        public const string Name = "random";

        readonly IPolyrand Random;

        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public NumericRngEmitter(IPolyrand random)            
            => this.Random = random;
        
        [MethodImpl(Inline)]
        public T Invoke() => Random.Next<T>();
    }
    
    public readonly struct FixedRngEmitter<F,T> : IFixedEmitter<F,T>
        where F : unmanaged, IFixed
        where T :unmanaged
    {
        readonly IPolyrand Random;
        
        readonly FixedEmitterSurrogate<F,T> f;

        public const string Name = "fixedemitter";

        public static int Width => bitsize<F>();

        public static NumericKind NumericKind 
        {
            [MethodImpl(Inline)]
            get => typeof(T).NumericKind();
        }
        
        public OpIdentity Id => OpIdentity.fixedop(Name, (FixedWidth)Width, NumericKind);

        [MethodImpl(Inline)]
        public FixedRngEmitter(IPolyrand random, FixedEmitterSurrogate<F,T> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public F Invoke() => f.Invoke();
    }
}