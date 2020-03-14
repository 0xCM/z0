//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    readonly struct ImmUnaryCaptureService : IImmCapture
    {
        public IAsmContext Context {get;}
        
        readonly MethodInfo Method;

        readonly OpIdentity BaseId;

        readonly IAsmFunctionDecoder Decoder;

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture New(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new ImmUnaryCaptureService(context, src,baseid);

        [MethodImpl(Inline)]
        public ImmUnaryCaptureService(IAsmContext context, MethodInfo method, OpIdentity baseid)
        {            
            this.Context = context;
            this.Method = method;
            this.BaseId = baseid;
            this.Decoder = context.AsmFunctionDecoder();
        }

        public AsmFunction Capture(in OpExtractExchange exchange, byte imm)
        {
            var op = Dynop.EmitImmVUnaryOp(VK.vk(), Method, BaseId, imm);
            return Context.Decode(Decoder, exchange, op.Id, op);
        }
    }
}