//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ProcessContextFlags
    {
        public bit EmitSummary;

        public bit EmitDetail;

        public bit EmitDump;

        public bit IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => EmitSummary | EmitDetail | EmitDump;
        }

        public bit IsEmpty
        {
            [MethodImpl(Inline)]
            get => !IsNonEmpty;
        }

        public static ProcessContextFlags Empty
            => default;
    }
}