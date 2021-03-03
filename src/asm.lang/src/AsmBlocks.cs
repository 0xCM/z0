//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    public class AsmBlocks : WfService<AsmBlocks, AsmBlocks>
    {
        public const string LocatedMarker = "located://";

        public const char Assign = Chars.Eq;

        public const char CommentMarker = Chars.Semicolon;

        const string SigSplitter = "::";

        [Op]
        public bool ParseHeader(ReadOnlySpan<string> src, out AsmBlockHeader dst)
        {
            var fail = ParseResult.fail<AsmBlockHeader>(src.Join(Chars.NL));
            dst = default;

            if(src.Length < 3)
                return false;

            var l0 = skip(src,0).RightOfFirst(CommentMarker);
            var l1 = skip(src,1).RightOfFirst(CommentMarker);
            var l2 = skip(src,2).RightOfFirst(CommentMarker);

            var sig = l0.LeftOfFirst(SigSplitter);
            var uriParse = ApiUri.parse(l0.RightOfFirst(SigSplitter));
            if(uriParse.Failed)
                return fail;

            var uri = uriParse.Value;
            var propParts = l1.SplitClean(Assign);

            var @base = MemoryAddress.Zero;
            if(!ParseAddress(l2.RightOfFirst(Assign), out @base))
                @base = MemoryAddress.Zero;

            dst = new AsmBlockHeader(uri, sig, l1, @base);
            return true;
        }

        [Op]
        public bool ParseAddress(string src, out MemoryAddress dst)
        {
            dst = HexScalarParser.Service.Parse(src,ulong.MaxValue);
            return dst != ulong.MaxValue;
        }
    }
}