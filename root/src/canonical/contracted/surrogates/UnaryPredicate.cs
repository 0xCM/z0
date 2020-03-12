//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    public readonly struct UnaryPredicateSurrogate<T> : IUnaryPredicateSurrotate<T>
    {
        public readonly string Name;

        readonly UnaryPredicate<T> F;

        [MethodImpl(Inline)]
        internal UnaryPredicateSurrogate(UnaryPredicate<T> f, string name)            
        {
            this.F = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public bit Invoke(T a) => F(a);
    }
}