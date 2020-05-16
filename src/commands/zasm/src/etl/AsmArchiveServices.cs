//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Xed;
    using Z0.Asm;
    using Z0.Asm.Data;
    using Z0.Asm.Encoding;

    public interface IAsmArchives : IAsmArchiveConfig
    {
        InstrInfo[] InstructionsData();   

        OpCodeRecord[] PublishOpCodeDetails(out FilePath dst);
    }

    public readonly struct AsmArchives  : IAsmArchives
    {
        public static IAsmArchives Service => default(AsmArchives);

        OpCodeOperandKind[] Operands(OpCodeInfo src)
        {
            var count = src.OpKindsLength;
            var dst = new OpCodeOperandKind[count];
            for(var i=0; i<count; i++)
                dst[i] = src.OpKind(i);
            return dst;
        }

        public OpCodeRecord Record(OpCodeInfo src)
            => new OpCodeRecord(
                    Id: src.Code.RawName, 
                    CodeBytes: src.Code.Value.ToByteArray(),
                    MandatoryPrefix: src.MandatoryPrefix,
                    TableKind: src.Table,
                    GroupIndex: src.GroupIndex,
                    Flags: src.Flags,
                    OpSize: src is LegacyOpCodeInfo l1 ? l1.OperandSize : OperandSize.None,
                    AddressSize: src is LegacyOpCodeInfo l2 ? l2.AddressSize : AddressSize.None,
                    Operands(src)
                    );

        public InstrInfo[] InstructionsData()
            => InstrInfoTable.Data;

        public OpCodeRecord[] PublishOpCodeDetails(out FilePath dst)
        {
            var table = OpCodeInfoTable.Data;
            var records = new OpCodeRecord[table.Length];
            for(var i=0; i<table.Length; i++)
                records[i] = Record(table[i]);

            var config = AsmArchiveConfig.Default;
            dst = config.DatasetPath("opcodes.details");
            OpCodeRecord.Save(records, dst);
            return records;

        }
    }
}