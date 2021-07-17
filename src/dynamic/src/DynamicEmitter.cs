//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct DynamicEmitter
    {
        const NumericKind Closure = UInt64k;

        [Op, Closures(Closure)]
        public static unsafe Emitter<T> emitter<T>(Identifier name, byte* pCode)
            => emitter<T>(name, (MemoryAddress)pCode, out _);

        [Op, Closures(Closure)]
        public static unsafe Emitter<T> emitter<T>(OpIdentity id, ReadOnlySpan<byte> code)
            => emitter<T>(id.Format(), Buffers.liberate(code), out _);

        [Op, Closures(Closure)]
        public static unsafe Emitter<T> emitter<T>(Identifier name, ReadOnlySpan<byte> f)
            => emitter<T>(name, (MemoryAddress)Buffers.liberate(f), out _);

        [MethodImpl(Inline), Closures(Closure)]
        public static T eval<T>(Identifier name, ReadOnlySpan<byte> f)
            where T : unmanaged
                => emitter<T>(name, f)();

        static unsafe Emitter<T> emitter<T>(Identifier name, MemoryAddress address, out DynamicMethod method)
        {
            var tFunc = typeof(Emitter<T>);
            var tReturn = typeof(T);
            method = new DynamicMethod(name, tReturn, null, typeof(int).Module);
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, (long)address);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tReturn, null);
            g.Emit(OpCodes.Ret);
            return (Emitter<T>)CellDelegate.define(name, address, method, method.CreateDelegate(tFunc));
        }

        public static unsafe DynamicAction action(string name, ReadOnlySpan<byte> f)
            => action(name, Buffers.liberate(f));

        public static unsafe DynamicAction action(string name, MemoryAddress f)
        {
            var tFunc = typeof(Action);
            var method = new DynamicMethod(name, null, null, tFunc.Module);
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, f);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, null, null);
            g.Emit(OpCodes.Ret);
            return new DynamicAction(name, f, method, (Action)method.CreateDelegate(tFunc));
        }

        public static Func<T0,R> emit<T0,R>(ApiCodeBlock src, Span<byte> buffer, out Func<T0,R> fx)
        {
            fx = (Func<T0,R>)DynamicFunctions.create(n1).Emit(src.OpUri.OpId, functype:typeof(Func<T0,R>), result:typeof(R), args: array(typeof(T0)), buffer);
            return fx;
        }

        public static void emit<T>(N1 n, ApiCodeBlock code, MemoryAddress dst, out UnaryOp<T> fx)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(UnaryOp<T>);
            var builder = DynamicFunctions.create(n);
            fx = (UnaryOp<T>)builder.Emit(code.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
        }

        public static void emit<T>(N2 n, ApiCodeBlock code, MemoryAddress dst, out BinaryOp<T> fx)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(BinaryOp<T>);
            var builder = DynamicFunctions.create(n);
            fx = (BinaryOp<T>)builder.Emit(code.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
        }

        public static void emit<T>(N3 n, ApiCodeBlock code, MemoryAddress dst, out TernaryOp<T> fx)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(TernaryOp<T>);
            var builder = DynamicFunctions.create(n);
            fx = (TernaryOp<T>)builder.Emit(code.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
        }

        public static void emit<T0,T1,R>(MethodInfo src, bool calli, out Func<T0,T1,R> fx)
        {
            var args = new Type[]{typeof(T0), typeof(T1)};
            var returnType = typeof(R);
            var method = new DynamicMethod(src.Name, returnType, args, src.Module);
            var g = method.GetILGenerator();
            if(calli)
            {
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.EmitCall(OpCodes.Call, src, null);
                g.Emit(OpCodes.Ret);
            }
            else
            {
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, args);
                g.Emit(OpCodes.Ret);
            }

            fx = (Func<T0,T1,R>)method.CreateDelegate(typeof(Func<T0,T1,R>));
        }

        public static UnaryOp<T> unaryop<T>(BufferToken dst, ApiCodeBlock src)
            where T : unmanaged
        {
            try
            {
                return unaryop<T>(src.Id, dst.Load(src.Encoded));
            }
            catch(Exception e)
            {
                term.magenta($"Operator production for {src.Id} failed");
                term.magenta(src);
                term.error(e);
                return empty;
            }
        }

        [MethodImpl(Inline)]
        public static BinaryOp<T> binaryop<T>(BufferToken dst, ApiCodeBlock src)
            where T : unmanaged
        {
            try
            {
                return binaryop<T>(src.Id, dst.Load(src.Encoded));
            }
            catch(Exception e)
            {
                term.magenta($"Operator production for {src.Id} failed");
                term.magenta(src);
                term.error(e);
                return empty;
            }
        }

        [MethodImpl(Inline)]
        static BinaryOp<T> binaryop<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(BinaryOp<T>);
            return (BinaryOp<T>)emit(id, functype:tOperator, result:tResult, args: array(tOperand,tOperand), dst.Address);
        }

        [MethodImpl(Inline)]
        static UnaryOp<T> unaryop<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(UnaryOp<T>);
            return (UnaryOp<T>)emit(id, functype:tOperator, result:tResult, args: array(tOperand), dst.Address);
        }

        static CellDelegate emit(OpIdentity id, Type functype, Type result, Type[] args, MemoryAddress dst)
        {
            var method = new DynamicMethod(id, result, args, functype.Module);
            var g = method.GetILGenerator();
            switch(args.Length)
            {
                case 1:
                    g.Emit(OpCodes.Ldarg_0);
                break;
                case 2:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);
                break;
                case 3:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);
                    g.Emit(OpCodes.Ldarg_2);
                break;
                case 4:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);
                    g.Emit(OpCodes.Ldarg_2);
                    g.Emit(OpCodes.Ldarg_3);
                break;

            }
            g.Emit(OpCodes.Ldc_I8, (long)dst);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
            g.Emit(OpCodes.Ret);
            return CellDelegates.define(id, dst, method, method.CreateDelegate(functype));
        }

        static T empty<T>(T src)
            where T : unmanaged
                => default;

        static T empty<T>(T x, T y)
            where T : unmanaged
                => default;
    }
}