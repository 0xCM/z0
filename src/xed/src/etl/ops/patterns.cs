//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static XedSourceMarkers;

    partial struct XedWfOps
    {
        public static string pattern(XedInstructionDoc src, string name)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var row = src.Data[i];
                var rowText = row.Text;
                if(text.nonempty(rowText) && rowText.StartsWith(name))
                {
                    var value = rowText.RightOfFirst(PROP_DELIMITER);
                    if(text.nonempty(value))
                        return value.Trim();
                }
            }
            return EmptyString;
        }

        public static ref XedPattern pattern(in XedInstructionDoc src, int index, ref XedPattern dst)
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

        public static XedPattern[] patterns(in XedInstructionDoc src)
            => patterns(src, out var _);

        [Op]
        public static ref XedPattern[] patterns(in XedInstructionDoc src, out XedPattern[] dst)
        {
            var patterns = z.list<XedPattern>();
            var count = src.RowCount;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                if(src.IsProp(i, PATTERN) && i != last)
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        var pattern = new XedPattern();
                        XedWfOps.pattern(src, i, ref pattern);
                        patterns.Add(pattern);
                    }
                }
            }
            dst = patterns.ToArray();
            return ref dst;
        }
    }
}