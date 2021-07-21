//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
    }
}