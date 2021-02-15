//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    public class AsmBlocks : AsmWfService<AsmBlocks>
    {
        public const string LocatedMarker = "located://";

        public const char Assign = Chars.Eq;

        public const char CommentMarker = Chars.Semicolon;

        const string SigSplitter = "::";

        // ; void mov(ref m32 dst, r32 src)::located://asm/asmmachine?mov#mov_(m32~ref,r32)
        // ; public static ReadOnlySpan<byte> mov_ᐤm32ᕀrefㆍr32ᐤ => new byte[48]{0x0f,0x1f,0x44,0x00,0x00,0x4c,0x89,0x44,0x24,0x18,0x8b,0x44,0x24,0x1c,0x41,0xb8,0x00,0x04,0x00,0x00,0xc4,0xe2,0x38,0xf7,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc1,0x10,0x4c,0x8b,0x01,0x8b,0x49,0x08,0x48,0x63,0xc0,0x41,0x8b,0x04,0xc0,0x89,0x02,0xc3};
        // ; BaseAddress = 7ffe65128e00h
        [Op]
        public bool ParseHeader(ReadOnlySpan<string> lines, out AsmBlockHeader dst)
        {
            var fail = ParseResult.fail<AsmBlockHeader>(lines.Concat(Chars.NL));
            dst = default;


            if(lines.Length < 3)
                return false;

            var parser = AsmExprParser.create(Wf);
            var l0 = skip(lines,0).RightOfFirst(CommentMarker);
            var l1 = skip(lines,1).RightOfFirst(CommentMarker);
            var l2 = skip(lines,2).RightOfFirst(CommentMarker);

            var sig = l0.LeftOfFirst(SigSplitter);
            var uriParse = ApiUri.parse(l0.RightOfFirst(SigSplitter));
            if(uriParse.Failed)
                return fail;

            var uri = uriParse.Value;
            var propParts = l1.SplitClean(Assign);

            var @base = MemoryAddress.Zero;
            if(!parser.ParseAddress(l2.RightOfFirst(Assign), out @base))
                @base = MemoryAddress.Zero;

            dst = new AsmBlockHeader(uri, sig, l1, @base);
            return true;
        }
    }
}