//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct BitDataTypeConversion
    {           
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit to<T>(T src)
            where T : unmanaged
                => Converter.Convert<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T from<T>(bit src)
            where T : unmanaged
                => Converter.Convert<T>(src);

        static BitDataTypeConverter Converter 
            => BitDataTypeConverter.Service;
    }
}