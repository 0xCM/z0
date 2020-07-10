//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Part;
    using static OpacityKind;
    
    partial struct sys
    {
        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(NotInline), Opaque(EmptyStringTest)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);
    }
}