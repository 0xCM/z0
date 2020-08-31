//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an individual that can be uniquely associatd with an integer in the range 0..n-1 
    /// within the context of a container with a capacity of n items
    /// </summary>
    public interface IPositional
    {
        /// <summary>
        /// The 0-based position of the item in an enclosing container
        /// </summary>
        int Position {get;}
    }

    public interface IPositional<F> : IPositional, IReified<F>
        where F : IPositional<F>, new()
    {
        
    }

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
    /// Characterizes a type with which a natural number type is associated
    /// </summary>
    /// <typeparam name="T">The represented type</typeparam>
    public interface ITypeNat<K> : ITypeNat
        where K: unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface INatSeq : ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a reified natural sequence
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface INatSeq<S> : ITypeNat<S>, INatSeq
        where S : unmanaged, INatSeq<S>
    {

    }

    public interface INatNumber<F> : ITypeNat<F>
        where F : unmanaged, INatNumber<F>
    {

    }

    public interface IIndexed<F,N> : IPositional<F>, ITypeNat<N>
        where F : struct, IIndexed<F,N>
        where N : unmanaged, ITypeNat
    {
        ulong ITypeNat.NatValue 
            => default(N).NatValue;
    }

    /// <summary>
    /// Characterizes an atom of the type natural grammar
    /// </summary>
    /// <typeparam name="N">The reifying type</typeparam>
    public interface INatPrimitive<N> : INatNumber<N>, INatSeq<N>
        where N : unmanaged, INatPrimitive<N>
    {
        
    }   

    /// <summary>
    /// Requires that the natural representative is nonzero
    /// </summary>
    public interface INatNonZero : ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k:K => k != 0
    /// </summary>
    /// <typeparam name="K">A nonzero natural type</typeparam>
    public interface INatNonZero<K> : INatNonZero
        where K : unmanaged, ITypeNat
    {

    }    

    public interface INatDigit<N,S,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
        where S : INatDigit<N,S,T>
    {

    }    

    /// <summary>
    /// Characterizes binary relationship between two type naturals
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatRelation<K1,K2>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Characterizes ternary relationship among three type naturals
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface INatRelation<K1,K2,K3>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
    {
        
    }    

    /// <summary>
    /// Requires k1 = n*k2 for some n>= 1
    /// </summary>
    /// <typeparam name="K1">The divisible type</typeparam>
    /// <typeparam name="K2">The divisor type</typeparam>
    public interface INatDivisible<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {

    }    

    /// <summary>
    /// Requires k1 <= k <= k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatBetween<K,K1,K2> : INatRelation<K,K1,K2>
        where K : unmanaged, ITypeNat
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }    

    /// <summary>
    /// Requires k1 > k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public interface INatGt<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 >= k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public interface INatGtEq<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }    

    /// <summary>
    /// Requires k1 == k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatEq<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 != k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatNEq<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }    

    /// <summary>
    /// Requires k1 < k2
    /// </summary>
    public interface INatLt<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 <= k2
    /// </summary>
    public interface INatLtEq<K1,K2> : INatRelation<K1,K2>
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
    public interface INatMod<K1,K2,K3> : INatRelation<K1,K2,K3>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
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
    /// Requires k prime
    /// </summary>
    /// <typeparam name="K">A prime nat type</typeparam>
    public interface INatPrime<K> : ITypeNat
        where K : unmanaged, ITypeNat
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
    /// Requires k1: K1 & k2:K2 => k1 - 1 = k2
    /// </summary>
    /// <typeparam name="K1"></typeparam>
    /// <typeparam name="K2"></typeparam>
    public interface INatPrior<K1,K2> : INatGt<K1,K2>, INatNonZero<K1>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    }           

    /// <summary>
    /// Characterizes a reified 2-term natural sequence
    /// </summary>
    /// <typeparam name="K">The reification type</typeparam>
    /// <typeparam name="K1">The first term</typeparam>
    /// <typeparam name="K2">The second term</typeparam>
    public interface INatSeq<K,K1,K2> : INatSeq<K>
        where K : unmanaged, INatSeq<K,K1,K2>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
    {

    }
     
    /// <summary>
    /// Characterizes a reified 3-term natural sequence
    /// </summary>
    /// <typeparam name="K">The reification type</typeparam>
    /// <typeparam name="K1">The first term</typeparam>
    /// <typeparam name="K2">The second term</typeparam>
    /// <typeparam name="K2">The third term</typeparam>
    public interface INatSeq<K,K1,K2,K3> : INatSeq<K>
        where K : unmanaged, INatSeq<K,K1,K2,K3>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
    {

    }    
}