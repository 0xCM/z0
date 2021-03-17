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

    public readonly struct DataBlockSpec
    {
        [MethodImpl(Inline)]
        public static DataBlockSpec define(uint index, uint lo, uint hi)
            => new DataBlockSpec(index, (ulong)lo | (ulong)hi << 32);

        [Op]
        public static Index<DataBlockSpec> alloc(uint count)
            => memory.alloc<DataBlockSpec>(count);

        [Op]
        public static DataBlockSeqSpec define(N8 n)
        {
            var buffer = memory.alloc<DataBlockSpec>(n);
            ref var dst = ref first(buffer);
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
            return new DataBlockSeqSpec(buffer);
        }

        public uint BlockIndex {get;}

        public ulong Partition {get;}

        public Name Name => "Block" + BlockIndex.ToString();

        [MethodImpl(Inline)]
        public DataBlockSpec(uint index, ulong partition)
        {
            BlockIndex = index;
            Partition = partition;
        }
    }
}