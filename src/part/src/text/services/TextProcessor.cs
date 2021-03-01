//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TextProcessor<T> : ITextProcessor<T>
    {
        readonly ParseFunction<T> ParseFx;

        readonly RenderFunction<T> RenderFx;

        [MethodImpl(Inline)]
        public TextProcessor(ParseFunction<T> parseFx, RenderFunction<T> renderFx)
        {
            ParseFx = parseFx;
            RenderFx = renderFx;
        }

        [MethodImpl(Inline)]
        public Outcome Parse(string src, out T dst)
            => ParseFx(src, out dst);

        [MethodImpl(Inline)]
        public void Render(in T src, ITextBuffer dst)
            => RenderFx(src,dst);

        public string Format(in T src)
        {
            var dst = text.buffer();
            Render(src,dst);
            return dst.Emit();
        }
    }
}