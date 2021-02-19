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
    using static TextRules;
    using static AsmExprFacets;

    [ApiHost]
    public readonly partial struct AsmExpr
    {
        public static bool composite(SigOperand operand)
            => operand.Content.Contains(CompositeOperandPartition);

        public static string format(Signature src)
        {
            var buffer = text.buffer();
            buffer.Append(src.Mnemonic.Format(AsmMnemonicCase.Uppercase));
            var opcount = src.Operands.Length;
            if(opcount != 0)
            {
                buffer.Append(Chars.Space);
                buffer.Append(Format.join(OperandDelimiter, src.Operands));
            }
            return buffer.Emit();
        }

        [Op]
        public static AsmExprParser parser(IWfShell wf)
            => AsmExprParser.create(wf);

        [MethodImpl(Inline), Op]
        public static AsmMnemonic mnemonic(string src)
            => new AsmMnemonic(src);

        /// <summary>
        /// Defines a <see cref='SigOperand'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static SigOperand sigop(string src)
            => new SigOperand(src);

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
        /// Defines a <see cref='OpCode'/>
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
        public static OpCode opcode(string src)
            => new OpCode(src);

        [MethodImpl(Inline), Op]
        public static OperationSpec specifier(ushort seq, OpCode op, Signature sig)
            => new OperationSpec(seq, op, sig);
    }
}