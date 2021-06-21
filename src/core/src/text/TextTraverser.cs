//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public ref struct TextTraverser
    {
        ReadOnlySpan<char> Source;

        int Current;

        readonly int Count;

        [MethodImpl(Inline)]
        public TextTraverser(string src)
        {
            Current = 0;
            Source = src;
            Count = Source.Length;
        }

        [MethodImpl(Inline), Op]
        public void SkipSpaces()
            => Skip(Chars.Space);

        [MethodImpl(Inline), Op]
        public void Skip(char c)
        {
            while(Current < Count && skip(Source, Current) == c)
                Advance();
        }

        [MethodImpl(Inline), Op]
        public bool Next(out char c)
        {
            SkipSpaces();
            if(Current < Count)
            {
                c = skip(Source,Current);
                Advance();
                return true;
            }
            else
            {
                c = (char)AsciChar.Null;
                return false;
            }
        }

        [MethodImpl(Inline), Op]
        public bool Peek(int n, out char c)
        {
            if(n + Current < Count)
            {
                c = skip(Source, Current + n);
                return true;
            }
            else
            {
                c = (char)AsciChar.Null;
                return false;
            }
        }

        [MethodImpl(Inline), Op]
        public void Advance(int n = 1)
        {
            Current +=n;
        }
    }
}