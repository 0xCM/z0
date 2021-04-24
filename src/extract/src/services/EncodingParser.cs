//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using K = EncodingPatternKind;
    using S = EncodingParserState;

    using static Part;
    using static memory;

    public ref struct EncodingParser
    {
        readonly Span<byte> Buffer;

        int Offset;

        S State;

        K Outcome;

        int Delta;

        //readonly Dictionary<byte,int> Accepted;

        readonly EncodingPatterns Patterns;

        public byte[] Parsed
            => ParsedSlice.ToArray();

        ReadOnlySpan<byte> ParsedSlice
            =>  (Offset + Delta - 1) > 0 ? Buffer.Slice(0, Offset + Delta - 1) : sys.empty<byte>();

        internal EncodingParser(EncodingPatterns patterns, byte[] buffer)
        {
            Buffer = buffer;
            Patterns = patterns;
            Offset = default;
            State = default;
            Outcome = default;
            Delta = default;
        }

        public void Start()
        {
            Buffer.Clear();
            Offset = default;
            State = S.Accepting;
            Outcome = default;
            Delta = default;
        }

        public S Parse(ReadOnlySpan<byte> src)
        {
            Start();

            var i=0;

            while(i < src.Length && !State.Finished())
                Parse(src[i++]);

            if(State == S.Accepting)
                State = S.Unmatched;

            return State;
        }

        public S Parse(byte src)
        {
            if(State == S.Accepting && Offset < Buffer.Length)
            {
                seek(Buffer, Offset++) = src;

                if(TryMatch(out Outcome, out Delta))
                {
                    if(Patterns.IsSuccessPattern(Outcome))
                        State = S.Succeeded;
                    else
                        State = S.Failed;
                }
            }

            return State;
        }

        public K Result
        {
            [MethodImpl(Inline)]
            get => State.Finished() ? Outcome : default;
        }

        bool TryMatch(out K kind, out int delta)
        {
            kind = default;
            delta = 0;

            ref readonly var codes = ref first(Patterns.Kinds);
            for(var i=0; i<Patterns.PatternCount; i++)
            {
                var match = skip(codes,i);
                var pattern = Patterns.Pattern(match);
                var len = pattern.Length;
                var matched = Offset > len ? Buffer.Slice(Offset -  1 - len, len).EndsWith(pattern) : false;
                if(matched)
                {
                    kind = match;
                    delta = (int)Patterns.MatchOffset(match);
                    return true;
                }
            }

            return false;
        }
    }
}