//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct HexFormat
    {
        [Op]
        public static string bytes(ushort src)
            => format(core.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(short src)
            => format(core.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(int src)
            => format(core.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(uint src)
            => format(core.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(long src)
            => format(core.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(ulong src)
            => format(core.bytes(src), HexFormatSpecs.HexData);
    }
}