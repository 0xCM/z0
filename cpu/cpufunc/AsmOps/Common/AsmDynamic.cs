
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    
    using static zfunc;


    public readonly ref struct AsmDynamic
    {
        public static AsmDynamic Create(params byte[] code)
            => new AsmDynamic(code);

        public static AsmDynamic Create(ReadOnlySpan<byte> code)
            => new AsmDynamic(code);

        readonly MemoryBuffer code;

        readonly string name;

        readonly long pCode;

        public AsmDynamic(ReadOnlySpan<byte> code, string name  = null)
        {
            this.code = MemoryBuffer.Alloc(code);
            this.name = name ?? "anon";
            this.pCode = (long)OS.Liberate(code);
        }

        public void Dispose()
        {
            code.Dispose();
        }

        public AsmBinOp<T> BinOp<T>()
            where T : unmanaged
        {
            return AsmDelegate.CreateBinOp<T>(pCode,name);
            // var t = typeof(T);
            // var argTypes = new Type[]{t,t};
            // var returnType = t;
            // var method = new DynamicMethod(name, returnType, argTypes, t.Module);            
            // var g = method.GetILGenerator();
            // g.Emit(OpCodes.Ldarg_0);
            // g.Emit(OpCodes.Ldarg_1);
            // g.Emit(OpCodes.Ldc_I8, pCode);
            // g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            // g.Emit(OpCodes.Ret);
            // return (AsmBinOp<T>)method.CreateDelegate(typeof(AsmBinOp<T>));
        }

    }


}