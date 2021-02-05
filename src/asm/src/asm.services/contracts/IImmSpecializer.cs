//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    using static SFx;

    public interface IImmSpecializer
    {
        Option<AsmRoutine> UnaryOp(in CaptureExchange exchange, MethodInfo src, byte imm);

        Option<AsmRoutine> UnaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm);

        AsmRoutine[] UnaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8R[] imm);

        Option<AsmRoutine> BinaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm);

        AsmRoutine[] BinaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8R[] imm);

        Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, byte imm)
            where T : unmanaged;

        AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, byte imm)
            where T : unmanaged;

        AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, byte imm)
            where T : unmanaged;

        AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, byte imm)
            where T : unmanaged;

        AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged;
    }
}