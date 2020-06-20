//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.IO;


    using static Konst;
    using static Memories;

    using K = Kinds;

    public class t_embed_imm8 : t_asm<t_embed_imm8>
    {    
        protected override bool TraceDetailEnabled
            => false;

        public t_embed_imm8()
        {

        }

        IDynexus Dynamic => Dynops.Services.Dynexus;

        VMethodSearch Search
            => VMethods.Search;

        public void unary_shift_v128_embed_imm8()
        {
            var w = w128;
            using var dst = AsmCaseWriter();
            iter(VImmTestCases.V128UnaryShifts, m =>  check_unary_shift(m, w, dst));
            check_vbsll_imm(w,dst);
        }

        public void unary_shift_v256_embed_imm8()
        {
            var w = w256;
            using var dst = AsmCaseWriter();
            iter(VImmTestCases.V256UnaryShifts, m => check_unary_shift(m, w, dst));
            check_vbsll_imm(w,dst);
        }

        public void check_blend_imm()
        {
            using var dst = AsmCaseWriter();

            check_blend_imm(dst);            

        }

        byte[] Immediates => new byte[]{1,2,3,4};

        BoxedNumber one(Type t) => BoxedNumber.Define(1).Convert(t);

        void check_unary_shift(MethodInfo src, W128 w, StreamWriter dst)
        {
            var svc = IdentityReflector.Service;
            Claim.require(src.IsVectorized(w));
            Claim.require(svc.AcceptsVector(src,0,w));
            Claim.require(src.AcceptsImmediate(1, ImmRefinementKind.Unrefined));
            Claim.eq(ImmFunctionClass.UnaryImm8, src.ImmFunctionClass(ImmRefinementKind.Unrefined));

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);
            check_imm(src, w, tVector, dst);
        }

        void check_imm(MethodInfo src, W128 w, Type tVector, StreamWriter dst)
        {            
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = Dynamic.CreateUnaryOp(w, src, imm).Require();
                var vOutput = method.Invoke(vones);
                var id = src.Identify().WithImm8(imm);
                var capture = AsmCheck.Capture(id, method).Require();
                AsmCheck.WriteAsm(capture,dst);
            }
        }

        void check_vbsll_imm(W128 w, StreamWriter dst)
        {   const byte imm8 = 9;

            var dynamics = FunctionDynamic.Service;
            var name = nameof(gvec.vbsll);
            var src = typeof(gvec).DeclaredMethods().WithName(name).OfKind(K.v128).Single();
            var id = Z0.Identity.identify(src);
            var f = Dynop.EmbedVUnaryOpImm(K.vk128<uint>(), id, src, imm8);
            var method = dynamics.Method(dynamics.Handle(f.Target));
            Claim.eq(method.Name, name);

            var capture = AsmCheck.Capture(id, f).Require();
            AsmCheck.WriteAsm(capture,dst);
        }

        void check_vbsll_imm(W256 w, StreamWriter dst)
        {   const byte imm8 = 4;

            var dynamics = FunctionDynamic.Service;
            var name = nameof(dvec.vbsll);
            var vKind = K.vk256<uint>();
            var src = typeof(dvec).DeclaredMethods().WithName(name).OfKind(vKind).Single();
            var id = Z0.Identity.identify(src);
            var f = Dynop.EmbedVUnaryOpImm(vKind, id, src, imm8);
            var method = dynamics.Method(dynamics.Handle(f.Target));
            Claim.eq(method.Name, name);

            var capture = AsmCheck.Capture(id, f).Require();
            AsmCheck.WriteAsm(capture,dst);
        }

        void check_unary_shift(MethodInfo src, W256 w, StreamWriter dst)
        {
            var svc = IdentityReflector.Service;
            Claim.require(src.IsVectorized(w));
            Claim.require(svc.AcceptsVector(src,0,w));
            Claim.require(src.AcceptsImmediate(1,ImmRefinementKind.Unrefined));
            Claim.eq(ImmFunctionClass.UnaryImm8, src.ImmFunctionClass(ImmRefinementKind.Unrefined));

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);
            check_imm(src,w,tVector, dst);
        }

        void check_imm(MethodInfo src, W256 w, Type tVector, StreamWriter dst)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});

            foreach(var imm in Immediates)
            {
                var method = Dynamic.CreateUnaryOp(w, src, imm).Require();
                var vOutput = method.Invoke(vones);
                var id = src.Identify().WithImm8(imm);
                var capture = AsmCheck.Capture(id, method).Require();
                AsmCheck.WriteAsm(capture,dst);
            }            
        }

        void check_blend_imm(StreamWriter dst)
        {
            var w = w256;
            var name = nameof(dvec.vblend8x16);
            var imm = (byte)Blend8x16.LRLRLRLR;
            var vKind = K.vk256<ushort>();
            var src = typeof(dvec).DeclaredMethods().WithName(name).OfKind(vKind).WithParameterType<byte>().Single();

            var injector = AsmCheck.Dynamic.BinaryInjector<ushort>(w);
            var x = Random.CpuVector<ushort>(w);
            var y = Random.CpuVector<ushort>(w);            
            var f = injector.EmbedImmediate(src,imm);
            var v1 = f.DynamicOp.Invoke(x,y);
            var captured = AsmCheck.Capture(f.Id, f).Require();
            var asm = AsmCheck.Decoder.Decode(captured).Require();    
            AsmCheck.WriteAsm(asm,dst);            
            
            var g = Dynamic.EmitFixedBinary<Fixed256>(AsmCheck[Main], asm.Code);
            
            var v2 = g(x,y).ToVector<ushort>();
            Claim.veq(v1,v2);
        }

        void check_cell_type(Type tVector, W128 w)
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
            else
                Claim.Fail();
        }

        void check_cell_type(Type tVector, W256 w)
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
            else
                Claim.Fail();
        }
    }
}