//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class inxvoc
    {

        public static ref Vec256<short> convert_128x8i_to_256x16i(in Vec128<sbyte> src, out Vec256<short> dst)
            => ref dinx.convert(src, out dst);

        public static ref Vec256<short> convert_128x8u_to_256x16i(in Vec128<byte> src, out Vec256<short> dst)
            => ref dinx.convert(src, out dst);

        public static ref Vec256<ushort> convert_128x8u_to_256x16u(in Vec128<byte> src, out Vec256<ushort> dst)
            => ref dinx.convert(src, out dst);

        public static ref Vec256<int> convert_128x8u_to_256x32i(in Vec128<byte> src, out Vec256<int> dst)            
            => ref dinx.convert(src, out dst);

        public static ref Vec256<long> convert_128x8u_to_256x64i(in Vec128<byte> src, out Vec256<long> dst)
            => ref dinx.convert(src, out dst);

        public static ref Vec256<int> convert_128x16u_to_256x32i(in Vec128<ushort> src, out Vec256<int> dst)
            => ref dinx.convert(src, out dst);

        public static ref Vec256<uint> convert_128x16u_to_256x32u(in Vec128<ushort> src, out Vec256<uint> dst)
            => ref dinx.convert(src, out dst);

        public static ref Vec256<long> convert_128x32u_to_256x64i(in Vec128<uint> src, out Vec256<long> dst)
            => ref dinx.convert(src, out dst);
    }

}