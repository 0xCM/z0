//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static XedSourceMarkers;

    partial struct XedWfOps
    {
        public static string reg(XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);
    }
}