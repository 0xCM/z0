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
            => Deconstructor.Decode(src.Id, src.Label, src.Code.Data);

        public static AsmCodeSet CodeSet(this INativeMemberData src, Moniker moniker, CilFunction cil)
        {
            var label = src.Method.Signature().Format();            
            return AsmCodeSet.Define(moniker, Deconstructor.Decode(src.Code), cil);
        }

        public static IEnumerable<InstructionBlock> Instructions<T>(this IEnumerable<T> src)
            where T : INativeMemberData
                => from member in src select member.Instructions();
    }
}