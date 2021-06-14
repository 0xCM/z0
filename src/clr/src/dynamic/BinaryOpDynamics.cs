//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct BinaryOpDynamics
    {
        const NumericKind Closure = UnsignedInts;

        public static unsafe DynamicOp<BinaryOp<T>> dynop<T>(Identifier name, ReadOnlySpan<byte> f)
        {
            var emitted = emit<T>(name, (MemoryAddress)Buffers.liberate(f), out var method);
            return (method,emitted);
        }

        [Op, Closures(Closure)]
        public static void eval<T>(Identifier name, ReadOnlySpan<byte> f, ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
        {
            var binop = create<T>(name,f);
            var count = dst.Length;
            for(var i=0; i<count; i++)
                seek(dst,i) = binop(skip(a,i), skip(b,i));
        }

        [MethodImpl(Inline)]
        public static T eval<T>(Identifier name, ReadOnlySpan<byte> f, T x, T y)
            where T : unmanaged
        {
            var binop = create<T>(name, f);
            return binop(x,y);
        }
        public static unsafe BinaryOp<T> binop<T>(Identifier name, byte* pCode)
        {
            var emitted = emit<T>(name, (MemoryAddress)pCode, out var method);
            return emitted;
        }

        [Op, Closures(UInt64k)]
        public static unsafe BinaryOp<T> create<T>(OpIdentity id, ReadOnlySpan<byte> code)
            => emit<T>(id.Format(), Buffers.liberate(code), out var _);

        [Op, Closures(UInt64k)]
        public static unsafe BinaryOp<T> create<T>(Identifier name, ReadOnlySpan<byte> f)
            => emit<T>(name, (MemoryAddress)Buffers.liberate(f), out var method);

        static unsafe BinaryOp<T> emit<T>(Identifier name, MemoryAddress f, out DynamicMethod method)
        {
            var tFunc = typeof(BinaryOp<T>);
            var tOperand = typeof(T);
            var args = sys.array(tOperand, tOperand);
            method = new DynamicMethod(name, tOperand, args, tFunc.Module);
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, f);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tOperand, args);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)CellDelegate.define(name, f, method, method.CreateDelegate(tFunc));
        }
    }
}