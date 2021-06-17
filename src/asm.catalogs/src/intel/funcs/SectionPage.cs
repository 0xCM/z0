//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static Root;
    using static IntelSdm;

    partial class IntelSdmProcessor
    {
        public static void render(in SectionPage src, ITextBuffer dst)
        {
            dst.Append(Chars.LBracket);
            render(src.Section, dst);
            dst.Append(Chars.Space);
            render(src.Page, dst);
            dst.Append(Chars.RBracket);
        }
    }
}