//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public unsafe struct LabelEditor
    {
        Labels Source;

        [MethodImpl(Inline)]
        internal LabelEditor(Labels src)
        {
            Source = src;
        }

        public Span<char> Buffer
        {
            [MethodImpl(Inline)]
            get => cover(Source.BaseAddress.Pointer<char>(), Source.Size/2);
        }
    }
}