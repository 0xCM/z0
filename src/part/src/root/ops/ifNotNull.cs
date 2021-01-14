// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct root
    {
        /// <summary>
        /// Evaluates a function over a value if the value is not null; otherwise, returns the default result value
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="x">The operand</param>
        /// <param name="f1">The function to potentially evaluate</param>
        [MethodImpl(Inline)]
        public static Y ifNotNull<X,Y>(X x, Func<X,Y> f1, Y @default = default)
            => x != null ? f1(x) : @default;
    }
}