//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;   
    using static Memories;

    using RW = AsmFieldWidths;
    using static AsmDataModels;

    public interface IListPublisher
    {
        void Publish();
    }
    public readonly struct ListPublisher : IListPublisher, IAsmArchiveConfig
    {
        public static IListPublisher Service => default(ListPublisher);
        
        IAsmArchiveConfig Config => this;        

        public void Publish()
        {


        }

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
            var header = AsmRecords.Header<F>(delimiter);
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(src[i].DelimitedText(delimiter));                
        }


        string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight((int)RW.Sequence), SpacePipe, value.ToString());


        public void Publish(OperandCounts model, OperandCountRecord[] src)
        {
            Save(model, OperandCountField.Sequence, src, Chars.Pipe);

        }
    }
}