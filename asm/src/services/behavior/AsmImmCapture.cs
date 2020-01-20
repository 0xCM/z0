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

    public static class AsmImmCapture
    {
        public static IEnumerable<AsmCodeSet> unary(MethodInfo method, Moniker id, params byte[] immediates)
        {
            var parameters = method.GetParameters().ToArray();            
            var optype = parameters[0].ParameterType;
            var width = optype.SegmentedWidth();
            var celltype = optype.GetGenericArguments()[0];
            var factory = VectorImm.unaryfactory(width, method, celltype); 
            var buffer = new byte[1024];
            foreach(var imm in immediates)            
            {    
                buffer.Clear();
                var @delegate = factory(imm);                    
                yield return AsmDecoder.decode(@delegate, id.WithImm(imm), buffer);
            }
        }                    

        public static AsmCodeSet capture<T>(IVUnaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            Span<byte> buffer = new byte[500];
            return AsmDecoder.decode(NativeReader.read(f, buffer), moniker.WithImm(imm8), f.CilFunc());
        }

        public static AsmCodeSet capture<T>(IVBinaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            Span<byte> buffer = new byte[500];
            return AsmDecoder.decode(NativeReader.read(f, buffer),moniker.WithImm(imm8), f.CilFunc());
        }

        public static AsmCodeSet capture<T>(IVUnaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            Span<byte> buffer = new byte[500];
            return AsmDecoder.decode(NativeReader.read(f, buffer),moniker.WithImm(imm8), f.CilFunc());
        }

        public static AsmCodeSet capture<T>(IVBinaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            Span<byte> buffer = new byte[500];
            return AsmDecoder.decode(NativeReader.read(f, buffer),moniker.WithImm(imm8), f.CilFunc());
        }

    }

}