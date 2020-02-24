//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    
    using static zfunc;

    public ref struct ByteParser<T>
        where T : unmanaged, Enum
    {
        public IRngContext Context {get;}
        
        readonly Span<byte> Buffer;

        int Offset;

        ByteParserState State;

        T Outcome;

        int Delta;

        readonly Dictionary<byte,int> Accepted;

        readonly IBytePatternSet<T> Patterns;
        
        public ReadOnlySpan<byte> Parsed
            =>  (Offset + Delta - 1) > 0 ? Buffer.Slice(0, Offset + Delta - 1) : new byte[]{};

        public static ByteParser<T> Create(IRngContext context, int size, IBytePatternSet<T> patterns)
            => new ByteParser<T>(context,size,patterns);

        ByteParser(IRngContext context, int size, IBytePatternSet<T> patterns)
        {
            this.Context = context;
            this.Buffer = new byte[size];
            this.Accepted = new Dictionary<byte, int>();
            this.Patterns = patterns;
            this.Offset = default;
            this.State = default;
            this.Outcome = default;
            this.Delta = default;
        }

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
                seek(Buffer, Offset++) = src;
                
                if(Accepted.TryGetValue(src, out var count))
                    Accepted[src] = ++ count;
                else
                    Accepted[src] = 1;
                
                if(TryMatch(out Outcome, out Delta))
                    State = ByteParserState.Succeeded;
            }

            return State;
        }

        public T Result
            => State.Finished() ? Outcome : default;

        bool TryMatch(out T mc, out int delta)
        {
            mc = default;
            delta = 0;
            
            ref readonly var codes = ref head(Patterns.PatternKinds);
            for(var i=0; i < Patterns.PatternCount; i++)
            {
                var match = skip(codes,i);
                var pattern = Patterns.Pattern(match);
                var len = pattern.Length;

                var matched = 
                    Offset > len
                    ? Buffer.Slice(Offset -  1 - len, len).EndsWith(pattern)
                    : false;                           

                if(matched)
                {
                    mc = match;
                    delta = Patterns.PatternValue(match);
                    return true;
                }
                
            }
            return false;
        }            
    } 
}