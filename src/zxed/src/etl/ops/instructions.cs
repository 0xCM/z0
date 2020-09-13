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

    using R = XedInstructionRecord;

    partial struct XedOps
    {
        [Op]
        public static R[] instructions(XedPattern[] src)
        {
            var input = @readonly(src);
            var count = input.Length;
            var dst = alloc<R>(count);
            var target = span(dst);
            for(var i=0u; i<count; i++)
            {
                ref readonly var x = ref skip(input,i);
                seek(target,i) = new R(
                    Sequence: (int)i,
                    Mnemonic: x.Class,
                    Extension: x.Extension,
                    BaseCode: x.BaseCodeText(),
                    Mod: default,
                    Reg: default);
            }
            return dst;
        }
    }
}