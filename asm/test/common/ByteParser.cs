//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static PatternMatchCode;

    public enum ByteParserState
    {
        None = 0,
        
        Accepting = 1,
        
        Failed = 2,
        
        Succeeded = 4,

        Completed = Failed | Succeeded

    }

    public enum PatternMatchCode : byte
    {
        None = 0,

        CTC_RET_SBB,
        
        CTC_RET_INTR,

        CTC_RET_ZED_SBB,
        
        CTC_RET_Zx3,

        CTC_RET_Zx7,

        CTC_INTRx2,

        CTC_Zx7,

        CTC_JMP_RAX,
        
        CTC_BUFFER_OUT
    }

    public static class BytParserX
    {
        public static bool Finished(this ByteParserState state)
            => (state & ByteParserState.Completed) != 0;

        public static bool IsAccepting(this ByteParserState state)
            => state == ByteParserState.Accepting;

        public static bool IsSome(this ByteParserState state)
            => state != ByteParserState.None;
    }

    public static class ByteParser
    {
        public static ByteParser<PatternMatchCode> Create(int size)
            => ByteParser<PatternMatchCode>.Create(size);
    }

    public ref struct ByteParser<T>
        where T : unmanaged, Enum
    {
        readonly Span<byte> Parsed;

        int Offset;

        ByteParserState State;

        T Outcome;

        public static ByteParser<T> Create(int size)
            => new ByteParser<T>(size);

        ByteParser(int size)
        {
            this.Parsed = new byte[size];
            this.Offset = 0;
            this.State = 0;
            this.Outcome = default;
        }

        public void Start()
        {
            Parsed.Clear();
            Offset = 0;
            State = ByteParserState.Accepting;
        }
        
        [MethodImpl(Inline)]
        PatternMatchCode Parse()
        {
            ref readonly var code = ref head(MatchCodes);
            for(var i=0; i<MatchCodes.Length; i++)
            {
                var match = (PatternMatchCode)skip(code,i);
                var pattern = GetPattern(match);
                var len = pattern.Length;

                var matched = 
                    Offset > len
                    ? Parsed.Slice(Offset - len - 1, len).EndsWith(pattern)
                    : false;                           
                    
                if(matched)
                    return match;
            }
            return default;
        }

        public ByteParserState Parse(byte[] src)
        {
            Start();

            var i=0;

            while(i < src.Length && !State.Finished())
                Parse(src[i++]);                
            
            return State;
        }

        public ByteParserState Parse(byte src)
        {
            if(State == ByteParserState.Accepting && Offset < Parsed.Length)
            {
                seek(Parsed, Offset++) = src;
                var code = Parse();
                if(code.IsSome())
                {
                    Outcome = Unsafe.As<PatternMatchCode, T>(ref code);
                    State = ByteParserState.Succeeded;
                }                
            }

            return State;
        }

        public T? Result
        {
            get
            {
                if(State.Finished())
                    return Outcome;
                else
                    return null;
            }                
        }

        const byte ZED = 0;
        
        const byte RET = 0xc3;
        
        const byte INTR = 0xcc;
        
        const byte SBB = 0x19;
        
        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;

        static ReadOnlySpan<byte> RET_SBB 
            => new byte[]{RET,SBB};

        static ReadOnlySpan<byte> RET_INT 
            => new byte[]{RET,INTR};

        static ReadOnlySpan<byte> RET_ZED_SBB
            => new byte[]{RET,ZED,SBB};

        static ReadOnlySpan<byte> RET_Zx2
            => new byte[]{RET,ZED,ZED};

        static ReadOnlySpan<byte> INTRx2
            => new byte[]{INTR,INTR};

        static ReadOnlySpan<byte> JMP_RAX
            => new byte[]{ZED,ZED,J48,FF,E0};

        static ReadOnlySpan<byte> Z7
            => new byte[]{ZED,ZED,ZED,ZED,ZED,ZED,ZED};

        static ReadOnlySpan<byte> Empty
            => new byte[]{};

        static ReadOnlySpan<byte> MatchCodes
            => new byte[]{
                (byte)CTC_RET_SBB,
                (byte)CTC_RET_INTR,
                (byte)CTC_RET_ZED_SBB,
                (byte)CTC_RET_Zx3,
                (byte)CTC_INTRx2,
                (byte)CTC_JMP_RAX,
                (byte)CTC_Zx7
            };

        static ReadOnlySpan<byte> GetPattern(PatternMatchCode code)
            => code switch{
                CTC_RET_SBB => RET_SBB,
                CTC_RET_INTR => RET_INT,
                CTC_RET_ZED_SBB =>  RET_ZED_SBB,              
                CTC_RET_Zx3 => RET_Zx2,
                CTC_INTRx2 => INTRx2,
                CTC_JMP_RAX => JMP_RAX,
                CTC_Zx7 => Z7,
                _ => Empty
            };

    }
}