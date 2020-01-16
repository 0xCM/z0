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

    public static class ImmResolutionX
    {
        public static AsmCodeSet ExtractCode(this DynamicDelegate f, Moniker id, byte[] buffer)
            => NativeReader.read(f, buffer).CodeSet(id, f.CilFunc());

        public static AsmCodeSet EmbedImmediate<T>(this IVUnaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            Span<byte> buffer = new byte[500];
            return NativeReader.read(f, buffer).CodeSet(moniker.WithImm(imm8), f.CilFunc());
        }

        public static AsmCodeSet EmbedImmediate<T>(this IVBinaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            Span<byte> buffer = new byte[500];
            return NativeReader.read(f, buffer).CodeSet(moniker.WithImm(imm8), f.CilFunc());
        }

        public static AsmCodeSet EmbedImmediate<T>(this IVUnaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            Span<byte> buffer = new byte[500];
            return NativeReader.read(f, buffer).CodeSet(moniker.WithImm(imm8), f.CilFunc());
        }

        public static AsmCodeSet EmbedImmediate<T>(this IVBinaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            Span<byte> buffer = new byte[500];
            return NativeReader.read(f, buffer).CodeSet(moniker.WithImm(imm8), f.CilFunc());
        }

        public static IEnumerable<AsmCodeSet> EmbedImmediates<T>(this IVUnaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select svc.EmbedImmediate(imm);

        public static IEnumerable<AsmCodeSet> EmbedImmediates<T>(this IVUnaryImm8Resolver256<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select svc.EmbedImmediate(imm);

        public static IEnumerable<AsmCodeSet> EmbedImmediates<T>(this IVBinaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select svc.EmbedImmediate(imm);


    }

}