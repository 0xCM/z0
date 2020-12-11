//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RenderPattern : IRenderPattern
    {
        public string PatternText {get;}

        readonly Type[] _ArgTypes;

        [MethodImpl(Inline)]
        public RenderPattern(string src, Type[] types)
        {
            PatternText = src;
            _ArgTypes = types;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(PatternText);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(PatternText);
        }

        public byte ArgCount => (byte)(_ArgTypes?.Length ?? 0);

        public ReadOnlySpan<Type> ArgTypes
            => _ArgTypes;

        public string Apply(params object[] args)
            => string.Format(PatternText, args);

        public string Format()
            => PatternText;

        public override string ToString()
            => Format();

    }
}