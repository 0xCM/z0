//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    using F = Asm.AsmRecordField;

    partial struct asm
    {
        public static string format(in AsmRecord src, char delimiter = FieldDelimiter)
            => format(src, Formatters.dataset<F>(delimiter)).Render();

        public static string format(in AsmCall src)
        {
            var site = asm.offset(src);
            var target =  src.CalledTarget.Base;
            var offset = (site - target).Location;
            var delta = (src.ActualTarget.Base - site).Location;
            var actual = src.ActualTarget.Id;
            var client_field = text.concat(src.Client.Id, text.embrace(site.Format()));
            return $"{client_field} | {target} | {offset} | {actual} | {delta}";
        }

        public static ref readonly DatasetFormatter<AsmRecordField> format(in AsmRecord src, in DatasetFormatter<AsmRecordField> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.GlobalOffset, src.GlobalOffset);
            dst.Delimit(F.LocalOffset, src.LocalOffset);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Encoded, src.Encoded);
            dst.Delimit(F.InstructionFormat, src.InstructionFormat);
            dst.Delimit(F.InstructionCode, src.InstructionCode);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.CodeId, src.CodeId);
            return ref dst;
        }
    }
}