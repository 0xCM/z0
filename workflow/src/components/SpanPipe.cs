//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

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