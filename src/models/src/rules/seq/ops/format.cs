//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines rules pertaining to sequences
    /// </summary>
    public readonly partial struct SeqRules
    {
        public static string format(in Adjacent src)
            => string.Format(RP.Adjacent2,src.A, src.B);

        public static string format<T>(in Adjacent<T> src)
            => string.Format(RP.Adjacent2,src.A, src.B);

        public static string format<T>(in ItemMatch<T> src)
            where T : IEquatable<T>
                => string.Format("match({0})", src.Value);

        public static string format<T>(in ItemMatchCount<T> src)
            where T : IEquatable<T>
                => string.Format("count({0})", src.Match);
    }
}