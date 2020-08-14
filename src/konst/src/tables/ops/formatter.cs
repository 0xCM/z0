//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using Z0.Data;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>(in LiteralFields<F> fields, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new Z0.TableFormatter<F>(text.build(), delimiter, fields);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter = FieldDelimiter) 
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(), delimiter);        

        /// <summary>
        /// Creates a formatter from a rendering function render:C -> T
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to format</typeparam>
        [MethodImpl(Inline)]
        public static CellFormatter<C,T> formatter<C,T>(CellFormatter.RenderFunction<C,T> render)
            where C : struct
                => new CellFormatter<C,T>(render);

        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>()
            where F : unmanaged, Enum
                => new Z0.TableFormatter<F>(text.build(), FieldDelimiter);


        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>(in LiteralFields<F> fields, StringBuilder dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new Z0.TableFormatter<F>(dst, delimiter, fields);

        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>(StringBuilder dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new Z0.TableFormatter<F>(dst, delimiter);

        [MethodImpl(Inline)]
        public static Z0.TableFormatter<F> formatter<F>(StringBuilder dst, bool emitheader, char delimiter = FieldDelimiter, F f = default)
            where F : unmanaged, Enum
        {
            var formatter = new Z0.TableFormatter<F>(dst, delimiter);
            if(emitheader)
                formatter.EmitHeader();
            return formatter;
        }

        [MethodImpl(Inline)]
        public static TableFormatter<F,T> formatter<F,T>(LiteralFields<F> fields, StringBuilder dst = null)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
                => new TableFormatter<F,T>(fields, dst);
    }
}