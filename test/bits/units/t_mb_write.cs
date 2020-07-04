//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Memories;

    public class t_mb_write : UnitTest<t_mb_write>
    {
        public void write()
        {
            UnitDataDir.Clear();
            VerifyWriter<N12,N14,long>(Pow2.T03);        
            VerifyWriter<N19,N32,byte>(Pow2.T03);        
            VerifyWriter(Pow2.T03, n31, n31, 0u);                    

            VerifyWriter<N5,N5,float>(Pow2.T03);    
            VerifyWriter<N7,N7,double>(Pow2.T03);                
        }

        static T round<T>(T src)
            where T : unmanaged
        {
            return gfp.round(src, 4);
        }

        void VerifyWriter<M,N,T>(int count, M m = default, N n = default, T exemplar = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var folder = FolderName.Define("matrices");
            var isFp = NumericKinds.floating<T>();
            
            Matrix256<M,N,T> Write(FilePath dst)
            {
                using var writer = dst.Writer();
                var A = Random.MatrixBlock<M,N,T>();
                if(isFp)
                    A.Apply(round);
                Matrix.write(A,writer);
                return A;
            }

            Matrix256<M,N,T> Read(FilePath src)
            {
                var B = Matrix.blockread<M,N,T>(src);
                if(isFp)
                    B.Apply(round);
                return B;

            }

            for(var i=0; i< count; i++)
            {                                
                var path = UnitPath(Matrix.filename<M,N,T>(i));                
                var A = Write(path);
                var B = Read(path);                                    
                Claim.Require(A == B);
            }
        }
    }
}