//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

   public static class VarRandom
    {
        /// <summary>
        /// Obtains the next primal value from the random source, assigns the
        /// variable to this value and returns the value to the caller
        /// </summary>
        /// <param name="random"></param>
        /// <param name="current"></param>
        /// <typeparam name="T">The primal value over which the variable is defined</typeparam>
        [MethodImpl(Inline)]
        public static T Set<T>(this IPolyrand random, VariableExpr<T> current)
            where T : unmanaged
        {
            var a = random.Next<T>();
            current.Set(a);
            return a;
        }
    }

}