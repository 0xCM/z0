//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct FixedEmitterSurrogate<F,T> : IFixedEmitter<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        public readonly string Name;

        readonly Func<F> f;

        [MethodImpl(Inline)]
        internal FixedEmitterSurrogate(Func<F> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public F Invoke() => f();
    }


    public readonly struct FixedEmitter<F,T> : IFixedEmitter<F,T>
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
        
        public OpIdentity Id => OpIdentity.fixedop(Name, (FixedWidth)Width, NumericKind);

        [MethodImpl(Inline)]
        public FixedEmitter(IPolyrand random, FixedEmitterSurrogate<F,T> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public F Invoke()
            => f.Invoke();
    }
}