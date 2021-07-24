//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static Chars;

    partial struct AsmParser
    {
        public static Outcome thumbprint(string src, out AsmThumbprint thumbprint)
        {
            thumbprint = AsmThumbprint.Empty;
            var result = Outcome.Success;
            var a = src.LeftOfFirst(Semicolon);
            var offset = HexNumericParser.parse16u(a.LeftOfFirst(Chars.Space)).ValueOrDefault();
            AsmExpr statement = a.RightOfFirst(Semicolon);

            var parts = @readonly(src.RightOfFirst(Semicolon).SplitClean(Implication));
            if(parts.Length < 2)
                return (false, $"Could not partition {src} ");

            var A = skip(parts,0);
            var B = skip(parts,1).Trim();

            // For thumbprints that include a bitstring such as 0001 0000 0000 1111
            var C = parts.Length > 2 ? skip(parts,2) : EmptyString;
            if(FenceParser.unfence(A, SigFence, out var sigexpr))
            {
                result = AsmParser.sig(sigexpr, out var sig);
                if(result.Fail)
                    return (false, $"Could not parse sig expression from ${sigexpr}");

                    AsmParser.code(sig.Mnemonic, out var monic);

                    if(FenceParser.unfence(A, OpCodeFence, out var opcode))
                    {
                        if(AsmHexCode.parse(B, out var encoded))
                        {
                            thumbprint = new AsmThumbprint(statement, sig, asm.opcode(opcode), encoded);
                            return true;
                        }
                        else
                            return (false, "Could not parse the encoded bytes");
                    }
                    else
                        return (false, Msg.OpCodeFenceNotFound.Format(OpCodeFence));
            }
            else
                return (false, $"Could not locate the signature fence {SigFence}");
        }

    }
}
