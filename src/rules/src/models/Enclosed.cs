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
        /// <summary>
        /// Defines fenced content
        /// </summary>
        public readonly struct Enclosed : IRule<Enclosed>
        {
            public Fence Fence {get;}

            public dynamic Content {get;}

            [MethodImpl(Inline)]
            public Enclosed(Fence fence, dynamic content)
            {
                Fence = fence;
                Content = content;
            }

            public string Format()
                => Fence.Format(Content);

            public override string ToString()
                => Format();
        }

        /// <summary>
        /// Defines fenced content
        /// </summary>
        public readonly struct Enclosed<T> : IRule<Enclosed<T>,T>
        {
            public DelimitedIndex<T> Content {get;}

            public Fence<T> Fence {get;}

            [MethodImpl(Inline)]
            public Enclosed(DelimitedIndex<T> content, Fence<T> fence)
            {
                Content = content;
                Fence = fence;
            }

            public string Format()
                => Fence.Format(Content);

            public override string ToString()
                => Format();
        }

        /// <summary>
        /// Defines fenced content
        /// </summary>
        public readonly struct Enclosed<C,F> : IRule<Enclosed<C,F>,C,F>
        {
            public C Content {get;}

            public Fence<F> Fence {get;}

            [MethodImpl(Inline)]
            public Enclosed(C content, Fence<F> fence)
            {
                Content = content;
                Fence = fence;
            }

            public string Format()
                => Fence.Format(Content);

            public override string ToString()
                => Format();
        }
    }
}