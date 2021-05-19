//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline)]
        public static bool matches<S,T>(SeqSub<S,T> rule, S src)
            where S : IEquatable<S>
                => src.Equals(rule.Source);
    }
}