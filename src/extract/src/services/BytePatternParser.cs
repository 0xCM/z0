// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;
//     using System.Collections.Generic;

//     using Asm;

//     using static Part;
//     using static memory;

//     /// <summary>
//     /// Parses sequences of bytes, governed by patterns supplied upon initialization
//     /// </summary>
//     public ref struct BytePatternParser<T>
//         where T : unmanaged, Enum
//     {
//         readonly Span<byte> Buffer;

//         int Offset;

//         BytePatternParserState State;

//         T Outcome;

//         int Delta;

//         readonly Dictionary<byte,int> Accepted;

//         readonly IBytePatternSet<T> Patterns;

//         public byte[] Parsed
//             => ParsedSlice.ToArray();

//         ReadOnlySpan<byte> ParsedSlice
//             =>  (Offset + Delta - 1) > 0 ? Buffer.Slice(0, Offset + Delta - 1) : sys.empty<byte>();

//         internal BytePatternParser(IBytePatternSet<T> patterns, byte[] buffer)
//         {
//             Buffer = buffer;
//             Accepted = new Dictionary<byte,int>();
//             Patterns = patterns;
//             Offset = default;
//             State = default;
//             Outcome = default;
//             Delta = default;
//         }

//         public void Start()
//         {
//             Buffer.Clear();
//             Accepted.Clear();
//             Offset = default;
//             State = BytePatternParserState.Accepting;
//             Outcome = default;
//             Delta = default;
//         }

//         public BytePatternParserState Parse(Span<byte> src)
//         {
//             Start();

//             var i=0;

//             while(i < src.Length && !State.Finished())
//                 Parse(src[i++]);

//             if(State == BytePatternParserState.Accepting)
//                 State = BytePatternParserState.Unmatched;

//             return State;
//         }

//         [MethodImpl(Inline)]
//         public BytePatternParserState Parse(byte[] src)
//             => Parse(src.AsSpan());

//         public BytePatternParserState Parse(byte src)
//         {
//             if(State == BytePatternParserState.Accepting && Offset < Buffer.Length)
//             {
//                 seek(Buffer, Offset++) = src;

//                 if(Accepted.TryGetValue(src, out var count))
//                     Accepted[src] = ++ count;
//                 else
//                     Accepted[src] = 1;

//                 if(TryMatch(out Outcome, out Delta))
//                 {
//                     if(Patterns.IsSuccessPattern(Outcome))
//                         State = BytePatternParserState.Succeeded;
//                     else
//                         State = BytePatternParserState.Failed;
//                 }
//             }

//             return State;
//         }

//         public T Result
//             => State.Finished() ? Outcome : default;

//         bool TryMatch(out T mc, out int delta)
//         {
//             mc = default;
//             delta = 0;

//             ref readonly var codes = ref first(Patterns.FullPatternKinds);
//             for(var i=0; i<Patterns.FullPatternCount; i++)
//             {
//                 var match = skip(codes,i);
//                 var pattern = Patterns.FullPattern(match);
//                 var len = pattern.Length;
//                 var matched = Offset > len ? Buffer.Slice(Offset -  1 - len, len).EndsWith(pattern) : false;
//                 if(matched)
//                 {
//                     mc = match;
//                     delta = (int)Patterns.MatchOffset(match);
//                     return true;
//                 }
//             }

//             return false;
//         }
//     }
// }