//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static Part;
    using static IntelIntrinsicsModel;

    public readonly partial struct IntelIntrinsics
    {
        public static string identifier(Intrinsic src)
        {
            var count = src.instructions.Count;
            if(count != 0)
                return src.instructions[0].name;
            else
                return EmptyString;
        }

        [Op]
        public static string label(Intrinsic src)
            => text.concat("## ", src.instructions.Count != 0
            ? text.concat(identifier(src), Space, Chars.Dash, Space, src.name)
            : identifier(src));

        public static XmlDoc doc()
            => text.xml(Resources.utf8(Assets.create().InstrinsicXml()));

        public static Index<Intrinsic> parse()
            => parse(doc());

        public static Index<Intrinsic> parse(XmlDoc src)
            => IntelIntrinsicsDocReader.read(src);
    }
}