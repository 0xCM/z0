//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

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
        public static T SetNext<T>(this IPolyrand random, VariableExpr<T> current)
            where T : unmanaged
        {
            var a = random.Next<T>();
            current.Set(a);
            return a;
        }
    }
}