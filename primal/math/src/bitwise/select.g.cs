//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;


    partial class gmath
    {
        /// <summary>
        /// Defines the ternary bitwise select operator over primal unsigned integers, 
        /// select(a,b,c) := or(and(a, b), and(not(a), c)) = or(and(a,b), notimply(a,c));
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>Code generation for this is good and there is no need to define type-specific specializations</remarks>
        [MethodImpl(Inline)]
        public static T select<T>(T a, T b, T c)
            where T : unmanaged
                //=> or(and(a, b), and(not(a), c));
                => or(and(a,b), notimply(a,c));
    }

}