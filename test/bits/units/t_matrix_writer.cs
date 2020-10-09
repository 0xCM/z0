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
        public override bool Enabled => true;

        public void check_matrix_emission()
        {
            UnitDataDir.Clear();
            check(Pow2.T03, n12, n14, t64i);
            check(Pow2.T03, n19, n32, t8u);
            check(Pow2.T03, n31, n31, t32u);
            check(Pow2.T03, n5, n5, t32f);
            check(Pow2.T03, n5, n5, t64f);
        }

        void check(uint count, N12 m, N14 n, I64 k)
            => check_emission<N12,N14,long>(count);

        void check(uint count, N19 m, N32 n, U8 k)
            => check_emission(count,m,n,z8);

        void check(uint count, N31 m, N31 n, U32 k)
            => check_emission(count,m,n,z8);

        void check(uint count, N5 m, N5 n, F32 k)
            => check_emission(count,m,n,z8);

        void check(uint count, N5 m, N5 n, F64 k)
            => check_emission(count,m,n,z8);

        public FS.FileName filename<M,N,T>(uint i, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Matrix.filename<M,N,T>((int)i);

        void check_emission<M,N,T>(uint count, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0u; i< count; i++)
            {
                var path = Paths.CasePath(filename<M,N,T>(i));
                var matrix = Random.MatrixBlock<M,N,T>();
                var A = MatrixWriter.write(matrix, path, m, n, t);
                var B = MatrixReader.read(path, m, n, t);
                Claim.Require(A == B);
            }
        }
    }
}