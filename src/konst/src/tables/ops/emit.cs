//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;
    using FW = DataFieldWidths;

    partial struct Table
    {
        public static void emit<F,T>(in TableEmission<F,T> src, FilePath dst, IRowFormatter<F> formatter, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var header = header<F>(delimiter);
            var count = src.RowCount;
            var rows = src.View;

            using var writer = dst.Writer();            
            writer.WriteLine(header.HeaderText);
            
            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));                 
        }  

        public static void emit<E>(Dictionary<string,E> src, FilePath dst)
            where E : unmanaged, Enum
        {
            var header = text.concat("Seq". PadRight((int)FW.Sequence), SpacePipe, typeof(E).Name);
            
            using var writer = dst.Writer();
            writer.WriteLine(header);
        
            var keys = src.Keys.ToArray();
            Array.Sort(keys);
            for(var i=0; i<keys.Length; i++)
                writer.WriteLine(FormatSequential(i, src[keys[i]]));
        }

        public static void emit<E>(FilePath dst)
            where E : unmanaged, Enum
        {
            var name = typeof(E).Name;
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

        static string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight((int)FW.Sequence), SpacePipe, value.ToString());                  
    }
}