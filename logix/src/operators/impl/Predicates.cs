//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    using static TernaryOpKind;

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