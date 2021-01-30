//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        public readonly struct NonEmpty : IRule<NonEmpty>
        {
            readonly Index<dynamic> Terms;

            [MethodImpl(Inline)]
            public NonEmpty(Index<dynamic> terms)
            {
                root.require(terms.Count != 0, () => "At least one there must be");
                Terms = terms;
            }

            public ref dynamic First
            {
                [MethodImpl(Inline)]
                get => ref Terms.First;
            }

            public Span<dynamic> Trailing
            {
                [MethodImpl(Inline)]
                get => Terms.Slice(1);
            }

            public Span<dynamic> All
            {
                [MethodImpl(Inline)]
                get => Terms.Edit;
            }
        }

        public readonly struct NonEmpty<T> : IRule<NonEmpty<T>,T>
        {
            readonly Index<T> Terms;

            [MethodImpl(Inline)]
            public NonEmpty(Index<T> terms)
            {
                root.require(terms.Count != 0, () => "At least one there must be");
                Terms = terms;
            }

            public ref T First
            {
                [MethodImpl(Inline)]
                get => ref Terms.First;
            }

            public Span<T> Trailing
            {
                [MethodImpl(Inline)]
                get => Terms.Slice(1);
            }

            public Span<T> All
            {
                [MethodImpl(Inline)]
                get => Terms.Edit;
            }
        }
    }
}