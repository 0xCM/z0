//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BinarySourceBlock : ISourceCode<BinarySourceBlock>
    {
        public BinaryCode Encoded {get;}

        public BinaryRenderKind Render {get;}

        [MethodImpl(Inline)]
        public BinarySourceBlock(BinaryCode encoded, BinaryRenderKind render)
        {
            Encoded = encoded;
            Render = render;
        }

        public ReadOnlySpan<TextLine> Lines
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}