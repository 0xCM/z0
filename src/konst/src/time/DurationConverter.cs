//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static z;

    public readonly struct DurationConverter : IConversionProvider<Duration>, IBiconverter<Duration>
    {
        public IBiconverter<Duration> Converter
            => this;

        [MethodImpl(Inline)]
        public T Convert<T>(Duration src)
            => force<T>(src.Ticks);

        [MethodImpl(Inline)]
        public Duration Convert<T>(T src)
            => force<T,long>(src);

        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => Option.Try(() => NumericBox.rebox(((Duration)incoming).Ticks, dst.NumericKind()));

        public Option<object> ConvertToTarget(object incoming)
            => Option.Try(() => (Duration)(long)NumericBox.rebox(incoming, NumericKind.I64));
    }
}