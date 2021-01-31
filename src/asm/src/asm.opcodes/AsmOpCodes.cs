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

    using F = AsmOpCodeField;

    [ApiHost]
    readonly struct AsmOpCodesLegacy
    {
        [MethodImpl(Inline)]
        public static DatasetFormatter<T> formatter<T>()
            where T : unmanaged, Enum
                => Table.dsformatter<T>();

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExprLegacy identity(in AsmOpCodeRowLegacy src)
            => AsmOpCodeExprLegacy.create(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<AsmOpCodeRowLegacy> src, Span<AsmOpCodeExprLegacy> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = identity(skip(src,i));
        }

        [Op]
        public static AsmOpCodeDatasetLegacy dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Res).Assembly).MatchDocument(ContentNames.OpCodeSpecs);
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeRowLegacy>(count);
            parse(resource, records);
            var identifers = sys.alloc<AsmOpCodeExprLegacy>(count);
            identify(records, identifers);
            return new AsmOpCodeDatasetLegacy(records,identifers);
        }

        [Op]
        public static void parse(in AppResDoc specs, Span<AsmOpCodeRowLegacy> dst)
        {
            var fields = Enums.literals<F>();
            var src = specs.Rows.View;
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op]
        public static ref readonly AsmOpCodeRowLegacy parse(in TextRow src, ReadOnlySpan<F> fields, ref AsmOpCodeRowLegacy dst)
        {
            var cells = src.Cells.View;
            var count = root.length(cells, fields);
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(cells, i);
                ref readonly var field = ref skip(fields, i);

                switch(field)
                {
                    case F.Sequence:
                        Numeric.parse(cell, out dst.Sequence);
                        break;
                    case F.Mnemonic:
                        dst.Mnemonic = cell;
                        break;
                    case F.OpCode:
                        dst.OpCode = cell;
                        break;
                    case F.Instruction:
                        dst.Instruction = cell;
                        break;
                    case F.M16:
                        dst.M16 = bit.parse(cell);
                        break;
                    case F.M32:
                        dst.M32 = bit.parse(cell);
                        break;
                    case F.M64:
                        dst.M64 = bit.parse(cell);
                        break;
                    case F.CpuId:
                        dst.CpuId = cell;
                        break;
                    case F.CodeId:
                        dst.CodeId = Enums.parse(cell, IceOpCodeId.INVALID);
                        break;
                }
            }

            return ref dst;
        }

        [Op]
        public static ref readonly DatasetFormatter<F> format(in AsmOpCodeRowLegacy src, in DatasetFormatter<F> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.M16, src.M16);
            dst.Delimit(F.M32, src.M32);
            dst.Delimit(F.M64, src.M64);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.CodeId, src.CodeId);
            return ref dst;
        }
    }
}