//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    readonly struct FixedEmitter<F,T> : IFixedEmitter<F, T>
        where F : unmanaged, IFixed         
        where T :unmanaged
    {
        public const string Name = "fixedrand";

        public static FixedWidth Width => default(F).FixedWidth;

        public static NumericKind NumericKind => typeof(T).NumericKind();
        
        readonly IPolyrand Random;
        
        readonly EmitterSurrogate<F> f;

        public OpIdentity Id => Identity.operation(Name,Width,NumericKind);

        [MethodImpl(Inline)]
        internal FixedEmitter(IPolyrand random, EmitterSurrogate<F> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public F Invoke()
            => f.Invoke();
    }
}