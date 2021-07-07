//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public sealed class NasmSyntax : AsmSyntax<NasmSyntax>
    {
        public override AsmSyntaxKind Kind => AsmSyntaxKind.Nasm;
    }
}