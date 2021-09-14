//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;
    using llvm.stringtables;

    using static Root;

    [ApiComplete]
    public readonly struct Strings
    {
        public static MemoryStrings<AsmId> OpCodes
        {
            [MethodImpl(Inline)]
            get => MemoryStrings.load<AsmId>(stringtables.Instruction.Offsets, stringtables.Instruction.Data);
        }
    }
}