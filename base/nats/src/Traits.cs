//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static constant;

    /// <summary>
    /// Characterizes a type-level natural number, a *typenat*
    /// </summary>
    public interface ITypeNat
    {
        /// <summary>
        /// The number's value
        /// </summary>
        ulong NatValue {get;}

    }

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface NatSeq : ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T">The represented type</typeparam>
    public interface ITypeNat<K> : ITypeNat, INatDivisible<K>
        where K: unmanaged, ITypeNat
    {
        K NatRep
        {
            [MethodImpl(Inline)]
            get => default(K);
        }
    }

    /// <summary>
    /// Characterizes a natural sequence with an unspecified number of terms
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface INatSeq<S> : ITypeNat<S>, NatSeq
        where S : unmanaged, INatSeq<S>
    {

    }

    public interface INatSeq<K,K1,K2> : INatSeq<K>
        where K : unmanaged, INatSeq<K,K1,K2>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
    {

        NatSeq<K1,K2> SeqRep
        {
            [MethodImpl(Inline)]
            get => NatSeq<K1,K2>.Rep;
        }     

    }
     
    public interface INatSeq<K,K1,K2,K3> : INatSeq<K>
        where K : unmanaged, INatSeq<K,K1,K2,K3>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
    {

        NatSeq<K1,K2,K3> SeqRep
        {
            [MethodImpl(Inline)]
            get => NatSeq<K1,K2,K3>.Rep;
        }        
    }

    public interface INatDemand 
    {

    }

    /// <summary>
    /// Characterizes a constraint on a nat
    /// </summary>
    /// <typeparam name="K1">The Nat type</typeparam>
    public interface INatDemand<K1> : INatDemand
        where K1 : unmanaged, ITypeNat
    {
        
    }
    
    /// <summary>
    /// Characterizes binary relationship between two nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatDemand<K1,K2> : INatDemand
        where K1 : unmanaged, ITypeNat
        where K2 : ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 = n*k2 for some n>= 1
    /// </summary>
    /// <typeparam name="K1"></typeparam>
    /// <typeparam name="K2"></typeparam>
    public interface INatDivisible<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {

    }

    public interface INatDivisible<K> : INatDivisible<K,K>
        where K : unmanaged, ITypeNat//, ITypeNat<K>
    {

    }

    /// <summary>
    /// Characterizes ternary relationship among three nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface IDemand<K1,K2,K3> : INatDemand
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires n:K & n1:K1 & n2:K2 => n1 <= n <= n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatBetween<K,K1,K2> : IDemand<K,K1,K2>
        where K : unmanaged, ITypeNat
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 == n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatEq<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 != n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatNEq<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1:K1, k2:K2 => k1 > k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public interface INatGt<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface INatMod<K1,K2,K3> : IDemand<K1,K2,K3>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Requires k:K => k % 2 == 0
    /// </summary>
    /// <typeparam name="K">An even natural type</typeparam>
    public interface INatEven<K> : ITypeNat, INatDivisible<K,N2>
        where K : unmanaged, ITypeNat<K>
    {

    }

    /// <summary>
    /// Requires k:K => k % 2 != 0
    /// </summary>
    /// <typeparam name="K">An Odd natural type</typeparam>
    public interface INatOdd<K> : ITypeNat
        where K : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Requires k1: K1 & k2:K2 => k1 - 1 = k2
    /// </summary>
    /// <typeparam name="K1"></typeparam>
    /// <typeparam name="K2"></typeparam>
    public interface INatPrior<K1,K2> : INatGt<K1,K2>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    }       

    /// <summary>
    /// Characterizes the reification of a natural number k such that 
    /// a:K1 & b:K2 & k = a * b
    /// </summary>
    /// <typeparam name="K2">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatProduct<S,K1,K2> : ITypeNat
        where S : INatProduct<S,K1,K2>, new()
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a natural k such that b:B & e:E => k = b^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow<B,E> : ITypeNat
        where B : unmanaged, ITypeNat
        where E : unmanaged, ITypeNat
    {
        
    }

    public interface INatPow2 : ITypeNat
    {
        
    }

    /// <summary>
    /// Characterizes a natural k such that e:E => k = 2^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow2<E> : INatPow2, INatPow<N2,E>, INatEven<E>
        where E : unmanaged, ITypeNat<E>
    {
        E Exp
        {
            [MethodImpl(Inline)]
            get => default(E);
        }
         

    }

    /// <summary>
    /// Characterizes the reification of a natural k such that 
    /// b:B & e:E => k = b^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow<S,B,E> : INatPow<B,E>, ITypeNat<S>
        where S : unmanaged, INatPow<S,B,E>
        where B : unmanaged, ITypeNat
        where E : unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Characterizes the reification of a natural number k such that 
    /// a:K1 & b:K2 & k = a - b
    /// </summary>
    /// <typeparam name="K2">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatSub<S,K1,K2> : ITypeNat
        where S : INatSub<S,K1,K2>, new()
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    }
 
    /// <summary>
    /// Requires k1:K1 & k2:K2 => k1 + 1 = k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatNext<K1,K2> : INatLt<K1,K2> 
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    } 

    /// <summary>
    /// Requires k prime
    /// </summary>
    /// <typeparam name="K">A prime nat type</typeparam>
    public interface INatPrime<K> : ITypeNat
        where K : unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires z = p^k for some prime number p
    /// </summary>
    /// <typeparam name="K"></typeparam>
    public interface IPrimePower<K> : INatDemand<K>
        where K : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Requires z = p^k where p is prime
    /// </summary>
    /// <typeparam name="P">The prime type</typeparam>
    /// <typeparam name="K">The power type</typeparam>
    public interface IPrimePower<P,K> : INatDemand<P,K>
        where P : unmanaged, ITypeNat, INatPrime<P>
        where K : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 < T2
    /// </summary>
    public interface INatLt<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k:K => k != 0
    /// </summary>
    /// <typeparam name="K">A nonzero natural type</typeparam>
    public interface INatNonZero<K> : INatDemand<K>, INatGt<K,N0>
        where K : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Reifies k := k1 + k2
    /// </summary>
    /// <typeparam name="K1">The first operand type</typeparam>
    /// <typeparam name="K2">The second operand type</typeparam>
    public interface INatSum<K1,K2> : ITypeNat
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    }

    public interface INatSum<K> : ITypeNat
        where K : unmanaged, ITypeNat
    {
        ITypeNat Lhs {get;}        

        ITypeNat Rhs {get;}
    }    

    public interface IDigit<N,S,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
        where S : IDigit<N,S,T>
    {

    }
}