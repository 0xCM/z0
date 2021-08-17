//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmParser
    {
        [Op]
        public static Outcome formxpr(string src, out AsmFormExpr dst)
        {
            dst = AsmFormExpr.Empty;
            var result = Outcome.Success;

            result = text.unfence(src, SigFence, out var sigexpr);
            if(result.Fail)
                return (false, FenceNotFound.Format(SigFence,src));

            result = sigxpr(sigexpr, out var _sig);
            if(result.Fail)
                return (false, Msg.CouldNotParseSigExpr.Format(sigexpr));

            result = text.unfence(src, OpCodeFence, out var opcode);
            if(result.Fail)
                return (false, FenceNotFound.Format(OpCodeFence, src));

            dst = new AsmFormExpr(asm.ocexpr(opcode), _sig);
            return true;
        }

        public static ref AsmFormRecord parse(in TextRow src, ref AsmFormRecord dst)
        {
            var i = 0;
            DataParser.parse(src[i++], out dst.Seq);
            ocxpr(src[i++], out dst.OpCode);
            sigxpr(src[i++], out dst.Sig);
            formxpr(src[i++], out dst.FormExpr);
            return ref dst;
        }

        public static MsgPattern<Fence<char>,string> FenceNotFound => "No content fenced with {0} exists int the input text '{1}'";
    }
}