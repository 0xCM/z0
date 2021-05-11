//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;

    partial struct Hex
    {
        [Op]
        public static HexPack hexpack(MemoryBlock src)
            => new HexPack(array(src), src.Size);

        [Op]
        public static HexPack hexpack(Index<MemoryBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return HexPack.Empty;
            src.Sort();
            return new HexPack(src, src.Select(x => x.Size).Max());
        }
    }
}