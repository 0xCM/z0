//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Time;

    readonly struct DurationConverter : IConversionProvider<Duration>, IBiconverter<Duration>
    {
        // [MethodImpl(Inline)]
        // public T Convert<T>(Duration src) 
        //     where T : unmanaged
        //         => Cast.convert<T>(src.Ticks);

        // [MethodImpl(Inline)]
        // public Duration Convert<T>(T src) 
        //     where T : unmanaged
        //         => convert<T,long>(src);

        // [MethodImpl(Inline)]
        // public Option<object> ConvertFromTarget(object incoming, Type dst)
        //     => FromTarget(incoming,dst);

        // [MethodImpl(Inline)]
        // public Option<object> ConvertToTarget(object incoming)
        //     => ToTarget(incoming);

        // static Option<object> FromTarget(object incoming, Type dst)
        //     => Option.Try(() => Cast.ocast(((Duration)incoming).Ticks, dst.NumericKind()));

        // static Option<object> ToTarget(object incoming)
        //     => Option.Try(() => (Duration)(long)Cast.ocast(incoming, NumericKind.I64));
        public IBiconverter<Duration> Converter 
            => this;

        public T Convert<T>(Duration incoming)
        {
            throw new NotImplementedException();
        }

        public Duration Convert<T>(T incoming)
        {
            throw new NotImplementedException();
        }

        public Option<object> ConvertFromTarget(object incoming, Type dst)
        {
            throw new NotImplementedException();
        }

        public Option<object> ConvertToTarget(object incoming)
        {
            throw new NotImplementedException();
        }
    }
}