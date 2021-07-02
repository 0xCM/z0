//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DurationConverter
    {

        public static Option<object> ConvertFromTarget(object incoming, Type dst)
            => Option.Try(() => NumericBox.rebox(((Duration)incoming).Ticks, dst.NumericKind()));

        public static Option<object> ConvertToTarget(object incoming)
            => Option.Try(() => (Duration)(long)NumericBox.rebox(incoming, NumericKind.I64));
    }
}