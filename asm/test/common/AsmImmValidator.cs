//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    readonly struct AsmImmBinOpValidator128<T>: IDisposable, IAsmService
        where T : unmanaged
    {

        public IAsmContext Context {get;}

        readonly IAsmExecBuffer AsmBuffer;

        readonly IVEmitter128<T> RandomEmitter {get;}

        readonly IAsmImmBuilder AsmProducer;

        public AsmImmBinOpValidator128(IAsmContext context)
        {
            this.Context = context;
            this.AsmBuffer = AsmExecBuffer.Create();
            this.RandomEmitter = context.Random.VectorEmitter<T>(n128);
            this.AsmProducer = context.ImmBuilder(HK.vk128(), n1);

        }


        public void Validate(MethodInfo method, byte imm)
        {
            var x = RandomEmitter.Invoke();
            var y = RandomEmitter.Invoke();
            var asm = AsmProducer.CreateFunction(method, imm);
            var f = AsmBuffer.BinaryOp(n128, asm.Code);
            var z = f(x.ToFixed(), y.ToFixed()).ToVector<T>();
            



            //var z1 = dynop.DynamicOp;
            // var z2 = f(x.ToFixed(), y.ToFixed()).ToVector<T>();
            
            


            // var f = buffer.BinaryOp<Fixed128>(asm.Code);
            // Claim.eq(z1,z2);
        }

        


        public void Dispose()
        {
            AsmBuffer?.Dispose();
        }
    }

}   