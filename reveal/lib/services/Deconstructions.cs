//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    public static class Deconstructions
    {
        public static InstructionBlock Instructions(this INativeMemberData src)
            => Deconstructor.Decode(src.Method.Signature().Format(), src.Content);

        public static AsmCodeSet CodeSet(this INativeMemberData src, Moniker moniker, CilFunction cil)
        {
            var label = src.Method.Signature().Format();
            return AsmCodeSet.Define(moniker, Deconstructor.Decode(label, src.Content), cil);
        }

        public static IEnumerable<InstructionBlock> Instructions<T>(this IEnumerable<T> src)
            where T : INativeMemberData
                => from member in src select member.Instructions();
    }
}