//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AsmEncoder
    {            
        /// <summary>
        /// Computes the length, in bytes, of the encoded content
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static byte size(in EncodedFx src)
            => vcell(src.Data, 15);
    }
}