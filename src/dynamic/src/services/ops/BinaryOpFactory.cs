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

    public readonly struct BinaryOpFactory
    {        
        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T>(string name, in BinaryCode code)
            where T : unmanaged
                => create<T>(identify<T>(name), code);

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T,K>(K kind, in BinaryCode code, bool generic)
            where K : unmanaged, IOpKind
            where T : unmanaged
                => emit<T>(identify<T,K>(kind, generic), Addressable.liberate(code).Ref);

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T>(OpIdentity id, in BinaryCode code)
            => emit<T>(id, Addressable.liberate(code).Ref);

        static OpIdentity identify<T,K>(K k, bool generic)
            where K : unmanaged, IOpKind
            where T : unmanaged
        {
            var operand = Identities.Services.Diviner.Identify(typeof(T));
            return OpIdentityBuilder.build(k.KindId, Numeric.kind<T>(),generic);            
        }

        static OpIdentity identify<T>(string name)
        {
            var operand = Identities.Services.Diviner.Identify(typeof(T));
            return OpIdentityParser.Service.Parse($"{name}_({operand},{operand})");
        }

        static BinaryOp<T> emit<T>(OpIdentity id, in Ref target)
        {   
            var tFunc = typeof(BinaryOp<T>);
            var tOperand = typeof(T);
            var args = sys.array(tOperand, tOperand);
            var method = new DynamicMethod(id, tOperand, args, tFunc.Module);                
            var g = method.GetILGenerator();
            var address = MemoryAddress.from(target);
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);                
            g.Emit(OpCodes.Ldc_I8, address);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tOperand, args);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)FixedDelegate.Define(id, address, method, method.CreateDelegate(tFunc));
        }        
    }
}