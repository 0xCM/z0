//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using D = GDel;
    
    public class t_sub : t_gmath<t_sub>
    {
        public void sub_8i()        
            => VerifyOp((x,y) => (sbyte)(x - y), D.sub<sbyte>());

        public void sub_8u()        
            => VerifyOp((x,y) => (byte)(x - y), D.sub<byte>());

        public void sub_16i()        
            => VerifyOp((x,y) => (short)(x - y), D.sub<short>());

        public void sub_16u()        
            => VerifyOp((x,y) => (ushort)(x - y), D.sub<ushort>());

        public void sub_32i()        
            => VerifyOp((x,y) => x - y, D.sub<int>());

        public void sub_32u()        
            => VerifyOp((x,y) => x - y, D.sub<uint>());

        public void sub_64i()        
            => VerifyOp((x,y) => x - y, D.sub<long>());

        public void sub_64u()        
            => VerifyOp((x,y) => x - y, D.sub<ulong>());

        public void sub_f()
        {
            VerifyOp((x,y) => (x - y), D.sub<float>());
            VerifyOp((x,y) => (x - y), D.sub<double>());              
        }
    }

}