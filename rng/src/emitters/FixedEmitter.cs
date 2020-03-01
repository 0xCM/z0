//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    readonly struct FixedEmitter<F,T> : IFixedEmitter<F,T>
        where F : unmanaged, IFixed
        where T :unmanaged
    {

        readonly IPolyrand Random;
        
        readonly FixedEmitterSurrogate<F,T> f;

        public const string Name = "fixedrand";

        public static int Width => bitsize<F>();

        public static NumericKind NumericKind 
        {
            [MethodImpl(Inline)]
            get => typeof(T).NumericKind();
        }
        
        public OpIdentity Id => OpId.fixedop(Name, (FixedWidth)Width, NumericKind);

        [MethodImpl(Inline)]
        internal FixedEmitter(IPolyrand random, FixedEmitterSurrogate<F,T> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public F Invoke()
            => f.Invoke();
    }
}