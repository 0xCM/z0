//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiComplete]
    public readonly struct Interfaced : IChronic<Interfaced>, ICorrelated<Interfaced>, ITextual
    {
        public Timestamp Ts
            => root.now();

        public CorrelationToken Ct
            => CorrelationToken.Default;

        public string Format()
            => Ts.ToString();
    }
}