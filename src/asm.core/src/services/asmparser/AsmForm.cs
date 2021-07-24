//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmParser
    {
        [Op]
        public static Outcome form(string src, out AsmFormExpr dst)
        {
            dst = AsmFormExpr.Empty;
            var result = Outcome.Success;

            result = FenceParser.unfence(src, SigFence, out var sigexpr);
            if(result.Fail)
                return (false, ParseComposer.FenceNotFound.Format(SigFence,src));

            result = sig(sigexpr, out var _sig);
            if(result.Fail)
                return (false, Msg.CouldNotParseSigExpr.Format(sigexpr));

            result = FenceParser.unfence(src, OpCodeFence, out var opcode);
            if(result.Fail)
                return (false, ParseComposer.FenceNotFound.Format(OpCodeFence, src));

            dst = new AsmFormExpr(asm.opcode(opcode), _sig);
            return true;
        }

        public static ref AsmFormRecord parse(in TextRow src, ref AsmFormRecord dst)
        {
            var i = 0;
            DataParser.parse(src[i++], out dst.Seq);
            opcode(src[i++], out dst.OpCode);
            sig(src[i++], out dst.Sig);
            form(src[i++], out dst.FormExpr);
            return ref dst;
        }
    }
}
