//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>()
            where F : unmanaged, Enum
                => new Z0.TableFormatter<F>(text.build(), FieldDelimiter);

        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>(StringBuilder dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new Z0.TableFormatter<F>(dst, delimiter);

        public static Z0.TableFormatter<F> formatter<F>(StringBuilder dst, bool emitheader, char delimiter = FieldDelimiter, F f = default)
            where F : unmanaged, Enum
        {
            var formatter = new Z0.TableFormatter<F>(dst, delimiter);
            if(emitheader)
                formatter.EmitHeader();
            return formatter;
        }

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(LiteralFields<F> fields, StringBuilder dst = null)
            where F : unmanaged, Enum
                => new TableFormatter<F>(fields, dst);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter = FieldDelimiter) 
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(), delimiter);        
    }
}