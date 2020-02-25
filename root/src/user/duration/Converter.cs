//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    readonly struct DurationConverter : IUnmanagedConverter<DurationConverter,Duration>
    {
        [MethodImpl(Inline)]
        public T Convert<T>(Duration src) 
            where T : unmanaged
                => convert<T>(src.Ticks);

        [MethodImpl(Inline)]
        public Duration Convert<T>(T src) 
            where T : unmanaged
                => convert<T,long>(src);

        [MethodImpl(Inline)]
        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => FromTarget(incoming,dst);

        [MethodImpl(Inline)]
        public Option<object> ConvertToTarget(object incoming)
            => ToTarget(incoming);

        static Option<object> FromTarget(object incoming, Type dst)
            => Try(() => Converter.oconvert(((Duration)incoming).Ticks, dst.NumericKind()));

        static Option<object> ToTarget(object incoming)
            => Try(() => (Duration)(long)Converter.oconvert(incoming, NumericKind.I64));
    }
}