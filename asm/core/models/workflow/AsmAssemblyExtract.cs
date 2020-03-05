//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;

    public readonly struct AsmAssemblyExtract
    {
        [MethodImpl(Inline)]
        public static AsmAssemblyExtract Define(AssemblyId owner, AsmOpExtract[] ops)
            => new AsmAssemblyExtract(owner, ops);
        
        [MethodImpl(Inline)]
        AsmAssemblyExtract(AssemblyId id, AsmOpExtract[] ops)
        {
            this.Assembly = id;
            this.Extracted = ops;
        }

        public readonly AssemblyId Assembly;

        public readonly AsmOpExtract[] Extracted;        
    }
}