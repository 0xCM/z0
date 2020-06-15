//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static Konst;

    using M = AsmDataModels;
    using F = OpCodeFormField;
    using R = OpCodeFormRecord;

    partial class AsmEtl
    {        
        /// <summary>
        /// Publishes a model-identified dataset to the target archive
        /// </summary>
        /// <param name="model">The data model</param>
        public Publication<OpCodeFormRecord> Publish(M.OpCodeForms model, OpCodeRecords specs)
        {
            var src = Publish(model, specs, out var dst);
            return Publications.Flow(src, dst);            
        }
        
        R[] Save(OpCodeFormRecord[] src, FilePath dst)
            => AsmRecords.Save<F,R>(src, dst, Format);

        static OpCodeId ParseOpCodeId(string src)
            => Enums.Parse(src, OpCodeId.INVALID);

        OpCodeFormRecord[] Publish(M.OpCodeForms model, OpCodeRecords specs, out FilePath dst)
        {
            var table = OpCodeInfoTable.Data.OrderBy(x => x.Code.RawName);
            var records = new OpCodeFormRecord[table.Length];
            
            for(var i=0; i<table.Length; i++)
            {
                var info = table[i];                
                var id = (OpCodeId)info.Code.Value;
                records[i] = new OpCodeFormRecord(
                    Sequence: i,
                    Id: id, 
                    Mnemonic: specs[id].Mnemonic,
                    CodeBytes: info.OpCode.ToByteArray(),
                    MandatoryPrefix: info.MandatoryPrefix,
                    TableKind: info.Table,
                    GroupIndex: info.GroupIndex,
                    Flags: info.Flags,
                    OpSize: info is LegacyOpCodeInfo l1 ? l1.OperandSize : OperandSize.None,
                    AddressSize: info is LegacyOpCodeInfo l2 ? l2.AddressSize : AddressSize.None,
                    Operands(model, info)
                    );
            }

            dst = Config.DatasetPath(model);
            return Save(records, dst);
        }        

        string Format(OpCodeFormRecord src)
        {
            var dst = AsmRecords.Formatter<F>();
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.CodeBytes, src.CodeBytes);
            dst.DelimitSome(F.Prefix, src.Prefix);
            dst.Delimit(F.Table, src.Table);
            dst.Delimit(F.Group, src.Group == - 1 ? string.Empty : src.Group.ToString());
            dst.DelimitSome(F.Op1, src.Op1);
            dst.DelimitSome(F.Op2, src.Op2);
            dst.DelimitSome(F.Op3, src.Op3);
            dst.DelimitSome(F.Op4, src.Op4);
            dst.DelimitSome(F.OpSize, src.OpSize);
            dst.DelimitSome(F.AddressSize, src.AddressSize);
            dst.Delimit(F.Id, src.Id);
            dst.Delimit(F.Flags, src.Flags);
            return dst.Render();                             
        }      

        OpCodeOperandKind[] Operands(M.OpCodeForms model, OpCodeInfo src)
        {
            var count = src.OpKindsLength;
            var dst = new OpCodeOperandKind[count];
            for(var i=0; i<count; i++)
                dst[i] = src.OpKind(i);
            return dst;
        }
    }
}