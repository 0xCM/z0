//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using C = AsciCode;

    sealed class LlvmMnemonicProcessor //: LlvmTextProcessor<MnemonicIndexEntry>
    {

        //EG:
        //  /* 0 */ "prefetcht0\t\0"
        //  /* 12 */ "sha1msg1\t\0"
        public static Outcome ProcessLine(ref AsciLine src, out MnemonicIndexEntry dst)
        {
            dst = default;
            var i = src.StartPos;
            var open = TextTools.next(src.Content, i, C.FSlash, C.Star);
            if(open < 0)
                return (false,"Opening sequence '/*' not found");
            i = (uint)open + 2;

            var close = TextTools.next(src.Content, i, C.Star, C.FSlash);
            if(close < 0)
                return (false,"Opening sequence '*/' not found");

            var offset = slice(src.Content, i, close - i);

            dst = new MnemonicIndexEntry(src.LineNumber, 0, 0);

            return true;
        }
    }
}