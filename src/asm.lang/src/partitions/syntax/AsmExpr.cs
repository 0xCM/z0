//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public partial class AsmExpr : WfService<AsmExpr>
    {
        AsmSigs Sigs;

        protected override void OnInit()
        {
            Sigs = Wf.AsmSigs();
        }

        public Outcome Mnemonic(string sig, out AsmMnemonic dst)
            => Sigs.ParseMnemonicExpr(sig, out dst);

        public Outcome Sig(string src, out AsmSigExpr dst)
            => Sigs.ParseSigExpr(src, out dst);

        public AsmStatementExpr Statement(string src)
            => new AsmStatementExpr(src);

        public AsmOpCodeExpr OpCode(string src)
            => new AsmOpCodeExpr(src);
    }
}