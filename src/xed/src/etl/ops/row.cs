//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static XedSourceMarkers;
    using static z;

    partial struct XedWfOps
    {
        [Op]
        public static XedPatternRow row(in XedPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOfFirst(ASSIGN).Trim(), EmptyString);
            var dst = new XedPatternRow();
            dst.Class = src.Class;
            dst.Category = src.Category;
            dst.Extension =  src.Extension;
            dst.IsaSet =  src.IsaSet;
            dst.BaseCode =  code(src);
            dst.Mod =  mod(src);
            dst.Reg =  reg(src);
            dst.Pattern =  src.PatternText;
            dst.Operands =  src.OperandText;
            return dst;
        }

        public static BinaryCode code(XedPattern src)
        {
            var dst = 0ul;
            var pos = 0u;
            var count = src.Parts.Length;
            var parser = HexByteParser.Service;
            for(var i=0u; i<count; i++)
            {
                var part = src.Parts[i];
                if(parser.HasPreSpec(part))
                    seek8(dst, pos++) = parser.ParseByte(part);
            }

            return slice(ByteRead.read8(dst),0, pos);
        }
    }
}