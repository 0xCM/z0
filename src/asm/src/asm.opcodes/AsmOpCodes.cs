//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using F = AsmOpCodeField;

    [ApiHost(ApiNames.AsmOpCodes, true)]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCodePartitoner partitoner()
            => default;

        [MethodImpl(Inline), Op]
        public static AsmOpCodeGroup group(int count)
            => new AsmOpCodeGroup((uint)count);

        [MethodImpl(Inline), Op]
        public static MnemonicExpression mnemonic(in AsmOpCodeRow src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline), Op]
        public static CpuidExpression cpuid(in AsmOpCodeRow src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline), Op]
        public static OperatingMode mode(in AsmOpCodeRow src)
        {
            if(src.M16)
                return OperatingMode.Mode16;
            else if(src.M32)
                return OperatingMode.Mode32;
            else if(src.M64)
                return OperatingMode.Mode64;
            else
                return OperatingMode.None;
        }

        /// <summary>
        /// Selects the opcode expression from the source table
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(in AsmOpCodeRow src)
            => new AsmOpCode(src.OpCode);

        [MethodImpl(Inline), Op]
        public static AsmSig sig(string src)
            => new AsmSig(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(string src)
            => new AsmOpCode(src);

        /// <summary>
        /// Selects the instruction pattern from the source table
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsmSig sig(in AsmOpCodeRow src)
            => new AsmSig(src.Instruction);

        [MethodImpl(Inline), Op]
        public static AsmSpecifier specifier(in AsmSig sig, in AsmOpCode opcode)
            => new AsmSpecifier(sig, opcode);

        [Op]
        public static AsmOpCodeTokens tokens(ReadOnlySpan<FieldRef> src)
        {
            var dst = alloc<AsmOpCodeToken>(src.Length);
            tokens(src,dst);
            return new AsmOpCodeTokens(dst);
        }

        [MethodImpl(Inline), Op]
        public static void tokens(ReadOnlySpan<FieldRef> src, Span<AsmOpCodeToken> dst)
        {
            var count = src.Length;
            for(byte i=0; i<count; i++)
                seek(dst, i) = new AsmOpCodeToken(i, (AsmOpCodeTokenKind)(i + 1), skip(src,i).NameRef);
        }

        public static TableSpan<TokenRecord> Tokens
            => AsmTokenIndex.create().Records;

        [MethodImpl(Inline), Op]
        public AsmOpCodeOperand operand(ulong src, uint2 index)
            => new AsmOpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [Op]
        public static AsmSymbols symbols()
            => new AsmSymbols(SymbolStore.named<IceMnemonic,ushort>(), SymbolStore.named<RegisterKind,uint>(), AsmOpCodes.dataset());

        [MethodImpl(Inline), Op]
        public static AsmOpCodePart part(asci8 src)
            => new AsmOpCodePart(src);

        public static EnumLiteralNames<IceMnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<IceMnemonic>();
        }

        [Op]
        public static void parse(in AppResDoc specs, Span<AsmOpCodeRow> dst)
        {
            var fields = Enums.literals<F>();
            var src = specs.Rows.View;
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op, MethodImpl(Inline)]
        public static Span<AsmOpCodeRow> rows(in AppResDoc specs)
        {
            var dst = Spans.alloc<AsmOpCodeRow>(specs.Rows.Length);
            parse(specs, dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static DatasetFormatter<T> formatter<T>()
            where T : unmanaged, Enum
                    => Formatters.dataset<T>();
        [Op]
        public static AsmOpCodeDataset dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Res).Assembly).MatchDocument(PartResId.OpCodeSpecs);
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeRow>(count);
            AsmTables.parse(resource, records);
            var identifers = sys.alloc<AsmOpCode>(count);
            AsmOpCodes.identify(records, identifers);
            return new AsmOpCodeDataset(records,identifers);
        }

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCode identity(in AsmOpCodeRow src)
            => new AsmOpCode(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<AsmOpCodeRow> src, Span<AsmOpCode> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = identity(skip(src,i));
        }
    }
}