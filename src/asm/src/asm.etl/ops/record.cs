//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmEtl
    {

        [MethodImpl(Inline), Op]
        public static AsmSpecifierRecord record(AsmSpecifierExpr src)
        {
            var dst = new AsmSpecifierRecord();
            dst.Seq = src.Seq;
            dst.Sig = src.Sig;
            dst.OpCode = src.OpCode;
            return dst;
        }

        internal static ReadOnlySpan<byte> AsmSpecifierWidths => new byte[]{8,48,32};
    }
}