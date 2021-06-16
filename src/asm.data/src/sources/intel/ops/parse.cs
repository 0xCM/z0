//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {

        public static Outcome parse(string src, out ChapterPage dst)
        {
            var outcome = Outcome.Success;
            dst = ChapterPage.Empty;
            var i = text.index(src,Chars.Dash);
            if(i == NotFound)
            {
                outcome = (false, string.Format("Chapater/Page separator '{0}' not found", Chars.Dash));
                return outcome;
            }
            var left = src.LeftOfIndex(i);
            //outcome += DataParser.parse(left, out dst.Chapter);
            var right = src.RightOfIndex(i);
            //outcome += DataParser.parse(left, out dst.Page);
            return outcome;
        }

    }
}