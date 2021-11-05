//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Parser(typeof(CellType))]
    public readonly struct CellTypeParser : IParser<CellType>
    {
        public static CellTypeParser Service => default;

        public Outcome Validate()
        {
            const string Case1 = "13u";
            const string Case2 = "(13:16)u";

            var result = Outcome.Failure;
            if(Parse(Case1,  out var ct1))
                result = ct1.ContentWidth == 13 && ct1.StorageWidth == 13 && ct1.Class == PrimalKind.UnsignedInt;

            if(result.Fail)
                return result;

            if(Parse(Case2,  out var ct2))
                result = ct2.ContentWidth == 13 && ct2.StorageWidth == 16 && ct1.Class == PrimalKind.UnsignedInt;

            return result;
        }

        public Outcome Parse(string src, out CellType dst)
        {
            var input = text.trim(src);
            var result = Outcome.Failure;
            dst = CellType.Empty;
            if(text.empty(input))
                return result;

            var length = input.Length;
            var q = length - 1;

            if(!types.parse(input[q], out PrimalKind pc))
                return result.Fail;

            var i = text.index(input, Chars.Colon);
            if(i >= 0)
            {
                var l = text.index(input,Chars.LParen);
                var r = text.index(input,Chars.RParen);
                if(l >= 0 && r>=0)
                {
                    var b = text.inside(input,l,r);
                    var k = text.index(b, Chars.Colon);
                    if(k >=0)
                    {
                        var cw = text.left(b,k);
                        var sw = text.right(b,k);
                        if(uint.TryParse(cw, out var ncw))
                        {
                            if(uint.TryParse(sw, out var nsw))
                            {
                                var c = text.right(input,r);
                                dst = new CellType(ncw,nsw,pc);
                                result = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if(q != 0)
                {
                    if(uint.TryParse(text.left(input, q), out var n))
                    {
                        dst = new CellType(n,n,pc);
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}