//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;


    public static class PartialEncodingMatch
    {
        public static int? TerminalIndex(ReadOnlySpan<byte> src, ReadOnlySpan<byte?> pattern, Span<byte> state)
        {            
            var pos = 0;
            var posMax = state.Length - 1;
            int? termidx = null;

            ref readonly var input = ref head(src);
            ref readonly var match = ref head(pattern);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var atom = ref skip(input,i);
                for(var j = pos; j<=posMax; j++)
                {
                    ref readonly var token = ref skip(match,j);
                    if(!token.HasValue || (token.HasValue && token.Value == atom))
                    {
                        refs.seek(state,j) = atom;
                        if(j == posMax)
                            termidx = i;
                    }
                }

                if(termidx != null)
                    break;
            }
        
            return termidx;
        }


        public static bool TryMatch(EncodingPatternOffset offset, ReadOnlySpan<byte> input, ReadOnlySpan<byte?> pattern,  out ReadOnlySpan<byte> selected)
        {
            selected = input;
            Span<byte> state = stackalloc byte[pattern.Length];
            var terminal = PartialEncodingMatch.TerminalIndex(input,pattern,state);
            if(terminal.HasValue)
            {
                var length = (terminal.Value + 1) + (int)offset;
                selected = input.Slice(0,length);
                return true;
            }
            return false;
        }

        public static bool TryPartialMatch(this EncodingPatterns patterns, EncodingPatternKind id, ReadOnlySpan<byte> input, out ReadOnlySpan<byte> selected)
        {
            var pattern = patterns.PartialPattern(id);
            var offset = patterns.MatchOffset(id);
            return TryMatch(offset, input, pattern, out selected);
        }
    }
}