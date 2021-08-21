//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct McOperand
    {
        public AsmOpClass Class;

        public ulong Value;

        [MethodImpl(Inline)]
        public McOperand(AsmOpClass @class, ulong value)
        {
            Class = @class;
            Value  = value;
        }
    }
}