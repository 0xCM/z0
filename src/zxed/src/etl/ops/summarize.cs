//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static XedSourceMarkers;

    partial struct XedOps
    {
        public static XedPatternSummary summary(in XedPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOf(ASSIGN).Trim(), EmptyString);
            return new XedPatternSummary(
                Class: src.Class,
                Category: src.Category,
                Extension: src.Extension,
                IsaSet: src.IsaSet,
                BaseCode: src.BaseCode(),
                Mod: src.Mod(),
                Reg: src.Reg(),
                Pattern: src.PatternText,
                Operands: src.OperandText);
        }
    }
}