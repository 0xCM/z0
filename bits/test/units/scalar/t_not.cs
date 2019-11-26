//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using D = GDel;

    public class t_not : t_sb<t_not>
    {
        public void flip_g8i_check()
            => VerifyOp(OpKind.Not, x => (sbyte) ~x, D.flip<sbyte>());

        public void flip_g8u_check()        
            => VerifyOp(OpKind.Not, x => (byte) ~x, D.flip<byte>());            
        
        public void flip_g16i_check()        
            => VerifyOp(OpKind.Not, x => (short) ~x, D.flip<short>());            
        
        public void flip_g16u_check()        
            => VerifyOp(OpKind.Not, x => (ushort) ~x, D.flip<ushort>());                    

        public void flip_g32i_check()
            => VerifyOp(OpKind.Not, x => ~x, D.flip<int>());
        
        public void flip_g32u_check()        
            => VerifyOp(OpKind.Not, x => ~x, D.flip<uint>());
        
        public void flip_g64i_check()        
            => VerifyOp(OpKind.Not, x => ~x, D.flip<long>());
        
        public void flip_g64u_check()        
            => VerifyOp(OpKind.Not, x => ~x, D.flip<ulong>());                      
    }
}
