//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    public interface IImmSpecializer : IService
    {
        Option<AsmFunction> UnaryOp(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, byte imm);

        AsmFunction[] UnaryOps(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, params byte[] imm);

        Option<AsmFunction> BinaryOp(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, byte imm);         

        AsmFunction[] BinaryOps(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, params byte[] imm);         

        Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver128Api<T> resolver, byte imm)
            where T : unmanaged;        

        AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver128Api<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver256Api<T> resolver, byte imm)
            where T : unmanaged;                    

        AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver256Api<T> resolver, params byte[] imm)
            where T : unmanaged;

        Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver128Api<T> resolver, byte imm)
            where T : unmanaged;        

        AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver128Api<T> resolver, params byte[] imm)
            where T : unmanaged;            

        Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver256Api<T> resolver, byte imm)
            where T : unmanaged;        

        AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver256Api<T> resolver, params byte[] imm)
            where T : unmanaged;            

    }
}