//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Strings;

    using static Root;
    using static core;

    partial struct strings
    {
        [Op]
        public static string format(in ConstWord src)
            => new string(src.View);

        public static string format<S>(in ConstWord<S> src)
            where S : unmanaged
                => new string(core.recover<S,char>(src.View));

        [Op]
        public static string format(in EmbeddedWord src)
            => new string(src.View);

        public static string format<S>(in EmbeddedWord<S> src)
            where S : unmanaged
                => new string(core.recover<S,char>(src.View));

        [Op]
        public static string format(in Word src)
            => new string(src.View);

        public static string format<S>(in Word<S> src)
            where S : unmanaged
                => new string(core.recover<S,char>(src.View));

        [MethodImpl(Inline), Op]
        public static unsafe string format(StringAddress src)
            => new string(src.Address.Pointer<char>());

        [MethodImpl(Inline), Op]
        public static unsafe string format<N>(StringAddress<N> src)
            where N : unmanaged, ITypeNat
                => new string(src.Address.Pointer<char>());
    }
}