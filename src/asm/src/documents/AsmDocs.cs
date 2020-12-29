//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDocParts;

    [ApiHost]
    public readonly struct AsmDocs
    {
        [MethodImpl(Inline), Op]
        public static BlockHeader header(AsmRoutine src)
        {
            const string Separator = "; " + RP.PageBreak160;
            return new BlockHeader(Separator, src.Code.Uri, src.OpSig, src.Code, src.TermCode);
        }

        [MethodImpl(Inline), Op]
        public static LineLabel label(W8 w, ulong offset)
            => new LineLabel((byte)offset);

        [MethodImpl(Inline), Op]
        public static LineLabel label(W16 w, ulong offset)
            => new LineLabel((ushort)offset);

        [MethodImpl(Inline), Op]
        public static LineLabel label(W32 w, ulong offset)
            => new LineLabel((uint)offset);

        [MethodImpl(Inline), Op]
        public static LineLabel label(W64 w, ulong offset)
            => new LineLabel(offset);
    }
}