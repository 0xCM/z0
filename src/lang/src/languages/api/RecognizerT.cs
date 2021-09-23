//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public readonly struct Recognizers
    {
        public static Recognizer<T> seq<T>(T[] src)
            where T : unmanaged, IEquatable<T>
                => new SeqRecognizer<T>(src);
    }

    public readonly struct Recognition
    {
        public bit Recognized {get;}

        public int Position {get;}

        [MethodImpl(Inline)]
        public Recognition(bit recognized, int pos)
        {
            Recognized = recognized;
            Position = pos;
        }

        [MethodImpl(Inline)]
        public static implicit operator Recognition((bit recognized, int pos) src)
            => new Recognition(src.recognized, src.pos);
    }

    public abstract class Recognizer<T>
        where T : unmanaged, IEquatable<T>
    {
        int Pos;

        public Recognition Eval(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            var result = bit.On;
            Pos = -1;
            for(var i = 0; i<count; i++)
            {
                Pos = i;
                ref readonly var input = ref skip(src,i);
                result &= Eval(Pos, input);
                if(!result)
                    break;
            }
            return (result,Pos);
        }

        protected abstract bit Eval(int pos, in T src);

    }

    public sealed class SeqRecognizer<T> : Recognizer<T>
        where T : unmanaged, IEquatable<T>
    {
        readonly Index<T> Match;

        [MethodImpl(Inline)]
        public SeqRecognizer(T[] match)
        {
            Match = match;
        }

        internal ReadOnlySpan<T> Terms
        {
            [MethodImpl(Inline)]
            get => Match.View;
        }

        protected override bit Eval(int pos, in T src)
            => pos < Match.Count && Match[pos].Equals(src);
    }
}