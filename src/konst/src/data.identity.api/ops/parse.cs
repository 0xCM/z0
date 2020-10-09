//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;
    using static IDI;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Assigns aggregate identity to an identity sequence
        /// </summary>
        /// <param name="open">The left fence</param>
        /// <param name="close">The right fence</param>
        /// <param name="sep">The sequence element delimiter</param>
        /// <param name="src">The source sequence</param>
        public static string sequential(char open, char close, char sep, IEnumerable<string> src)
            => text.concat(open, string.Join(sep,src), close);

        public static bool parse(string src, out SegmentedIdentity dst)
        {
            dst = default;
            if(src.Length == 0)
                return false;

            var indicator = TypeIndicator.Define(src[0]);
            var start = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(char.IsDigit(src[i]))
                {
                    start = i;
                    break;
                }
            }

            var parts = text.split(text.slice(src,start), IDI.SegSep);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];

                var sText = part0[0]
                    == IDI.Generic
                    ? text.slice(part0, 1, part0.Length - 1)
                    : part0;

                if(uint.TryParse(sText, out var n))
                {
                    if(Enum.IsDefined(typeof(CellWidth),n))
                    {
                        var bText = text.slice(part1,0, part1.Length - 1);
                        if(uint.TryParse(bText, out var by))
                        {
                            if(Enum.IsDefined(typeof(CellWidth), by))
                            {
                                dst = SegmentedIdentity.define(indicator, (CellWidth)n, ((NumericWidth)by).ToNumericKind((NumericIndicator)part1.Last()));
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        [Op]
        public static OpIdentity parse(string src)
        {
            if(text.empty(src))
                return OpIdentity.Empty;

            var name = src.TakeBefore(PartSep);
            var suffixed = src.Contains(SuffixSep);
            var suffix = suffixed ? src.TakeAfter(IDI.SuffixSep) : EmptyString;
            var generic = src.TakeAfter(PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = src.SplitClean(PartSep);
            var id = OpIdentity.define(src, name, suffix, generic, imm, components);
            return id;
        }
    }
}