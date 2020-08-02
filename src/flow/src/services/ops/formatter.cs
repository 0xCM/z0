//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Flow    
    {
        public static TableFormatter<F> formatter<F>(bool emitheader = true, F f = default)
            where F : unmanaged, Enum
        {
            var formatter = TableFormatters.create<F>();
            if(emitheader)
                formatter.EmitHeader();
            return formatter;
        }

        public static TableFormatter<F> formatter<F>(StringBuilder dst, bool emitheader, char delimiter = FieldDelimiter, F f = default)
            where F : unmanaged, Enum
        {
            var formatter = TableFormatters.create<F>(dst, delimiter);
            if(emitheader)
                formatter.EmitHeader();
            return formatter;
        }

        public static TableFormatter<F> formatter<F>(char delimiter, F f = default)
            where F : unmanaged, Enum
                => TableFormatters.create<F>(delimiter);
    }
}