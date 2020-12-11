//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Part
    {
       public static NotSupportedException no<T>()
            => new NotSupportedException($"The type {typeof(T).Name} is not supported");

        [Op, Closures(UnsignedInts)]
        public static ArgumentException badarg<T>(T arg)
            => new ArgumentException(arg?.ToString() ?? "<null>");

        [MethodImpl(Inline), Op]
        public static void ThrowEmptySpanError()
            => sys.@throw($"The span, it is empty");
    }
}