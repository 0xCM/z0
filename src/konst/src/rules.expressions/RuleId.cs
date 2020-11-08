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

    public readonly struct RuleId
    {
        public string Identifier {get;}

        [MethodImpl(Inline)]
        public RuleId(string id)
        {
            Identifier = id;
        }

        [MethodImpl(Inline)]
        public static implicit operator RuleId(string src)
            => new RuleId(src);
    }
}