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

    using F = XedPatternField;
    using Formatter = FieldFormatter<XedPatternField>;

    partial struct XedOps
    {
        [MethodImpl(Inline), Op]
        public static ref readonly Formatter emit(in XedPattern src, in Formatter dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, src.BaseCode());
            dst.Delimit(F.Mod, src.Mod());
            dst.Delimit(F.Reg, src.Reg());
            dst.Delimit(F.Pattern, src.PatternText);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly Formatter emit(in XedPatternSummary src, in Formatter dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, src.BaseCode);
            dst.Delimit(F.Mod, src.Mod);
            dst.Delimit(F.Reg, src.Reg);
            dst.Delimit(F.Pattern, src.Pattern);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }
    }
}