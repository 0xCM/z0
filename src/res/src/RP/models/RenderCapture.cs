//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    public readonly struct RenderCapture
    {
        readonly IRenderPattern Pattern;

        readonly object[] Args;

        [MethodImpl(Inline)]
        internal RenderCapture(IRenderPattern pattern, object[] args)
        {
            Pattern = pattern;
            Args = args;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(Pattern.PatternText, Args);

        public override string ToString()
            => Format();

        public static implicit operator string(RenderCapture src)
            => src.Format();
    }
}