//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    [ApiHost]
    public static class BitConversions
    {   
        static BitDataTypeConverter Converter => BitDataTypeConverter.Service;
        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit to<T>(T src)
            where T : unmanaged
                => Converter.Convert<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T from<T>(bit src)
            where T : unmanaged
                => Converter.Convert<T>(src);
    }

    public static class SignOps
    {
    }
}