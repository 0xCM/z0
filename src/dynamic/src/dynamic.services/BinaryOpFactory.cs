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

    using static Part;

    [ApiHost]
    public readonly struct BinaryOpFactory
    {
        [Op, Closures(UnsignedInts)]
        public static unsafe BinaryOp<T> create<T>(OpIdentity id, ReadOnlySpan<byte> code)
            => emit<T>(id.Format(), memory.liberate(code), out var _);

        public static unsafe BinaryOp<T> create<T>(Identifier name, ReadOnlySpan<byte> f)
        {
            var emitted = emit<T>(name, (MemoryAddress)memory.liberate(f), out var method);
            return emitted;
        }
            //=> create<T>(name, new BinaryCode(f.ToArray()));

        public static unsafe BinaryOp<T> create<K,T>(K kind, ReadOnlySpan<byte> code, bool generic)
            where K : unmanaged, IApiClass
                => emit<T>(identify<K,T>(kind, generic), (MemoryAddress)memory.liberate(code), out var _);

        public static unsafe DynamicOp<BinaryOp<T>> dynop<T>(Identifier name, byte* pCode)
        {
            var emitted = emit<T>(name, (MemoryAddress)pCode, out var method);
            return (method,emitted);
        }

        internal static Identifier identify<K,T>(K k, bool generic)
            where K : unmanaged, IApiClass
        {
            var operand = MultiDiviner.Service.Identify(typeof(T));
            return ApiIdentityBuilder.build(k.ClassId, Numeric.kind<T>(),generic).Format();
        }

        static Identifier identify<T>(string group)
        {
            var operand = MultiDiviner.Service.Identify(typeof(T));
            return ApiUri.opid($"{group}_({operand},{operand})").Format();
        }

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
            return (BinaryOp<T>)CellDelegates.define(name, f, method, method.CreateDelegate(tFunc));
        }
    }
}