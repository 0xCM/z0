//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

   public readonly struct FixedRngSpanEmitter<F> : IFixedSpanEmitter<F>
        where F : unmanaged, IFixed
    {
        readonly IPolyrand Random;
        
        readonly FixedSpanEmitterSurrogate<F> f;

        public static string Name => $"fixed_span_rng_{bitsize<F>()}";

        public static int Width => bitsize<F>();

        public static NumericKind NumericKind 
        {
            [MethodImpl(Inline)]
            get => typeof(F).NumericKind();
        }
        
        public OpIdentity Id => OpIdentity.fixedop(Name, (FixedWidth)Width, NumericKind);

        [MethodImpl(Inline)]
        public FixedRngSpanEmitter(IPolyrand random, FixedSpanEmitterSurrogate<F> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public Span<F> Invoke() => f.Invoke();
    }
    
    public readonly struct FixedRngSpanEmitter<F,T> : IFixedSpanEmitter<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        readonly IPolyrand Random;
        
        readonly FixedSpanEmitterSurrogate<F,T> f;

        public static string Name => $"fixed_span_rng_{default(F).FixedBitCount}x{bitsize<T>()}";

        public static int Width => bitsize<F>();

        public static NumericKind NumericKind 
        {
            [MethodImpl(Inline)]
            get => typeof(T).NumericKind();
        }
        
        public OpIdentity Id => OpIdentity.fixedop(Name, (FixedWidth)Width, NumericKind);

        [MethodImpl(Inline)]
        public FixedRngSpanEmitter(IPolyrand random, FixedSpanEmitterSurrogate<F,T> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public Span<F> Invoke() => f.Invoke();
    }
}