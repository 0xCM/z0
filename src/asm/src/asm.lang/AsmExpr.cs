//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct AsmExpr
    {
        [Op]
        public static AsmExprParser parser(IWfShell wf)
            => AsmExprParser.create(wf);

        [MethodImpl(Inline), Op]
        public static AsmMnemonicExpr mnemonic(string src)
            => new AsmMnemonicExpr(src);

        /// <summary>
        /// Defines a <see cref='AsmSigOpExpr'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static AsmSigOpExpr sigop(string src)
            => new AsmSigOpExpr(src);

        /// <summary>
        /// Defines a <see cref='AsmSigOpToken'/>
        /// </summary>
        /// <param name="index">The identifier index that serves as a surrogate key for lookups</param>
        /// <param name="name">The identifer name</param>
        /// <param name="kind">The identifier kind</param>
        [MethodImpl(Inline), Op]
        public static AsmSigOpToken token(byte index, Identifier name, AsmSigOpKind kind, string symbol)
            => new AsmSigOpToken(index, name, kind, symbol);

        /// <summary>
        /// Creates a <see cref='AsmSigOpToken'/> index
        /// </summary>
        /// <param name="k">An identifier representative</param>
        [Op]
        public static Index<AsmSigOpToken> SigOpTokens()
        {
            var details = Enums.details<AsmSigOpKind,ushort>().View;
            var count = AsmSigOpKindFacets.IdentifierCount + 1;
            var buffer = alloc<AsmSigOpToken>(count);
            ref var dst = ref first(buffer);
            for(byte i=1; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var symbol = detail.Field.Tag<SymbolAttribute>().MapValueOrDefault(a => a.Symbol, EmptyString);
                seek(dst,i) = token(i, detail.Name, detail.LiteralValue, symbol);
            }
            return buffer;
        }

        /// <summary>
        /// Defines a <see cref='AsmOpCodeExpr'/>
        /// </summary>
        /// <param name="src">The source text</param>
        /// <remarks>
        /// Examples:
        /// 14 ib
        /// REX.W+ 81 /2 id
        /// VEX.NDS.LIG.F2.0F.WIG 58 /r
        /// REX+ 20 /r
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpr opcode(string src)
            => new AsmOpCodeExpr(src);

        /// <summary>
        /// Defines a signature expression
        /// </summary>
        /// <param name="src">The source text</param>
        /// <remarks>
        /// Instruction signatures are of the form
        /// 0 operands: {Mnemonic}
        /// 1 operand: {Mnemonic}{ }{op1}
        /// 2 operands: {Mnemonic}{ }{op1}{,}{op2}
        /// 3 operands: {Mnemonic}{ }{op1}{,}{op2},{op3}
        /// Example: PCMPISTRI xmm1, xmm2/m128, imm8
        /// <remarks>
        [MethodImpl(Inline), Op]
        public static AsmSigExpr sig(string src)
            => new AsmSigExpr(src);

        [MethodImpl(Inline), Op]
        public static AsmSpecifierExpr specifier(ushort seq, AsmOpCodeExpr op, AsmSigExpr sig)
            => new AsmSpecifierExpr(seq, op,sig);
    }
}