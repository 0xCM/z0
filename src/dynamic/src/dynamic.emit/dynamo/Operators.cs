//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    public readonly partial struct Dynamo
    {
        [ApiHost(ApiNames.DynamicOperators)]
        public readonly struct Operators
        {
            public static UnaryOp<T> emit<T>(N1 n, ApiCodeBlock src, MemoryAddress dst)
                where T : unmanaged
            {
                var tOperand = typeof(T);
                var tResult = typeof(T);
                var tOperator = typeof(UnaryOp<T>);
                var builder = DynamicOperators.create(n);
                return (UnaryOp<T>)builder.Emit(src.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
            }

            public static BinaryOp<T> emit<T>(N2 n, ApiCodeBlock src, MemoryAddress dst)
                where T : unmanaged
            {
                    var tOperand = typeof(T);
                    var tResult = typeof(T);
                    var tOperator = typeof(BinaryOp<T>);
                var builder = DynamicOperators.create(n);
                return (BinaryOp<T>)builder.Emit(src.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
            }

            public static TernaryOp<T> emit<T>(N3 n, ApiCodeBlock src, MemoryAddress dst)
                where T : unmanaged
            {
                var tOperand = typeof(T);
                var tResult = typeof(T);
                var tOperator = typeof(TernaryOp<T>);
                var builder = DynamicOperators.create(n);
                return (TernaryOp<T>)builder.Emit(src.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
            }
        }

        readonly struct DynamicOperators
        {
            public static DynamicOperators create(N1 n)
                => new DynamicOperators(OpBodyEmitters.emitter(n));

            public static DynamicOperators create(N2 n)
                => new DynamicOperators(OpBodyEmitters.emitter(n));

            public static DynamicOperators create(N3 n)
                => new DynamicOperators(OpBodyEmitters.emitter(n));

            readonly IMethodBodyEmitter BodyEmitter;

            public DynamicOperators(IMethodBodyEmitter emitter)
            {
                BodyEmitter = emitter;
            }

            public CellDelegate Emit(OpIdentity id, Type functype, Type result, Type[] args, MemoryAddress dst)
            {
                var method = new DynamicMethod(id, result, args, functype.Module);
                var g = BodyEmitter.Emit(method);
                g.Emit(OpCodes.Ldc_I8, (long)dst);
                g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
                g.Emit(OpCodes.Ret);
                return CellDelegate.define(id, dst, method, method.CreateDelegate(functype));
            }
        }

        readonly struct OpBodyEmitters
        {
            public static IMethodBodyEmitter emitter(N1 n)
                => new UnaryOpEmitter();

            public static IMethodBodyEmitter emitter(N2 n)
                => new BinaryOpEmitter();

            public static IMethodBodyEmitter emitter(N3 n)
                => new TernaryOpEmitter();
        }

        readonly struct UnaryOpEmitter : IMethodBodyEmitter
        {
            public ILGenerator Emit(DynamicMethod dst)
            {
                var g = dst.GetILGenerator();
                g.Emit(OpCodes.Ldarg_0);
                return g;
            }
        }

        readonly struct BinaryOpEmitter : IMethodBodyEmitter
        {
            public ILGenerator Emit(DynamicMethod dst)
            {
                var g = dst.GetILGenerator();
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                return g;
            }
        }

        readonly struct TernaryOpEmitter : IMethodBodyEmitter
        {
            public ILGenerator Emit(DynamicMethod dst)
            {
                var g = dst.GetILGenerator();
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.Emit(OpCodes.Ldarg_2);
                return g;
            }
        }

        public interface IMethodBodyEmitter
        {
            ILGenerator Emit(DynamicMethod dst);
        }
    }
}