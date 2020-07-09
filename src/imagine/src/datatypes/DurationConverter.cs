//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    readonly struct DurationConverter : IConversionProvider<Duration>, IBiconverter<Duration>
    {
        public IBiconverter<Duration> Converter 
            => this;

        [MethodImpl(Inline)]
        public T Convert<T>(Duration src)
            => Cast.to<T>(src.Ticks);

        [MethodImpl(Inline)]
        public Duration Convert<T>(T src)
            => Cast.to<T,long>(src);

        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => Option.Try(() => core.rebox(((Duration)incoming).Ticks, dst.NumericKind()));

        public Option<object> ConvertToTarget(object incoming)
            => Option.Try(() => (Duration)(long)core.rebox(incoming, NumericKind.I64));
    }
}