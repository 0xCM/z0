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

        string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight(SeqPad), SpacePipe, value.ToString());

        public void PublishLists()
        {
            PublishList(LL.Codes, nameof(LL.Codes));
            PublishList(LL.MemorySizes, nameof(LL.MemorySizes));
            PublishList(LL.Mnemonics, nameof(LL.Mnemonics));
            PublishList(LL.Registers, nameof(LL.Registers));
        }

    }
}