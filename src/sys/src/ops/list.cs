//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
            
    using static OpacityKind;
    using static Part;

    partial struct sys
    {        
        /// <summary>
        /// Creates a list from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(NotInline), Opaque(ArrayToList), Closures(Closure)]
        public static List<T> list<T>(params T[] src)
            => src.ToList();
    }
}