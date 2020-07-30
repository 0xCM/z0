//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Primitive
    {
        /// <summary>
        /// Creates a primal bitfield over a primitive kind
        /// </summary>
        /// <param name="src">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindBitField bitfield(PrimalKind src)
            => new PrimalKindBitField(src);

        /// <summary>
        /// Creates a primal bitfield over untyped content
        /// </summary>
        /// <param name="src">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindBitField bitfield(byte src)
            => new PrimalKindBitField(src);

        /// <summary>
        /// Creates a primal bitfield over a literal kind
        /// </summary>
        /// <param name="src">The literal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindBitField bitfield(PrimalLiteralKind src)
            => new PrimalKindBitField(src);        
    }
}