//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Provies a parametric title reification predicated on a render function
    /// </summary>
    readonly struct TitleFormatter<T> : ITitleFormatter<T>
    {
        readonly TitleRender<T> Render;

        [MethodImpl(Inline)]
        public TitleFormatter(TitleRender<T> render)
            => Render = render;

        [MethodImpl(Inline)]
        public TitleFormatter(ITitleFormatter<T> entitled)
            => Render = x => entitled.FormatTitle(x);

        [MethodImpl(Inline)]
        public string FormatTitle(T src)
            => Render(src);
    }
}