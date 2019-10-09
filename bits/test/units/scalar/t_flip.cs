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
    using D = PrimalDelegates;

    public class t_flip : ScalarBitTest<t_flip>
    {
        public void flip_g8i_check()
            => VerifyOp(OpKind.Flip, x => (sbyte) ~x, D.flip<sbyte>());

        public void flip_g8u_check()        
            => VerifyOp(OpKind.Flip, x => (byte) ~x, D.flip<byte>());            
        
        public void flip_g16i_check()        
            => VerifyOp(OpKind.Flip, x => (short) ~x, D.flip<short>());            
        
        public void flip_g16u_check()        
            => VerifyOp(OpKind.Flip, x => (ushort) ~x, D.flip<ushort>());                    

        public void flip_g32i_check()
            => VerifyOp(OpKind.Flip, x => ~x, D.flip<int>());
        
        public void flip_g32u_check()        
            => VerifyOp(OpKind.Flip, x => ~x, D.flip<uint>());
        
        public void flip_g64i_check()        
            => VerifyOp(OpKind.Flip, x => ~x, D.flip<long>());
        
        public void flip_g64u_check()        
            => VerifyOp(OpKind.Flip, x => ~x, D.flip<ulong>());                      
    }
}
