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

    using static Konst;
    using static Control;

    public readonly struct BinaryOpEmitter
    {
        [MethodImpl(Inline)]
        public static BinaryOp<T> emit<T>(string name, Span<byte> code)   
            => BinaryOpEmitter<T>.emit(name, Spans.liberate(code));
        
        [MethodImpl(Inline)]
        public static BinaryOp<T> emit<T>(string name, BinaryCode code)
            => BinaryOpEmitter<T>.emit(name, Spans.liberate(span(code.Data)));
    }

    readonly struct BinaryOpEmitter<T>
    {
        public static BinaryOp<T> emit(string name, Span<byte> buffer)
        {   
            var tFunc = typeof(BinaryOp<T>);
            var tOperand = typeof(T);
            var args = Control.array(tOperand, tOperand);
            var idOpType = Identities.Services.Diviner.Identify(tOperand);
            var idMethod = OpIdentityParser.Service.Parse($"{name}_({idOpType},{idOpType})");

            var method = new DynamicMethod(idMethod, tOperand, args, tFunc.Module);                
            var g = method.GetILGenerator();
            var dst = MemoryAddress.From(head(buffer));
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);                
            g.Emit(OpCodes.Ldc_I8, dst);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tOperand, args);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)FixedDelegate.Define(idMethod, dst, method, method.CreateDelegate(tFunc));
        }        
    }
}