//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Z0.Asm;

    using static Konst;    
    using static z;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static EncodedRoutine encoded([CallerMemberName] string name = null)
            => new EncodedRoutine(name,32);

        [MethodImpl(Inline), Op]
        public static EncodedRoutine encoded(asci32[] name, EncodedFx[] commands, uint[] index)
            => new EncodedRoutine(name, commands, index);

        /// <summary>
        /// Defines an encoded instruction from the lower 15 source bytes
        /// </summary>
        /// <param name="src">The encoded data</param>
        [MethodImpl(Inline), Op]
        public static EncodedFx encoded(Vector128<byte> src)
            => new EncodedFx(src);
    }
}