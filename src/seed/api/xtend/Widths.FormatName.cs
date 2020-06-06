//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XTend 
    {
        public static string FormatName(this TypeWidth w, bool lowercase = false)
            => w != 0 ? ( lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : string.Empty;

        public static string FormatName(this DataWidth w, bool lowercase = false)
            => w != 0 ? ( lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : string.Empty;

        public static string FormatName(this NumericWidth w, bool lowercase = false)
            => w != 0 ? ( lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : string.Empty;

        public static string FormatName(this FixedWidth w, bool lowercase = false)
            => w != 0 ? ( lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : string.Empty;

        public static string FormatName(this VectorWidth w, bool lowercase = false)
            => w != 0 ? ( lowercase ?  w.ToString().ToLowerInvariant() : w.ToString()) : string.Empty;

    }
}