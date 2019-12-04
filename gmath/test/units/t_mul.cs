//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using D = GDel;
    
    public class t_mul : UnitTest<t_mul>
    {
        public void mul_8i()        
            => VerifyOp((x,y) => (sbyte)(x * y), D.mul<sbyte>());
        
        public void mul_8u()        
            => VerifyOp((x,y) => (byte)(x * y), D.mul<byte>());
                
        public void mul_16i()        
            => VerifyOp((x,y) => (short)(x * y), D.mul<short>());        

        public void mul_16u()        
            => VerifyOp((x,y) => (ushort)(x * y), D.mul<ushort>());            
        
        public void mul_32i()        
            => VerifyOp((x,y) => (x * y), D.mul<int>());            
        
        public void mul_32u()        
            => VerifyOp((x,y) => (x * y), D.mul<uint>());
                
        public void mul_64i()        
            => VerifyOp((x,y) => (x * y), D.mul<long>());                    

        public void mul_64u()
            => VerifyOp((x,y) => (x * y), D.mul<ulong>());            
        
        public void mul_32f()        
            => VerifyOp((x,y) => (x * y), D.mul<float>());
        
        public void mul_64f()        
            => VerifyOp((x,y) => (x * y), D.mul<double>());                  
    }
}