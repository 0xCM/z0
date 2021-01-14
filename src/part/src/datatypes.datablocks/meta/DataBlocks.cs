//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Meta
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost("meta.blocks")]
    public struct DataBlocks
    {
        [MethodImpl(Inline)]
        public static DataBlock define(uint index, uint lo, uint hi)
            => new DataBlock(index, (ulong)lo | (ulong)hi << 32);

        [Op]
        public static Index<DataBlock> alloc(uint count)
            => memory.alloc<DataBlock>(count);

        [Op]
        public static TextBlock first(DataBlock src)
        {
            var name = src.Name;
            var modifiers = "public";
            var type = "struct";
            var paramName = "T";
            var paramConstraints = "unmanaged";

            return default;
        }

        [Op]
        public static DataBlockSeq specify8()
        {
            var buffer = alloc(8);
            ref var dst = ref buffer.First;
            var i = 0u;
            seek(dst, i++) = define(i, 1, 0); // 1:[0 | 1]
            seek(dst, i++) = define(i, 1, 1); // 2:[1 | 1]
            seek(dst, i++) = define(i, 2, 1); // 3:[1 | 2]
            seek(dst, i++) = define(i, 2, 2); // 4:[2 | 2]
            seek(dst, i++) = define(i, 3, 2); // 5:[2 | 3]
            seek(dst, i++) = define(i, 3, 3); // 5:[3 | 3]
            seek(dst, i++) = define(i, 4, 2); // 6:[2 | 4]
            seek(dst, i++) = define(i, 4, 3); // 7:[3 | 4]
            seek(dst, i++) = define(i, 4, 4); // 8:[4 | 4]
            return new DataBlockSeq(buffer);
        }
    }
}