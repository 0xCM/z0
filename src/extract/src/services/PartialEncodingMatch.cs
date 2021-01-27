//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    [ApiHost]
    public static class PartialEncodingMatch
    {
        [Op]
        public static bool TryPartialMatch(this EncodingPatterns patterns, EncodingPatternKind id, ReadOnlySpan<byte> input, out ReadOnlySpan<byte> selected)
        {
            var pattern = patterns.PartialPattern(id);
            var offset = patterns.MatchOffset(id);
            return TryMatch(offset, input, pattern, out selected);
        }

        [Op]
        static int? TerminalIndex(ReadOnlySpan<byte> src, ReadOnlySpan<byte?> pattern, Span<byte> state)
        {
            var pos = 0;
            var posMax = state.Length - 1;
            int? index = null;

            ref readonly var input = ref first(src);
            ref readonly var match = ref first(pattern);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var atom = ref skip(input,i);
                for(var j = pos; j<=posMax; j++)
                {
                    ref readonly var token = ref skip(match,j);
                    if(!token.HasValue || (token.HasValue && token.Value == atom))
                    {
                        seek(state,j) = atom;
                        if(j == posMax)
                            index = i;
                    }
                }

                if(index != null)
                    break;
            }

            return index;
        }

        [Op]
        static bool TryMatch(EncodingPatternOffset offset, ReadOnlySpan<byte> input, ReadOnlySpan<byte?> pattern,  out ReadOnlySpan<byte> selected)
        {
            selected = input;
            Span<byte> state = stackalloc byte[pattern.Length];
            var terminal = TerminalIndex(input,pattern,state);
            if(terminal.HasValue)
            {
                var length = (terminal.Value + 1) + (int)offset;
                selected = input.Slice(0,length);
                return true;
            }
            return false;
        }
    }
}