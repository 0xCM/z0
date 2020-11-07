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

    /// <summary>
    /// Defines a key, predicated on input event and current state, identifies a transition rule
    /// </summary>
    public readonly struct TransitionRuleKey<E,S> : IRuleKey<E,S>
    {
        /// <summary>
        /// The triggering event
        /// </summary>
        public E Trigger {get;}

        /// <summary>
        /// The source state
        /// </summary>
        public S Source {get;}

        public int Hash {get;}

        [MethodImpl(Inline)]
        public static implicit operator TransitionRuleKey<E,S>((E trigger, S source) x)
            => new TransitionRuleKey<E,S>(x.trigger,x.source);

        [MethodImpl(Inline)]
        public TransitionRuleKey(E input, S source)
        {
            Trigger = input;
            Source = source;
            Hash = HashCode.Combine(input,source);
        }

        public override int GetHashCode()
            => Hash;

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.Tuple2, Source, Trigger);

        public override string ToString()
            => $"({Source}, {Trigger})";
    }
}