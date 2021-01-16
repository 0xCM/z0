//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static memory;

    [Service]
    public readonly struct TextBuffer : ITextBuffer<TextBuffer>
    {
        readonly StringBuilder Target;

        [MethodImpl(Inline)]
        public TextBuffer(StringBuilder dst)
            => Target = dst;

        [MethodImpl(Inline)]
        public string Emit(bool reset = true)
        {
            var content = Target.ToString();
            if(reset)
                Clear();
            return content;
        }

        [MethodImpl(Inline)]
        public void Clear()
            => Target.Clear();

        [MethodImpl(Inline)]
        public void Append(string src)
            => Target.Append(src);

        [MethodImpl(Inline)]
        public void AppendLine(string src)
            => Target.AppendLine(src);

        [MethodImpl(Inline)]
        public void AppendLine()
            => Target.AppendLine();

        [MethodImpl(Inline)]
        public void Append(char src)
            => Target.Append(src);

        [MethodImpl(Inline)]
        public void Append(ReadOnlySpan<char> src)
            => Target.Append(src);

        [MethodImpl(Inline)]
        public void Append(params string[] src)
            => root.iter(src, Append);

        [MethodImpl(Inline)]
        public void Append(char[] src)
            => Target.Append(src);

        public override string ToString()
            => Target.ToString();
    }
}