//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static XedSourceMarkers;

    partial struct XedWfOps
    {

        [Op]
        public static void map(ReadOnlySpan<XedPattern> src, Span<XedInstructionRow> dst)
        {
            var count = src.Length;
            ref readonly var input = ref first(src);
            ref var output = ref first(dst);
            for(var i=0u; i<count; i++)
            {
                ref readonly var x = ref skip(input,i);
                seek(output, i) = new XedInstructionRow(
                    seq: (int)i,
                    mnemonic: x.Class,
                    ext: x.Extension,
                    @base: BaseCodeText(x),
                    mod: default,
                    reg: default);
            }
        }

        public static ref XedPattern map(in XedInstructionDoc src, int index, ref XedPattern dst)
        {
            dst.Class = src.Class ?? string.Empty;
            dst.Category = src.Category ?? string.Empty;
            dst.Extension = src.Extension ?? string.Empty;
            dst.IsaSet = src.IsaSet ?? string.Empty;
            var patternText = src.ExtractProp(index);
            var operandText = src.ExtractProp(index + 1);
            dst.PatternText = patternText ?? string.Empty;
            dst.Parts = patternText.SplitClean(Space);
            dst.OperandText = operandText ?? string.Empty;
            dst.Operands = operandText.SplitClean(Space);
            return ref dst;
        }

        [Op]
        public static ref XedPattern[] map(in XedInstructionDoc src, out XedPattern[] dst)
        {
            var patterns = list<XedPattern>();
            var count = src.RowCount;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                if(src.IsProp(i, PATTERN) && i != last)
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        var pattern = new XedPattern();
                        map(src,i,ref pattern);
                        patterns.Add(pattern);
                    }
                }
            }
            dst = patterns.ToArray();
            return ref dst;
        }

        static string BaseCodeText(XedPattern src)
        {
            var dst = text.build();
            var count = src.Parts.Length;
            for(var i=0; i<count; i++)
            {
                var part = src.Parts[i];
                dst.Append(part);
                if(i != count - 1)
                    dst.Append(Chars.Space);
            }

            return dst.ToString();
        }
    }
}