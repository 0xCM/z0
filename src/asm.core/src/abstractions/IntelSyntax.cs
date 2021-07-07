//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public sealed class IntelSyntax : AsmSyntax<IntelSyntax>
    {
        public override AsmSyntaxKind Kind => AsmSyntaxKind.Intel;
    }
}