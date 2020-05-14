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
        public const int FieldWidthOffset = 32;

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