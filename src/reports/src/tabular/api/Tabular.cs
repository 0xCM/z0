//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class Tabular
    {
        /// <summary>
        /// Defines a tabular format specifiecation predicated on a parametric enum type
        /// </summary>
        /// <typeparam name="F">The field specifier</typeparam>
        public static TabularFormat<F> format<F>()
            where F : unmanaged, Enum
        {
            var specs = Enums.valarray<F>();
            var dst = new TabularField<F>[specs.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = new TabularField<F>(specs[i]);
            return new TabularFormat<F>(dst);            
        }

        /// <summary>
        /// Defines a tabular field specification predicated on an enumeration literal
        /// </summary>
        /// <param name="field"></param>
        /// <typeparam name="F"></typeparam>
        [MethodImpl(Inline)]
        public static TabularField<F> field<F>(F field)
            where F : unmanaged, Enum
                => new TabularField<F>(field);        

        /// <summary>
        /// Defines the bit position where the field width specification begins
        /// </summary>
        public const int WidthOffset = 32;

        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        public const ushort PosMask = 0xFFFF;

        [MethodImpl(Inline)]
        public static F[] fields<F>()
            where F : unmanaged, Enum
                => Enums.valarray<F>();

        [MethodImpl(Inline)]
        public static string[] headers<F>()
            where F : unmanaged, Enum
                => fields<F>().Select(f => f.ToString());

        [MethodImpl(Inline)]
        public static string header<F>(char delimiter)
            where F : unmanaged, Enum
        {
            var service = formatter<F>();
            var cols = fields<F>();
            var labels = headers<F>();
            for(var i=0; i<cols.Length; i++)
                service.DelimitField(cols[i], labels[i], delimiter);
            return service.Format();
        }

        [MethodImpl(Inline)]
        public static Tabular<F,R> define<F,R>(R src)
            where F : unmanaged, Enum
            where R : ITabular
                => new Tabular<F,R>(src);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>() 
            where F : unmanaged, Enum
                => FieldFormatter<F>.Service.Reset();
    }

}