//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    partial class XWidth
    {
        [Op]
        public static string FormatName(this TypeWidth w, bool lowercase = false)
            => w != 0 ? (lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : EmptyString;

        [Op]
        public static string FormatName(this DataWidth w, bool lowercase = false)
            => w != 0 ? (lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : EmptyString;

        [Op]
        public static string FormatName(this NumericWidth w, bool lowercase = false)
            => w != 0 ? (lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : EmptyString;

        [Op]
        public static string FormatName(this CellWidth w, bool lowercase = false)
            => w != 0 ? (lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : EmptyString;

        [Op]
        public static string FormatName(this VectorWidth w, bool lowercase = false)
            => w != 0 ? (lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : EmptyString;
    }
}