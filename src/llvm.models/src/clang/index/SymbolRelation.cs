//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang.index
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0;

    using static Root;

    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public struct SymbolRelation
    {
        public SymbolRoleSet Roles;

        public Ref<Decl> RelatedSymbol;

        [MethodImpl(Inline)]
        public SymbolRelation(SymbolRoleSet roles, Decl decl)
        {
            Roles = roles;
            RelatedSymbol = decl;
        }
    }
}