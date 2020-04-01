//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Requires k:K => k % 2 == 0
    /// </summary>
    /// <typeparam name="K">An even natural type</typeparam>
    public interface INatEven<K> : ITypeNat, INatDivisible<K,N2>
        where K : unmanaged, ITypeNat<K>
    {

    }

    /// <summary>
    /// Characterizes a natural k such that e:E => k = 2^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow2<E> : INatPow<N2,E>, INatEven<E>
        where E : unmanaged, ITypeNat<E>
    {
        E Exp
        {
            [MethodImpl(Inline)]
            get => default(E);
        }         
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : 
        INatPrimitive<N2>,
        INatSeq<N2>, 
        INatPrime<N2>, 
        INatPow<N2,N2,N1>, 
        INatEven<N2>, 
        INatPrior<N2,N1>, 
        INatPow2<N1>        
    {
        public const ulong Value = 2;

        public static N2 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N2 src) => 2;

        public ulong NatValue => Value;
        
        public NatSeq Sequence => this;
        
        public override string ToString() 
            => Value.ToString();
    }
}