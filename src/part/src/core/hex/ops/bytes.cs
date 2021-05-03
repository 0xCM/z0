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
            => format(memory.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(short src)
            => format(memory.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(int src)
            => format(memory.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(uint src)
            => format(memory.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(long src)
            => format(memory.bytes(src), HexFormatSpecs.HexData);

        [Op]
        public static string bytes(ulong src)
            => format(memory.bytes(src), HexFormatSpecs.HexData);
    }
}