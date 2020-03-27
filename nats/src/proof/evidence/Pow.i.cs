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

}