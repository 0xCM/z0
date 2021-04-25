//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Clr
    {
        /// <summary>
        /// Determines whether an identified <see cref='ClrPrimalKind'/> can be a compile-time literal
        /// </summary>
        /// <param name="src">The kind to test</param>
        [MethodImpl(Inline), Op]
        public static bool literal(ClrPrimalKind src)
            => ((byte)src > 2 && (byte)src<16) || (byte)src == 18;
    }
}