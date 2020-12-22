//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using F = XedPatternField;
    using XF = XedInstructionField;

    partial struct XedWfOps
    {
        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFieldFormatter<XedPatternField> render(in XedPattern src, in DatasetFieldFormatter<XedPatternField> dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, code(src));
            dst.Delimit(F.Mod, mod(src));
            dst.Delimit(F.Reg, reg(src));
            dst.Delimit(F.Pattern, src.PatternText);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFieldFormatter<XedPatternField> render(in XedPatternRow src, in DatasetFieldFormatter<XedPatternField> dst)
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

        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFormatter<XedInstructionField> render(in XedInstructionRow src, in DatasetFormatter<XedInstructionField> dst)
        {
            dst.Delimit(XF.Sequence, src.Sequence);
            dst.Delimit(XF.Mnemonic, src.Mnemonic);
            dst.Delimit(XF.Extension, src.Extension);
            dst.Delimit(XF.BaseCode, src.BaseCode);
            dst.Delimit(XF.Mod, src.Mod);
            dst.Delimit(XF.Reg, src.Reg);
            return ref dst;
        }
    }
}