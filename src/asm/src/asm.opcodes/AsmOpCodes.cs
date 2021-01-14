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
        public static AsmMnemonic mnemonic(in AsmOpCodeRow src)
            => new AsmMnemonic(src.Mnemonic);

        [MethodImpl(Inline), Op]
        public static Cpuid cpuid(in AsmOpCodeRow src)
            => new Cpuid(src.CpuId);

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

        public static Index<TokenRecord> Tokens
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

        public static Index<string> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => ClrEnums.names<IceMnemonic>();
        }

        [MethodImpl(Inline)]
        public static DatasetFormatter<T> formatter<T>()
            where T : unmanaged, Enum
                    => Formatters.dataset<T>();

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