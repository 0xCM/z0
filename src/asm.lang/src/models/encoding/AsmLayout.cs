//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static LayoutComponents;

    public struct AsmLayout
    {
        public Index<Prefix> Prefixes;

        public IOpCode OpCode;

        public ModRm ModRm;

        public Sib Sib;

        public Displacement Dx;

        public Immediate Imm;
    }
}