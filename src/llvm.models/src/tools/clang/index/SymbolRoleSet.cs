//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang.index
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public readonly struct SymbolRoleSet
    {
        readonly uint Flags;

        [MethodImpl(Inline)]
        public SymbolRoleSet(uint flags)
        {
            Flags = flags;
        }
    }
}