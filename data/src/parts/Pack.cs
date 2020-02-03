//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;    
    using static HexConst;
 
    public static partial class Data
    {
        public static ReadOnlySpan<byte> PackUSLo16x128x8u
            => new byte[16]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUSLo32x128x16u
            => new byte[16]{
                0,1, 4,5, 8,9, 12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };


        public static ReadOnlySpan<byte> PackUSLo16x256x8u
            => new byte[32]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUSLo32x256x16u
            => new byte[32]{
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                };

        public static ReadOnlySpan<byte> PackUSHi16x128x8u
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        public static ReadOnlySpan<byte> PackUSHi32x128x16u
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0,1,4,5,8,9,12,13
                };

        public static ReadOnlySpan<byte> PackUSHi16x256x8u
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        public static ReadOnlySpan<byte> PackUSHi32x256x16u
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13,
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13
                };                


        [DataRegistry]
        static void RegisterPacks()
        {
            var name = string.Empty;
            var index = PackIndex;

            name = "PackUSLo";
            Register(index++, TypeIdentities.resid(name, n16, n128, NumericKind.U8), PackUSLo16x128x8u);
            Register(index++, TypeIdentities.resid(name, n32, n128, NumericKind.U16), PackUSLo32x128x16u);
            Register(index++, TypeIdentities.resid(name, n16, n256, NumericKind.U8), PackUSLo16x256x8u);
            Register(index++, TypeIdentities.resid(name, n32, n256, NumericKind.U16), PackUSLo32x256x16u);

            name = "PackUSHi";
            Register(index++, TypeIdentities.resid(name, n16, n128, NumericKind.U8), PackUSHi16x128x8u);
            Register(index++, TypeIdentities.resid(name, n32, n128, NumericKind.U16), PackUSHi32x128x16u);
            Register(index++, TypeIdentities.resid(name, n16, n256, NumericKind.U8), PackUSHi16x256x8u);
            Register(index++, TypeIdentities.resid(name, n32, n256, NumericKind.U16), PackUSHi32x256x16u);

        }

    }
}