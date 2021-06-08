//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    partial class AsmEncoderPrototype
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode @lock(LockPrefix code, uint4 index)
        {
            var dst = AsmBytes.code();
            dst.Cell(index) = (byte)code;
            return dst;
        }
    }
}