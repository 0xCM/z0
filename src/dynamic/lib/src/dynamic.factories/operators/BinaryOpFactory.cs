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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe BinaryOp<T> create<T>(OpIdentity id, ReadOnlySpan<byte> code)
            where T : unmanaged
                => emit<T>(id, memory.liberate(code));

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T>(string name, ReadOnlySpan<byte> f)
            where T : unmanaged
                => create<T>(name, new BinaryCode(f.ToArray()));

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T>(string name, in BinaryCode code)
            where T : unmanaged
                => create<T>(identify<T>(name), code);

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T,K>(K kind, in BinaryCode code, bool generic)
            where K : unmanaged, IApiKey
            where T : unmanaged
                => emit<T>(identify<T,K>(kind, generic), Buffers.liberate(code).Ref);

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T>(OpIdentity id, in BinaryCode code)
            => emit<T>(id, Buffers.liberate(code).Ref);

        static OpIdentity identify<T,K>(K k, bool generic)
            where K : unmanaged, IApiKey
            where T : unmanaged
        {
            var operand = MultiDiviner.Service.Identify(typeof(T));
            return ApiIdentify.build(k.Id, NumericKinds.from<T>(),generic);
        }

        static OpIdentity identify<T>(string name)
        {
            var operand = MultiDiviner.Service.Identify(typeof(T));
            return OpIdentityParser.Service.Parse($"{name}_({operand},{operand})");
        }

        static BinaryOp<T> emit<T>(OpIdentity id, in SegRef target)
        {
            var tFunc = typeof(BinaryOp<T>);
            var tOperand = typeof(T);
            var args = sys.array(tOperand, tOperand);
            var method = new DynamicMethod(id, tOperand, args, tFunc.Module);
            var g = method.GetILGenerator();
            var address = target.BaseAddress;
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, address);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tOperand, args);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)CellDelegates.define(id, address, method, method.CreateDelegate(tFunc));
        }

        static unsafe BinaryOp<T> emit<T>(OpIdentity id, MemoryAddress f)
        {
            var tFunc = typeof(BinaryOp<T>);
            var tOperand = typeof(T);
            var args = sys.array(tOperand, tOperand);
            var method = new DynamicMethod(id, tOperand, args, tFunc.Module);
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, f);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tOperand, args);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)CellDelegates.define(id, f, method, method.CreateDelegate(tFunc));
        }
    }
}