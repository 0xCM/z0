//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether the enum value corresponds to a defined literal
        /// </summary>
        /// <param name="src">The enum value to check</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsLiteral<E>(this E src)
            where E : Enum
                => Enum.IsDefined(typeof(E), src);
    }
}