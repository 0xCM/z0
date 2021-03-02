//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;
    using static TextRules;
    using static AsmExprFacets;

    [ApiHost]
    public readonly partial struct AsmExpr
    {
        public static SymbolTable<CompositeKind> composites()
            => SymbolTables.create<CompositeKind>();

        public enum CompositeKind : byte
        {
            [Symbol("")]
            None = 0,

            [Symbol("r/m8")]
            Rm8,

            [Symbol("r/m16")]
            Rm16,

            [Symbol("r/m32")]
            Rm32,

            [Symbol("r/m64")]
            Rm64,

            [Symbol("reg/m8")]
            RegM8,

            [Symbol("reg/m16")]
            RegM16,

            [Symbol("reg/m32")]
            RegM32,

            [Symbol("reg")]
            Reg,

            [Symbol("m")]
            M,

            [Symbol("mem")]
            Mem,
        }

        [Op]
        public static Index<SigOperand> decompose(SigOperand src)
            => src.IsComposite ? src.Content.SplitClean(CompositeIndicator).Map(AsmSigs.sigop) : array(src);

        [Op]
        public static bool composite(SigOperand src)
            => src.Content.Contains(CompositeIndicator);

        [Op]
        public static bool composite(Signature src)
            => src.Operands.Any(o => o.IsComposite);

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
        public static OperationSpec operation(ushort seq, OpCode op, Signature sig)
            => new OperationSpec(seq, op, sig);

        [MethodImpl(Inline), Op]
        public static OperationSpec operation(OperationSpec spec, byte index, Signature sig)
            => new OperationSpec((byte)((uint)spec.Seq | (uint)index << 8), spec.OpCode, sig);
    }
}