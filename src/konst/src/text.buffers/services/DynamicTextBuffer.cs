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
        public void Write(string src)
            => Target.Append(src);

        public override string ToString()
            => Emit();

        [MethodImpl(Inline)]
        public string Format()
            => Emit();
    }
}