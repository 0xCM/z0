//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Provies a parametric title reification predicated on a render function
    /// </summary>
    public readonly struct TitleFormatter<T> : ITitleFormatter<T>
    {
        readonly TitleRender<T> Render;

        [MethodImpl(Inline)]
        public TitleFormatter(in TitleRender<T> render)
            => Render = render;

        [MethodImpl(Inline)]
        public string FormatTitle(T src)
            => Render(src);
    }
}