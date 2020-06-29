//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Reflection;

    public interface IImmSpecializer : IService
    {
        Option<AsmFunction> UnaryOp(in CaptureExchange exchange, MethodInfo src, byte imm);

        Option<AsmFunction> UnaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm);        

        AsmFunction[] UnaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8R[] imm);

        Option<AsmFunction> BinaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm);         

        AsmFunction[] BinaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8R[] imm);         

        Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, byte imm)
            where T : unmanaged;        

        AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, byte imm)
            where T : unmanaged;                    

        AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, byte imm)
            where T : unmanaged;        

        AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged;            

        Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, byte imm)
            where T : unmanaged;        

        AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged;
    }
}