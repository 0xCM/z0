//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct DurationConverter
    {
        [MethodImpl(Inline)]
        public T Convert<T>(Duration src)
            => Numeric.force<T>(src.Ticks);

        [MethodImpl(Inline)]
        public Duration Convert<T>(T src)
            => Numeric.force<T,long>(src);

        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => Option.Try(() => Numeric.rebox(((Duration)incoming).Ticks, dst.NumericKind()));

        public Option<object> ConvertToTarget(object incoming)
            => Option.Try(() => (Duration)(long)Numeric.rebox(incoming, NumericKind.I64));
    }
}