//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;
    using static AsmDataModels;

    using LL = Asm.Data.LiteralLookups;
    using R = RecordFields;
    using RW = RecordFieldWidths;

    partial class AsmEtl
    {       
        const int SeqPad = 8;
        
        const string SpacePipe = " | ";

        public void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum
        {
            var dst = Config.DatasetPath(name);            
            var header = text.concat("Seq". PadRight(SeqPad), SpacePipe,  typeof(E).Name);
            
            using var writer = dst.Writer();
            writer.WriteLine(header);
        
            var keys = src.Keys.ToArray();
            Array.Sort(keys);
            for(var i=0; i<keys.Length; i++)
                writer.WriteLine(FormatSequential(i, src[keys[i]]));
        }

        public void PublishList<E>()
            where E : unmanaged, Enum
        {
            var name = typeof(E).Name;
            var dst = Config.DatasetPath(name);
            var header = text.concat("Sequence". PadRight((int)RW.Sequence), SpacePipe, typeof(E).Name);
            var literals = Enums.literals<E>();

            using var writer = dst.Writer();
            writer.WriteLine(header);

            for(var i=0; i<literals.Length; i++)
            {
                var literal = literals[i];
                writer.WriteLine(FormatSequential(literal.Index, literal.Value));
            }
        }

        void Save<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IAsmDataModel
            where R : IRecord
            where F : unmanaged, Enum
        {
            var dst = Config.DatasetPath(model.Name);
            var header = Records.Header<F>(delimiter);
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(src[i].DelimitedText(delimiter));                
        }

        public OperandCountRecord[] Publish(OperandCounts model)
        {
            var counts = InstructionOpCounts.OpCount;
            var codes = Enums.literals<OpCodeId>();
            insist(counts.Length, codes.Length);
    
            var dst = Control.alloc<OperandCountRecord>(counts.Length);
            for(var i=0; i < counts.Length; i++)
            {
                var code = codes[i];
                insist(code.Index, i);

                dst[i] = new OperandCountRecord(i, counts[i], code.Value);
            }

            Save(model, OperandCountField.Sequence, dst, Chars.Pipe);
            //Save(model,dst, Chars.Pipe);
            return dst;
        }

        string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight((int)RW.Sequence), SpacePipe, value.ToString());

        public void PublishLists()
        {
            PublishList<Mnemonic>();
            Publish(OperandCounts.Model);
            PublishList(LL.Codes, nameof(LL.Codes));
            PublishList(LL.MemorySizes, nameof(LL.MemorySizes));
            PublishList(LL.Registers, nameof(LL.Registers));
        }
    }
}