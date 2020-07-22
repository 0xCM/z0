//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;

    public class t_cell_type : t_vectors<t_cell_type>
    {    
        public void check_cell_types()
        {
            iter(VectorType.Types128, t => check_cell_type(t,n128));
            iter(VectorType.Types256, t => check_cell_type(t,n256));            
        }
        
        void check_cell_type(Type tVector, N128 w)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();

            if(TraceDetailEnabled)
            {
                Notify($"tVector := {tVector.DisplayName()}");
                Notify($"kVector := {kVector}");
                Notify($"tCell := {tCell.Name}");
            }
            
            Claim.Require(tCell.IsNonEmpty());

            if(tVector == typeof(Vector128<sbyte>))
            {
                Claim.Require(tCell == typeof(sbyte));
                Claim.Eq(VectorKind.v128x8i, kVector);
            }
            else if(tVector == typeof(Vector128<byte>))
            {
                Claim.Require(tCell == typeof(byte));
                Claim.Eq(VectorKind.v128x8u, kVector);
            }
            else if(tVector == typeof(Vector128<short>))
            {
                Claim.Require(tCell == typeof(short));
                Claim.Eq(VectorKind.v128x16i, kVector);
            }
            else if(tVector == typeof(Vector128<ushort>))
            {
                Claim.Require(tCell == typeof(ushort));
                Claim.Eq(VectorKind.v128x16u, kVector);
            }
            else if(tVector == typeof(Vector128<int>))
            {
                Claim.Require(tCell == typeof(int));
                Claim.Eq(VectorKind.v128x32i, kVector);
            }
            else if(tVector == typeof(Vector128<uint>))
            {
                Claim.Require(tCell == typeof(uint));
                Claim.Eq(VectorKind.v128x32u, kVector);
            }
            else if(tVector == typeof(Vector128<long>))
            {
                Claim.Require(tCell == typeof(long));
                Claim.Eq(VectorKind.v128x64i, kVector);
            }
            else if(tVector == typeof(Vector128<ulong>))
            {
                Claim.Require(tCell == typeof(ulong));
                Claim.Eq(VectorKind.v128x64u, kVector);
            }
            else if(tVector == typeof(Vector128<float>))
            {
                Claim.Require(tCell == typeof(float));
                Claim.Eq(VectorKind.v128x32f, kVector);
            }
            else if(tVector == typeof(Vector128<double>))
            {
                Claim.Require(tCell == typeof(double));
                Claim.Eq(VectorKind.v128x64f, kVector);
            }
            else
            {
                Notify($"{tVector.DisplayName()} is not a recognized 128-bit vector type");
                Claim.Fail();
            }
        }

        void check_cell_type(Type tVector, N256 w)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();

            if(TraceDetailEnabled)
            {
                Notify($"tVector := {tVector.DisplayName()}");
                Notify($"kVector := {kVector}");
                Notify($"tCell := {tCell.Name}");
            }
            
            Claim.Require(tCell.IsNonEmpty());

            if(tVector == typeof(Vector256<sbyte>))
            {
                Claim.Require(tCell == typeof(sbyte));
                Claim.Eq(VectorKind.v256x8i, kVector);
            }
            else if(tVector == typeof(Vector256<byte>))
            {
                Claim.Require(tCell == typeof(byte));
                Claim.Eq(VectorKind.v256x8u, kVector);
            }
            else if(tVector == typeof(Vector256<short>))
            {
                Claim.Require(tCell == typeof(short));
                Claim.Eq(VectorKind.v256x16i, kVector);
            }
            else if(tVector == typeof(Vector256<ushort>))
            {
                Claim.Require(tCell == typeof(ushort));
                Claim.Eq(VectorKind.v256x16u, kVector);
            }
            else if(tVector == typeof(Vector256<int>))
            {
                Claim.Require(tCell == typeof(int));
                Claim.Eq(VectorKind.v256x32i, kVector);
            }
            else if(tVector == typeof(Vector256<uint>))
            {
                Claim.Require(tCell == typeof(uint));
                Claim.Eq(VectorKind.v256x32u, kVector);
            }
            else if(tVector == typeof(Vector256<long>))
            {
                Claim.Require(tCell == typeof(long));
                Claim.Eq(VectorKind.v256x64i, kVector);
            }
            else if(tVector == typeof(Vector256<ulong>))
            {
                Claim.Require(tCell == typeof(ulong));
                Claim.Eq(VectorKind.v256x64u, kVector);
            }
            else if(tVector == typeof(Vector256<float>))
            {
                Claim.Require(tCell == typeof(float));
                Claim.Eq(VectorKind.v256x32f, kVector);
            }
            else if(tVector == typeof(Vector256<double>))
            {
                Claim.Require(tCell == typeof(double));
                Claim.Eq(VectorKind.v256x64f, kVector);
            }
            else
            {
                Notify($"{tVector.DisplayName()} is not a recognized 256-bit vector type");
                Claim.Fail();
            }
        }
    }
}