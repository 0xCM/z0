//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static Chars;
    using static TextRules.Parse;

    public class AsmThumbprints : WfService<AsmThumbprints>
    {
        const string Implication = " => ";

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static Fence<char> SizeFence => (LBracket, RBracket);

        AsmSigs Sigs;

        AsmExpr Expr;

        protected override void OnInit()
        {
            Sigs = Wf.AsmSigs();
            Expr = AsmExpr.create(Wf);

        }

        [Op]
        public static AsmThumbprintExpr expression(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
        {
            var lhs = string.Format("({0})<{1}>[{2}]", sig, opcode,  encoded.Size);
            var rhs = encoded.Format();
            return new AsmThumbprintExpr(string.Concat(lhs,Implication,rhs));
        }

        [Op]
        public static string format(AsmThumbprint src)
        {
            var lhs = string.Format("({0})<{1}>[{2}]", src.Sig, src.OpCode,  src.Encoded.Size);
            var rhs = src.Encoded.Format();
            return string.Concat(lhs,Implication,rhs);
        }

        [Op]
        public static int cmp(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).CompareTo(format(b));

        [Op]
        public static bool eq(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).Equals(format(b));

        [Op]
        public static int cmp(in AsmThumbprintExpr a, in AsmThumbprintExpr b)
        {
            var e0 = a.Format().LeftOfFirst(Implication);
            var e1 = b.Format().LeftOfFirst(Implication);
            return e0.CompareTo(e1);
        }

        [MethodImpl(Inline), Op]
        public static AsmStatementThumbprint create(Address16 offset, AsmStatementExpr expr, AsmThumbprintExpr thumbprint)
            => new AsmStatementThumbprint(offset, expr, thumbprint);

        public Outcome Parse(string src, out AsmThumbprint thumbprint)
        {
            thumbprint = AsmThumbprint.Empty;

            var a = src.LeftOfFirst(Semicolon);
            var offset = HexNumericParser.parse16u(a.LeftOfFirst(Chars.Space)).ValueOrDefault();
            AsmStatementExpr statement = a.RightOfFirst(Semicolon);


            var parts = src.RightOfFirst(Semicolon).SplitClean(Implication);
            if(parts.Length == 2)
            {
                var lhs = parts[0];
                var rhs = parts[1];
                if(unfence(lhs, SigFence, out var sigexpr))
                {
                    if(Expr.Sig(sigexpr, out var sig))
                    {
                        if(!Sigs.ParseMnemonicCode(sig.Mnemonic, out var monic))
                            Wf.Warn($"Could not parse mnemonic code for {sig.Mnemonic}");

                        if(unfence(lhs, OpCodeFence, out var opcode))
                        {
                            if(AsmBytes.hexcode(rhs, out var encoded))
                            {
                                thumbprint = new AsmThumbprint(offset, statement, monic, sig, Expr.OpCode(opcode), encoded);
                                return true;
                            }
                            else
                                Wf.Error($"Could not parse the encoded bytes");
                        }
                        else
                            Wf.Error($"Could not located the opcode fence ${OpCodeFence}");

                    }
                    else
                        Wf.Error($"Could not parse sig expression from ${sigexpr}");
                }
                else
                    Wf.Error($"Could not locate the signature fence {SigFence}");
            }
            else
                Wf.Error($"Could not dichotomize {src} ");


            return false;
        }
    }

}