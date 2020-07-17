//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static ClrEnum @enum(Type src)
            => src.IsEnum ? new ClrEnum(src) : new ClrEnum(EmptyVessels.EmptyEnum);

        [MethodImpl(Inline)]
        public static ClrEnum<T> @enum<T>()
            where T : unmanaged, Enum
                => new ClrEnum<T>(typeof(T));

    }
}