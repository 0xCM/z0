//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_unpack : t_sb<t_sb_unpack>
    {
        public void sb_unpack_8x8()
            => sb_unpack_check<byte,byte>();

        public void sb_unpack_16x8()
            => sb_unpack_check<ushort,byte>();

        public void sb_unpack_16x16()
            => sb_unpack_check<ushort,ushort>();

        public void sb_unpack_32x8()
            => sb_unpack_check<uint,byte>();

        public void sb_unpack_32x32()
            => sb_unpack_check<uint,uint>();

        public void sb_unpack_32x16()
            => sb_unpack_check<uint,ushort>();

        public void sb_unpack_64x8()
            => sb_unpack_check<ulong,byte>();

        public void sb_unpack_64x16()
            => sb_unpack_check<ulong,ushort>();

        public void sb_unpack_64x32()
            => sb_unpack_check<ulong,uint>();

        public void sb_unpack_64x64()
            => sb_unpack_check<ulong,ulong>();
        
        public void sb_unpack_8x8_bench()
            => sb_unpack_bench<byte,byte>();

        public void sb_unpack_16x8_bench()
            => sb_unpack_bench<ushort,byte>();

        public void sb_unpack_16x16_bench()
            => sb_unpack_bench<ushort,ushort>();

        public void sb_unpack_32x8_bench()
            => sb_unpack_bench<uint,byte>();

        public void sb_unpack_32x32_bench()
            => sb_unpack_bench<uint,uint>();

        public void sb_unpack_32x16_bench()
            => sb_unpack_bench<uint,ushort>();

        public void sb_unpack_64x8_bench()
            => sb_unpack_bench<ulong,byte>();

        public void sb_unpack_64x64_bench()
            => sb_unpack_bench<ulong,ulong>();

    }
}