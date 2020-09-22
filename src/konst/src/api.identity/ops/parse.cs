//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static IDI;

    partial struct ApiIdentity
    {
        [Op]
        public static OpIdentity parse(string src)
        {
            if(text.empty(src))
                return OpIdentity.Empty;

            var name = src.TakeBefore(PartSep);
            var suffixed = src.Contains(SuffixSep);
            var suffix = suffixed ? src.TakeAfter(IDI.SuffixSep) : EmptyString;
            var generic = src.TakeAfter(PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = src.SplitClean(PartSep);
            var id = OpIdentity.define(src, name, suffix, generic, imm, components);
            return id;
        }
    }
}