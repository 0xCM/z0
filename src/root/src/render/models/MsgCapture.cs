//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MsgCapture : ITextual
    {
        [MethodImpl(Inline)]
        public static MsgCapture close<T>(T src, params object[] args)
            where T : IMsgPattern
                => new MsgCapture(src, args);

        readonly IMsgPattern Pattern;

        readonly object[] Args;

        [MethodImpl(Inline)]
        internal MsgCapture(IMsgPattern pattern, object[] args)
        {
            Pattern = pattern;
            Args = args;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(Pattern.PatternText, Args);

        public override string ToString()
            => Format();

        public static implicit operator string(MsgCapture src)
            => src.Format();
    }
}