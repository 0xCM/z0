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
        public readonly struct Fenced : IRule<Fenced>
        {
            public Fence Fence {get;}

            public dynamic Content {get;}

            [MethodImpl(Inline)]
            public Fenced(Fence fence, dynamic content)
            {
                Fence = fence;
                Content = content;
            }
        }

        /// <summary>
        /// Defines fenced content
        /// </summary>
        public readonly struct Fenced<T> : IRule<Fenced<T>,T>
        {
            public Index<T> Content {get;}

            public Fence<T> Fence {get;}

            [MethodImpl(Inline)]
            public Fenced(Index<T> content, Fence<T> fence)
            {
                Content = content;
                Fence = fence;
            }
        }

        /// <summary>
        /// Defines fenced content
        /// </summary>
        public readonly struct Fenced<C,F> : IRule<Fenced<C,F>,C,F>
        {
            public C Content {get;}

            public Fence<F> Fence {get;}

            [MethodImpl(Inline)]
            public Fenced(C content, Fence<F> fence)
            {
                Content = content;
                Fence = fence;
            }
        }
    }
}