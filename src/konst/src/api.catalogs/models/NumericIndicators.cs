//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using A = data.tchars;
    using C = AsciChar;
    using NI = NumericIndicator;
    using NK = NumericKinds;

    using static Part;
    using static LimitValues;

    [LiteralProvider]
    public readonly struct NumericIndicators
    {
        [MethodImpl(Inline), Op]
        public static NumericIndicator from(Type t)
        {
            if(t == typeof(Bit32))
                return NI.Unsigned;
            else
                return NK.indicator(Numeric.kind(t));
        }

        [Indicator(C.i)]
        public const string i = A.i;

        [Indicator(C.u)]
        public const string u = A.u;

        [Indicator(C.f)]
        public const string f = A.f;

        [Indicator(t8u, Min8u, Max8u)]
        public const string t8u = "8" + u;

        [Indicator(t8i, Min8i, Max8i)]
        public const string t8i = "8" + i;

        [Indicator(t16u, Min16u, Max16u)]
        public const string t16u = "16" + u;

        [Indicator(t16i, Min16i, Max16i)]
        public const string t16i = "16" + i;

        [Indicator(t32u, Min32u, Max32u)]
        public const string t32u = "32" + u;

        [Indicator(t32i, Min32i, Max32i)]
        public const string t32i = "32" + i;

        [Indicator(t64u, Min64u, Max64u)]
        public const string t64u = "64" + u;

        [Indicator(t64i, Min64i, Max64i)]
        public const string t64i = "64" + i;

        [Indicator(t64i, Min32f, Max32f)]
        public const string t32f = "32" + f;

        [Indicator(t64f, Min64f, Max64f)]
        public const string t64f = "64" + f;
    }
}