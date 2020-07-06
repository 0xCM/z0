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
        [MethodImpl(Inline), Op]
        public static bool literal(PrimalKind src)
            => ((byte)src > 2 && (byte)src<16) || (byte)src == 18;

        /// <summary>
        /// Determines the literal kind of a type, if any
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static PrimalLiteralKind literal(Type src)
        {
            var i = index(src);
            var test = (i > 2 && i <16) || i == 18;
            return test ? (PrimalLiteralKind)As.skip(PrimalKindData,i) : PrimalLiteralKind.None;            
        }

        [MethodImpl(Inline), Op]
        static byte index(Type src)
            => (byte)Type.GetTypeCode(src);        
    }
}