//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BinarySourceBlock : ISourceCode<BinarySourceBlock,byte>
    {
        public BinaryCode Code {get;}

        public BinaryRenderKind Render {get;}

        [MethodImpl(Inline)]
        public BinarySourceBlock(BinaryCode encoded, BinaryRenderKind render)
        {
            Code = encoded;
            Render = render;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Code.Edit;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Code.View;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsNonEmpty;
        }
    }
}