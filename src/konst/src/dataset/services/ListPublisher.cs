//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;   

    using FW = DataFieldWidths;
    
    public readonly struct ListPublisher : IListPublisher
    {        
        IDatasets Archive => Table.Service;
   
        const string SpacePipe = " | ";

        public void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum
        {
            var dst = Archive.DatasetPath(name);            
            var header = text.concat("Seq". PadRight((int)FW.Sequence), SpacePipe, typeof(E).Name);
            
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
            var dst = Archive.DatasetPath(name);
            var header = text.concat("Sequence". PadRight((int)FW.Sequence), SpacePipe, typeof(E).Name);
            var literals = Enums.index<E>();

            using var writer = dst.Writer();
            writer.WriteLine(header);

            for(var i=0; i<literals.Length; i++)
            {
                var literal = literals[i];
                writer.WriteLine(FormatSequential((int)literal.Position, literal.LiteralValue));
            }
        }

        string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight((int)FW.Sequence), SpacePipe, value.ToString());
    }
}