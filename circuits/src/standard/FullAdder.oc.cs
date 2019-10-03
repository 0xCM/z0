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

    partial class circop
    {

        public static void cir_fa_8b(Bit x1, Bit x2, Bit x3, out Bit x7, out Bit x8)            
            => FullAdder.Compute(x1, x2, x3, out x7, out x8);

        public static OutPair<Bit> cir_fa_8b_pair(Bit x1, Bit x2, Bit x3)            
            => FullAdder.Compute(x1, x2, x3);

        public static void cir_fa_8u(byte x1, byte x2, byte x3, out byte x7, out byte x8)            
            => FullAdder.Compute(x1, x2, x3, out x7, out x8);

        public static void cir_fa_32u(uint x1, uint x2, uint x3, out uint x7, out uint x8)            
            => FullAdder.Compute(x1, x2, x3, out x7, out x8);

        public static void cir_fa_64u(ulong x1, ulong x2, ulong x3, out ulong x7, out ulong x8)            
            => FullAdder.Compute(x1, x2, x3, out x7, out x8);

        public static BitVector64 cir_fa_bv32x64(BitVector32 x1, BitVector32 x2, BitVector32 x3)            
            => FullAdder.Compute(x1, x2, x3);


        public static void cir_fa_128x8u(Vec128<byte> x1, Vec128<byte> x2, Vec128<byte> x3, out Vec128<byte> x7,out Vec128<byte> x8)
            => FullAdder.Compute(x1,x2,x3, out x7, out x8);

        public static void cir_fa_128x32u(Vec128<uint> x1, Vec128<uint> x2, Vec128<uint> x3, out Vec128<uint> x7,out Vec128<uint> x8)
            => FullAdder.Compute(x1,x2,x3, out x7, out x8);

        public static void cir_fa_128x64u(Vec128<ulong> x1, Vec128<ulong> x2, Vec128<ulong> x3, out Vec128<ulong> x7,out Vec128<ulong> x8)
            => FullAdder.Compute(x1,x2,x3, out x7, out x8);

        public static void cir_fa_256x8u(Vec256<byte> x1, Vec256<byte> x2, Vec256<byte> x3, out Vec256<byte> x7,out Vec256<byte> x8)
            => FullAdder.Compute(x1,x2,x3, out x7, out x8);

        public static void cir_fa_256x32u(Vec256<uint> x1, Vec256<uint> x2, Vec256<uint> x3, out Vec256<uint> x7,out Vec256<uint> x8)
            => FullAdder.Compute(x1,x2,x3, out x7, out x8);

        public static void cir_fa_256x64u(Vec256<ulong> x1, Vec256<ulong> x2, Vec256<ulong> x3, out Vec256<ulong> x7,out Vec256<ulong> x8)
            => FullAdder.Compute(x1,x2,x3, out x7, out x8);





    }

}