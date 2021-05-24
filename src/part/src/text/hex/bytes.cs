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
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(short src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(int src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(uint src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(long src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(ulong src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);
    }
}