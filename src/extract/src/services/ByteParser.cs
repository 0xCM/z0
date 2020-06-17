//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using Asm;

    using static Konst;
    using static Memories;

    /// <summary>
    /// Parses sequences of bytes, governed by patterns supplied upon initialization 
    /// </summary>
    public ref struct ByteParser<T>
        where T : unmanaged, Enum
    {        
        readonly Span<byte> Buffer;

        int Offset;

        ByteParserState State;

        T Outcome;

        int Delta;

        readonly Dictionary<byte,int> Accepted;

        readonly IBytePatternSet<T> Patterns;
        
        public byte[] Parsed
            => ParsedSlice.ToArray();

        ReadOnlySpan<byte> ParsedSlice
            =>  (Offset + Delta - 1) > 0 
              ? Buffer.Slice(0, Offset + Delta - 1) 
              : Control.array<byte>();

        public static ByteParser<T> Create(IBytePatternSet<T> patterns, int bufferlen)
            => new ByteParser<T>(patterns, bufferlen);

        public static ByteParser<T> Create(IBytePatternSet<T> patterns, byte[] buffer)
            => new ByteParser<T>(patterns, buffer);

        ByteParser(IBytePatternSet<T> patterns, byte[] buffer)
        {
            this.Buffer = buffer;
            this.Accepted = new Dictionary<byte, int>();
            this.Patterns = patterns;
            this.Offset = default;
            this.State = default;
            this.Outcome = default;
            this.Delta = default;
        }

        ByteParser(IBytePatternSet<T> patterns, int bufferlen)
             : this(patterns,new byte[bufferlen])
        {}

        public void Start()
        {
            Buffer.Clear();
            Accepted.Clear();
            Offset = default;
            State = ByteParserState.Accepting;
            Outcome = default;
            Delta = default;
        }
        
        public ByteParserState Parse(Span<byte> src)
        {
            Start();

            var i=0;

            while(i < src.Length && !State.Finished())
                Parse(src[i++]);                
            
            if(State == ByteParserState.Accepting)
                State = ByteParserState.Unmatched;
            
            return State;
        }

        [MethodImpl(Inline)]
        public ByteParserState Parse(byte[] src)
            => Parse(src.AsSpan());        

        public ByteParserState Parse(byte src)
        {
            if(State == ByteParserState.Accepting && Offset < Buffer.Length)
            {
                refs.seek(Buffer, Offset++) = src;
                
                if(Accepted.TryGetValue(src, out var count))
                    Accepted[src] = ++ count;
                else
                    Accepted[src] = 1;
                
                if(TryMatch(out Outcome, out Delta))
                {
                    if(Patterns.IsSuccessPattern(Outcome))
                        State = ByteParserState.Succeeded;
                    else
                        State = ByteParserState.Failed;
                }
            }

            return State;
        }

        public T Result
            => State.Finished() ? Outcome : default;

        bool TryMatch(out T mc, out int delta)
        {
            mc = default;
            delta = 0;
            
            ref readonly var codes = ref head(Patterns.FullPatternKinds);
            for(var i=0; i < Patterns.FullPatternCount; i++)
            {
                var match = skip(codes,i);
                var pattern = Patterns.FullPattern(match);
                var len = pattern.Length;

                var matched = Offset > len
                    ? Buffer.Slice(Offset -  1 - len, len).EndsWith(pattern)
                    : false;                           

                if(matched)
                {
                    mc = match;
                    delta = (int)Patterns.MatchOffset(match);
                    return true;
                }                
            }
            
            return false;
        }            
    } 
}