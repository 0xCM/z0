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
        public static Outcome apply<S,T>(SeqSub<S,T> rule, S src, out Index<T> dst)
            where S : IEquatable<S>
        {
            if(matches(rule,src))
            {
                dst = rule.Target;
                return true;
            }
            else
            {
                dst = Index<T>.Empty;
                return false;
            }
        }

        public readonly struct SeqSub<S,T> : IRule<SeqSub<S,T>>
            where S : IEquatable<S>
        {
            public S Source {get;}

            public Index<T> Target {get;}

            [MethodImpl(Inline)]
            public SeqSub(S src, Index<T> dst)
            {
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public bool Test(S src)
                => matches(this, src);

            [MethodImpl(Inline)]
            public Outcome Apply(S src, out Index<T> dst)
                => apply(this,src, out dst);
        }
    }
}