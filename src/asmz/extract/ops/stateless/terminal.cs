//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ExtractTermData;

    partial class ApiExtractor
    {
        public static unsafe ApiMemberExtract trim(in ApiMemberExtract src)
        {
            var block = src.Block;
            var term = terminal(block);
            if(term.IsNonEmpty)
            {
                var length = term.Offset + term.Modifier;
                var data = slice(block.View, 0, length).ToArray();
                block = new ApiExtractBlock(src.BaseAddress, src.OpUri, data);
                return new ApiMemberExtract(src.Member, block);
            }
            else
                return src;
        }

        [Op]
        public static ExtractTermInfo terminal(in BinaryCode src)
        {
            const byte MaxSeg = 6;

            var data = src.View;
            var size = data.Length;
            var found = NotFound;
            var max = size + MaxSeg - 1;
            var kind = ExtractTermKind.None;
            var modifier = z8i;
            for(var offset=0; offset<max; offset++)
            {
                if(slice(data, offset, 3).SequenceEqual(Term3A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term3A;
                    modifier = Term3AModifier;
                    break;
                }
                else if(slice(data, offset, 6).SequenceEqual(Term6A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term6A;
                    modifier = Term6AModifier;
                    break;
                }
                else if(slice(data, offset, 5).SequenceEqual(Term5A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term5A;
                    modifier = Term5AModifier;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term4A;
                    modifier = Term4AModifier;
                    break;
                }
                else if(slice(data, offset, 3).SequenceEqual(Term3B))
                {
                    found = offset;
                    kind = ExtractTermKind.Term3B;
                    modifier = Term3BModifier;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4B))
                {
                    found = offset;
                    kind = ExtractTermKind.Term4B;
                    modifier = Term4BModifier;
                    break;
                }
            }

            return new ExtractTermInfo(kind, found, modifier);
        }
    }
}