//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    public readonly struct DynamicTextBuffer : ITextBuffer<DynamicTextBuffer>
    {
        readonly StringBuilder Target;

        [MethodImpl(Inline)]
        internal DynamicTextBuffer(StringBuilder dst)
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
            => iter(src, Append);

        [MethodImpl(Inline)]
        public void Append(char[] src)
            => Target.Append(src);

        public void AppendDelimited(char delimiter, params string[] src)
        {
            var count = src.Length;
            var terms = @readonly(src);
            var sep = string.Format("{0} ", delimiter);
            for(var i=0; i<src.Length; i++)
                string.Format("{0}{1}", sep, skip(terms,i));
        }

        [MethodImpl(Inline)]
        public void AppendFormat(string pattern, params object[] args)
            => Target.AppendFormat(pattern, args);

        public override string ToString()
            => Target.ToString();
    }
}