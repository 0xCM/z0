//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Specifies that the occurence of an element is distinguished by membership in a specified set
    /// </summary>
    public readonly struct OneOf : ITerm
    {
        public Index<dynamic> Terms {get;}

        [MethodImpl(Inline)]
        public OneOf(Index<dynamic> choices)
            => Terms = choices;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Terms.Count;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}