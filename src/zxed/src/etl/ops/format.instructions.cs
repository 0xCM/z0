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

    using F = XedInstructionField;
    using S = XedInstructionRecord;
    using T = DatasetFormatter<XedInstructionField>;

    partial struct XedOps
    {
        [MethodImpl(Inline), Op]
        public static string format(in S src, in T dst)
            => emit(src, dst).Render();

        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFormatter<F> emit(in S src, in T dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.BaseCode, src.BaseCode);
            dst.Delimit(F.Mod, src.Mod);
            dst.Delimit(F.Reg, src.Reg);
            return ref dst;
        }
    }
}