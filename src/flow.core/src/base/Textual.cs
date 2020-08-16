//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Textual<T> : ITextual
    {
        public readonly T Data;

        public readonly string Text;

        [MethodImpl(Inline)]
        public Textual(T data, string text)
        {
            Data = data;
            Text = text;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Text;        
    }
}