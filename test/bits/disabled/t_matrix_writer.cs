//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    public class t_matrix_writer : UnitTest<t_matrix_writer>
    {
        public override bool Enabled => false;
        
        public void check_matrrix_emission()
        {
            UnitDataDir.Clear();
            check_matrix_emission<N12,N14,long>(Pow2.T03);        
            check_matrix_emission<N19,N32,byte>(Pow2.T03);        
            check_matrix_emission(Pow2.T03, n31, n31, 0u);
            check_matrix_emission<N5,N5,float>(Pow2.T03);    
            check_matrix_emission<N7,N7,double>(Pow2.T03);                
        }

        public Matrix256<M,N,T> write<M,N,T>(FilePath dst, M m = default, N n = default, T exemplar = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            using var writer = dst.Writer();
            var src = Random.MatrixBlock<M,N,T>();
            if(NumericKinds.floating<T>())
                src.Apply(x => gfp.round<T>(x,4));
            Matrix.write(src,writer);
            return src;
        }

        public Matrix256<M,N,T> read<M,N,T>(FilePath src, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = Matrix.blockread<M,N,T>(src);            
            if(NumericKinds.floating<T>())
                dst.Apply(x => gfp.round<T>(x,4));
            return dst;
        }

        public FileName filename<M,N,T>(uint i, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => Matrix.filename<M,N,T>((int)i);

        void check_matrix_emission<M,N,T>(int count, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            for(var i=0u; i< count; i++)
            {                                
                var path = UnitPath(filename<M,N,T>(i));                
                var A = write(path, m, n, t);
                var B = read(path, m, n, t);
                Claim.Require(A == B);
            }
        }
    }
}