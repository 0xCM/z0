//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Enums
    {
        /// <summary>
        /// Determines whether an enum base kind is signed
        /// </summary>
        /// <param name="base">An integral type refined by an enum</param>
        [MethodImpl(Inline), Op]
        public static bool signed(EnumScalarKind @base)
            => (@base & EnumScalarKind.SignMask) != 0;
    }
}