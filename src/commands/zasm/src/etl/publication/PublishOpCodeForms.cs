//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using Z0.Asm.Data;

    using static Seed;
    using static AsmDataModels;
    using static Tabular;

    using F = OpCodeFormField;
    using R = OpCodeFormRecord;

    partial class AsmEtl
    {        
        /// <summary>
        /// Publishes a model-identified dataset to the target archive
        /// </summary>
        /// <param name="model">The data model</param>
        public AsmPublication<OpCodeFormRecord> Publish(OpCodes model)
        {
            var src = Publish(model, out var dst);
            return AsmPublication.Flow(src, dst);            
        }
        
        R[] Save(OpCodeFormRecord[] src, FilePath dst)
            => Records.Save<F,R>(src, dst, Format);

        OpCodeFormRecord[] Publish(OpCodes model, out FilePath dst)
        {
            var table = OpCodeInfoTable.Data;
            var records = new OpCodeFormRecord[table.Length];
            
            for(var i=0; i<table.Length; i++)
                records[i] = Record(model,i,table[i]);

            dst = Config.DatasetPath(model.Name);
            return Save(records, dst);
        }        

        public string Format(OpCodeFormRecord src)
        {
            var dst = Records.Formatter<F>();
            dst.DelimitField(F.Sequence, src.Sequence);
            dst.DelimitField(F.Id, src.Id);
            dst.DelimitField(F.CodeBytes, src.CodeBytes);
            dst.DelimitSome(F.Prefix, src.Prefix);
            dst.DelimitField(F.Table, src.Table);
            dst.DelimitField(F.Group, src.Group == - 1 ? string.Empty : src.Group.ToString());
            dst.DelimitSome(F.Op1, src.Op1);
            dst.DelimitSome(F.Op2, src.Op2);
            dst.DelimitSome(F.Op3, src.Op3);
            dst.DelimitSome(F.Op4, src.Op4);
            dst.DelimitSome(F.OpSize, src.OpSize);
            dst.DelimitSome(F.AddressSize, src.AddressSize);
            dst.DelimitField(F.Flags, src.Flags);
            return dst.Render();                             
        }      

        OpCodeOperandKind[] Operands(OpCodes model, OpCodeInfo src)
        {
            var count = src.OpKindsLength;
            var dst = new OpCodeOperandKind[count];
            for(var i=0; i<count; i++)
                dst[i] = src.OpKind(i);
            return dst;
        }

        public OpCodeFormRecord Record(OpCodes model, int seq,  OpCodeInfo src)
            => new OpCodeFormRecord(
                    Sequence: seq,
                    Id: src.Code.RawName, 
                    CodeBytes: src.OpCode.ToByteArray(),
                    MandatoryPrefix: src.MandatoryPrefix,
                    TableKind: src.Table,
                    GroupIndex: src.GroupIndex,
                    Flags: src.Flags,
                    OpSize: src is LegacyOpCodeInfo l1 ? l1.OperandSize : OperandSize.None,
                    AddressSize: src is LegacyOpCodeInfo l2 ? l2.AddressSize : AddressSize.None,
                    Operands(model, src)
                    );

    }

}

