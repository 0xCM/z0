//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    /// <summary>
    /// Defines the canonical shape of a bitwise shift function
    /// </summary>
    /// <param name="a">The source value</param>
    /// <param name="offset">The shift amount, typically in bits</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Shifter<T>(T a, int offset)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 2-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPred<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines predicate operations
    /// </summary>
    /// <remarks>
    /// This segregation acknowledges the fact that functions such as comparison "operators" 
    /// that return a boolean value really aren't operators; the primary motivation
    /// however is to define a separate namescope that allows operator/operation names
    /// to be used polymorphically
    /// </remarks>
    public static class Predicates
    {
        [MethodImpl(Inline)]
        public static bit equals<T>(T a, T b)
            where T : unmanaged
                => gmath.eq(a,b);

        [MethodImpl(Inline)]
        public static bit neq<T>(T a, T b)
            where T : unmanaged
                => gmath.neq(a,b);

        [MethodImpl(Inline)]
        public static bit lt<T>(T a, T b)
            where T : unmanaged
                => gmath.lt(a,b);

        [MethodImpl(Inline)]
        public static bit lteq<T>(T a, T b)
            where T : unmanaged
                => gmath.lteq(a,b);

        [MethodImpl(Inline)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
                => gmath.gt(a,b);

        [MethodImpl(Inline)]
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
                => gmath.gteq(a,b);
    }
}