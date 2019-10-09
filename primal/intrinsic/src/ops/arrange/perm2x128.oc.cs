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

        public static Vec256<byte> vperm2x128_d256x64u_AC(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.AC);

        public static Vec256<byte> vperm2x128_g256x64u_AC(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.AC);

        public static Vec256<byte> vperm2x128_d256x64u_AD(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.AD);

        public static Vec256<byte> vperm2x128_g256x64u_AD(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.AD);

        public static Vec256<byte> vperm2x128_d256x64u_BC(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.BC);

        public static Vec256<byte> vperm2x128_g256x64u_BC(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.BC);

        public static Vec256<byte> vperm2x128_d256x64u_BD(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.BD);

        public static Vec256<byte> vperm2x128_g256x64u_BD(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.BD);

        public static Vec256<byte> vperm2x128_d256x64u_CA(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.CA);

        public static Vec256<byte> vperm2x128_g256x64u_CA(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.CA);

        public static Vec256<byte> vperm2x128_d256x64u_CB(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.CB);

        public static Vec256<byte> vperm2x128_g256x64u_CB(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.CB);

        public static Vec256<byte> vperm2x128_d256x64u_DA(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.DA);

        public static Vec256<byte> vperm2x128_g256x64u_DA(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.DA);

        public static Vec256<byte> vperm2x128_d256x64u_DB(in Vec256<byte> x, in Vec256<byte> y)
            => dinx.vperm2x128(x,y, Perm2x128.DB);

        public static Vec256<byte> vperm2x128_g256x64u_DB(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.vperm2x128(x,y, Perm2x128.DB);

        public static Vec256<long> vperm2x128_d256x64u_AC(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.AC);

        public static Vec256<long> vperm2x128_g256x64u_AC(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.AC);

        public static Vec256<long> vperm2x128_d256x64u_AD(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.AD);

        public static Vec256<long> vperm2x128_g256x64u_AD(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.AD);

        public static Vec256<long> vperm2x128_d256x64u_BC(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.BC);

        public static Vec256<long> vperm2x128_g256x64u_BC(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.BC);

        public static Vec256<long> vperm2x128_d256x64u_BD(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.BD);

        public static Vec256<long> vperm2x128_g256x64u_BD(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.BD);

        public static Vec256<long> vperm2x128_d256x64u_CA(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.CA);

        public static Vec256<long> vperm2x128_g256x64u_CA(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.CA);

        public static Vec256<long> vperm2x128_d256x64u_CB(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.CB);

        public static Vec256<long> vperm2x128_g256x64u_CB(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.CB);

        public static Vec256<long> vperm2x128_d256x64u_DA(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.DA);

        public static Vec256<long> vperm2x128_g256x64u_DA(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.DA);

        public static Vec256<long> vperm2x128_d256x64u_DB(in Vec256<long> x, in Vec256<long> y)
            => dinx.vperm2x128(x,y, Perm2x128.DB);

        public static Vec256<long> vperm2x128_g256x64u_DB(in Vec256<long> x, in Vec256<long> y)
            => ginx.vperm2x128(x,y, Perm2x128.DB);

    }

}