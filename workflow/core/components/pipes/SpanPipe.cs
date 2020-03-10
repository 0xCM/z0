//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    readonly struct SpanPipe<T> : ISpanPipe<T>
        where T : struct
    {
        readonly ValueEditor<T> Editor;
        
        [MethodImpl(Inline)]
        public SpanPipe(ValueEditor<T> editor)
            => Editor = editor;

        [MethodImpl(Inline)]
        public ref T Flow(ref T src)
            => ref Editor(ref src);
    }
}