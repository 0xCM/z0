//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;


    [ApiHost]
    public partial class AsmRecords : Service<AsmRecords>
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ref AsmInfoRecord fill(in AsmInfo src, out AsmInfoRecord dst)
        {
            dst.Id = src.Id;
            CharBlocks.hydrate(src.OpCodeExpr, out dst.OpCodeExpr);
            CharBlocks.hydrate(src.SigExpr, out dst.SigExpr);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static uint fill(ReadOnlySpan<AsmInfo> src, ref uint i, Span<AsmInfoRecord> dst)
        {
            var i0 = i;
            var count = (uint)src.Length;
            for(; i<count; i++)
                fill(skip(src,i), out seek(dst,i));
            return i - i0;
        }
    }
}