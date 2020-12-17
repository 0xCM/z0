//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Defines a sequence of potential choices
    /// </summary>
    public readonly struct Choices<T> : IChoices<T>
    {
        public RuleId RuleId {get;}

        public Index<T> Items {get;}

        [MethodImpl(Inline)]
        public Choices(T[] choices)
        {
            RuleId = RuleId.Empty;
            Items = choices;
        }

        [MethodImpl(Inline)]
        public Choices(RuleId rule, T[] choices)
        {
            RuleId = rule;
            Items = choices;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Items.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator Choices<T>(T[] src)
            => new Choices<T>(src);
    }
}