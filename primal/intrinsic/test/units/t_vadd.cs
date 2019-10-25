//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vadd : IntrinsicTest<t_vadd>
    {

        public void add128()
        {
            add128_check<sbyte>();
            add128_check<byte>();
            add128_check<short>();
            add128_check<ushort>();
            add128_check<int>();
            add128_check<uint>();
            add128_check<long>();
            add128_check<ulong>();
        }

        public void add256()
        {
            add256_check<sbyte>();
            add256_check<byte>();
            add256_check<short>();
            add256_check<ushort>();
            add256_check<int>();
            add256_check<uint>();
            add256_check<long>();
            add256_check<ulong>();

        }

        void add128_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector128BinOp<T>(ginx.vadd), gmath.add<T>);
            TypeCaseEnd<T>();
        }

        void add256_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector256BinOp<T>(ginx.vadd<T>), gmath.add<T>);
            TypeCaseEnd<T>();
        }

    }

}