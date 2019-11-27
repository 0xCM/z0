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

    public class t_sb_not : t_sb<t_sb_not>
    {
        public void sb_not_8i()
            => VerifyOp(OpKind.Not, x => (sbyte) ~x, D.not<sbyte>());

        public void sb_not_8u()        
            => VerifyOp(OpKind.Not, x => (byte) ~x, D.not<byte>());            
        
        public void sb_not_16i()        
            => VerifyOp(OpKind.Not, x => (short) ~x, D.not<short>());            
        
        public void sb_not_16u()        
            => VerifyOp(OpKind.Not, x => (ushort) ~x, D.not<ushort>());                    

        public void sb_not_32i()
            => VerifyOp(OpKind.Not, x => ~x, D.not<int>());
        
        public void sb_not_32u()        
            => VerifyOp(OpKind.Not, x => ~x, D.not<uint>());
        
        public void sb_not_64i()        
            => VerifyOp(OpKind.Not, x => ~x, D.not<long>());
        
        public void sb_not_64u()        
            => VerifyOp(OpKind.Not, x => ~x, D.not<ulong>());                      
    }
}
