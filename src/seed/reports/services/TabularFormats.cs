//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    public readonly struct TabularFormats
    {    
        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static TabularFormat<F> derive<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var literals = @readonly(RecordFields.Service.Literals<F>());
            var count = literals.Length;
            var headBuffer = alloc<string>(count);
            var fieldBuffer = alloc<TabularField<F>>(count);            
            var fields = span(fieldBuffer);

            for(var i=0; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);                
                seek(fields,i) = new TabularField<F>(literal, literal.ToString(), i, (short)(e32u(literal) >> WidthOffset));                
            }
            
            return new TabularFormat<F>(fieldBuffer);
        }

        [MethodImpl(Inline)]
        public static string[] headers<F>()
            where F : unmanaged, Enum
                => RecordFields.Service.Labels<F>();        
    }
}