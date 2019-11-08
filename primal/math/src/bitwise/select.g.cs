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

/*
        static ulong select2(ulong a, ulong b, ulong c)
            => c ^ ((c^b) & a);


 */

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
        /// <remarks>Code generation for this is good; type-specific specializations exist for convenience.</remarks>
        [MethodImpl(Inline)]
        public static T select<T>(T a, T b, T c)
            where T : unmanaged
                => or(and(a,b), notimply(a,c));

        /// <summary>
        ///  This operator is equivalent to select, but is implemented xor(b, and(xor(b,a),  mask))
        /// </summary>
        /// <param name="mask">Mask that identifies which of the two source operands to choose a given bit</param>
        /// <param name="a">The first operand, a bit from which is chosen if the corresponding mask bit is enabled</param>
        /// <param name="b">The second operand, a bit from which is chosen if the corresponding mask bit is disabled</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>Code generation for this is good; type-specific specializations exist for convenience. Algorithm
        /// taken from https://graphics.stanford.edu/~seander/bithacks.html</remarks>
        [MethodImpl(Inline)]
        public static T merge<T>(T mask, T a, T b)
            where T : unmanaged
                => xor(b, and(xor(b,a), mask));
    }

}