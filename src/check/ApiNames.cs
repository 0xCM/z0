//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static ApiNameAtoms;

    readonly struct ApiNames
    {
        const string check = nameof(check);

        const string outcomes = nameof(outcomes);

        public const string CheckOutcomes = check + dot + outcomes;
    }
}