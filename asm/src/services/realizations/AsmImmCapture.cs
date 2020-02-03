//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    static class AsmImmCapture
    {
        public static IAsmImmCapture UnaryCapture(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => AsmImmUnaryCapture.Create(context,src,baseid);

        public static IAsmImmCapture BinaryCapture(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => AsmImmBinaryCapture.Create(context,src,baseid);

    }

    abstract class AsmImmCapture<T> : IAsmImmCapture
        where T : AsmImmCapture<T>
    {
        public IAsmContext Context {get;}
        
        protected readonly MethodInfo Method;

        protected readonly OpIdentity BaseId;

        protected readonly IAsmDecoder Decoder;


        [MethodImpl(Inline)]
        protected AsmImmCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
        {            
            this.Context = context;
            this.Method = method;
            this.BaseId = baseid;
            this.Decoder = context.Decoder();
        }

        public abstract AsmFunction Capture(byte imm8);
    }    

    sealed class AsmImmUnaryCapture : AsmImmCapture<AsmImmUnaryCapture>
    {
        [MethodImpl(Inline)]
        public static IAsmImmCapture Create(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new AsmImmUnaryCapture(context.WithEmptyClrIndex(), src,baseid);

        [MethodImpl(Inline)]
        AsmImmUnaryCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
            : base(context,method,baseid)
        {            

        }

        public override AsmFunction Capture(byte imm)
            => Decoder.DecodeFunction(DynopImm.UnaryOp(HK.vk(), Method, BaseId, imm));

    }

    sealed class AsmImmBinaryCapture : AsmImmCapture<AsmImmBinaryCapture>
    {
        [MethodImpl(Inline)]
        public static IAsmImmCapture Create(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new AsmImmBinaryCapture(context.WithEmptyClrIndex(), src,baseid);

        [MethodImpl(Inline)]
        AsmImmBinaryCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
            : base(context,method,baseid)
        {            

        }

        public override AsmFunction Capture(byte imm)
            => Decoder.DecodeFunction(DynopImm.BinaryOp(HK.vk(), Method, BaseId, imm));

    }

}