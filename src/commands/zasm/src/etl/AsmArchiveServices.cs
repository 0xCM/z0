//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;
    using Z0.Asm.Data;
    using Z0.Data;

    public interface IAsmArchives : IAsmArchiveConfig
    {
        InstrInfo[] InstructionsData();   

        Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum;

        OpCodeRecord[] PublishOpCodeDetails(out FilePath dst);
    }

    public readonly struct AsmArchives  : IAsmArchives
    {
        public static IAsmArchives Service => default(AsmArchives);

        static string Describe<E>(E literal)
            where E : unmanaged, Enum
        {            
            var info = CommentAttribute.GetDocumentation(typeof(E).Field(literal.ToString()).Require());
            return info ?? string.Empty;
        }
        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
        {
            var config = this as IAsmArchiveConfig;
            var dst = config.DatasetPath(typeof(E).Name);            
            var report = LiteralTable.Report<E>(Describe);
            return report.Save(dst);
        }

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
                    CodeBytes: src.OpCode.ToByteArray(),
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