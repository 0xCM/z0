//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using D = GDel;

    public class t_and : UnitTest<t_and>
    {
        public void scalar_and_8i()
        {
            VerifyOp(OpKind.And, (x,y) => (sbyte)(x & y), D.and<sbyte>());
        }

        public void scalar_and_8u()
        {
            VerifyOp(OpKind.And, (x,y) => (byte)(x & y), D.and<byte>());
        }

        public void scalar_and_16i()
        {
            VerifyOp(OpKind.And, (x,y) => (short)(x & y), D.and<short>());            
        }

        public void scalar_and_16u()
        {
            VerifyOp(OpKind.And, (x,y) => (ushort)(x & y), D.and<ushort>());
        }

        public void scalar_and_32i()
        {
            VerifyOp(OpKind.And, (x,y) => (x & y), D.and<int>());
        }

        public void scalar_and_32u()
        {
            VerifyOp(OpKind.And, (x,y) => (x & y), D.and<uint>());
        }


        public void scalar_and_64i()
        {
            VerifyOp(OpKind.And, (x,y) => (x & y), D.and<long>());
        }


        public void scalar_and_64u()
        {
            VerifyOp(OpKind.And, (x,y) => (x & y), D.and<ulong>());

        }
    }

}