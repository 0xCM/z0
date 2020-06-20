//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Control;

    public abstract class t_vectors<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_vectors<U>,new()
    {

    }

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
            
            Claim.require(tCell.IsNonEmpty());

            if(tVector == typeof(Vector128<sbyte>))
            {
                Claim.require(tCell == typeof(sbyte));
                Claim.eq(VectorKind.v128x8i, kVector);
            }
            else if(tVector == typeof(Vector128<byte>))
            {
                Claim.require(tCell == typeof(byte));
                Claim.eq(VectorKind.v128x8u, kVector);
            }
            else if(tVector == typeof(Vector128<short>))
            {
                Claim.require(tCell == typeof(short));
                Claim.eq(VectorKind.v128x16i, kVector);
            }
            else if(tVector == typeof(Vector128<ushort>))
            {
                Claim.require(tCell == typeof(ushort));
                Claim.eq(VectorKind.v128x16u, kVector);
            }
            else if(tVector == typeof(Vector128<int>))
            {
                Claim.require(tCell == typeof(int));
                Claim.eq(VectorKind.v128x32i, kVector);
            }
            else if(tVector == typeof(Vector128<uint>))
            {
                Claim.require(tCell == typeof(uint));
                Claim.eq(VectorKind.v128x32u, kVector);
            }
            else if(tVector == typeof(Vector128<long>))
            {
                Claim.require(tCell == typeof(long));
                Claim.eq(VectorKind.v128x64i, kVector);
            }
            else if(tVector == typeof(Vector128<ulong>))
            {
                Claim.require(tCell == typeof(ulong));
                Claim.eq(VectorKind.v128x64u, kVector);
            }
            else if(tVector == typeof(Vector128<float>))
            {
                Claim.require(tCell == typeof(float));
                Claim.eq(VectorKind.v128x32f, kVector);
            }
            else if(tVector == typeof(Vector128<double>))
            {
                Claim.require(tCell == typeof(double));
                Claim.eq(VectorKind.v128x64f, kVector);
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
            
            Claim.require(tCell.IsNonEmpty());

            if(tVector == typeof(Vector256<sbyte>))
            {
                Claim.require(tCell == typeof(sbyte));
                Claim.eq(VectorKind.v256x8i, kVector);
            }
            else if(tVector == typeof(Vector256<byte>))
            {
                Claim.require(tCell == typeof(byte));
                Claim.eq(VectorKind.v256x8u, kVector);
            }
            else if(tVector == typeof(Vector256<short>))
            {
                Claim.require(tCell == typeof(short));
                Claim.eq(VectorKind.v256x16i, kVector);
            }
            else if(tVector == typeof(Vector256<ushort>))
            {
                Claim.require(tCell == typeof(ushort));
                Claim.eq(VectorKind.v256x16u, kVector);
            }
            else if(tVector == typeof(Vector256<int>))
            {
                Claim.require(tCell == typeof(int));
                Claim.eq(VectorKind.v256x32i, kVector);
            }
            else if(tVector == typeof(Vector256<uint>))
            {
                Claim.require(tCell == typeof(uint));
                Claim.eq(VectorKind.v256x32u, kVector);
            }
            else if(tVector == typeof(Vector256<long>))
            {
                Claim.require(tCell == typeof(long));
                Claim.eq(VectorKind.v256x64i, kVector);
            }
            else if(tVector == typeof(Vector256<ulong>))
            {
                Claim.require(tCell == typeof(ulong));
                Claim.eq(VectorKind.v256x64u, kVector);
            }
            else if(tVector == typeof(Vector256<float>))
            {
                Claim.require(tCell == typeof(float));
                Claim.eq(VectorKind.v256x32f, kVector);
            }
            else if(tVector == typeof(Vector256<double>))
            {
                Claim.require(tCell == typeof(double));
                Claim.eq(VectorKind.v256x64f, kVector);
            }
            else
            {
                Notify($"{tVector.DisplayName()} is not a recognized 256-bit vector type");
                Claim.Fail();
            }
        }
    }
}