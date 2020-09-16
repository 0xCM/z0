//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct RenderPatternSource : ITextual
    {
        readonly FieldInfo Field;

        readonly StringRef Content;

        [MethodImpl(Inline)]
        public RenderPatternSource(FieldInfo src, string content)
        {
            Field = src;
            Content = content;
        }

        public string Format()
            => StringRefs.format("{0} | {1}", Field.Name, Content);
    }
}