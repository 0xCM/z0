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
        public static IEnumerable<AsmFunction> UnaryFunctions(MethodInfo method, Moniker id, params byte[] immediates)
        {
            var builder = AsmServices.FunctionBuilder();
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var d in UnaryDelegates(method, id, immediates))
                yield return AsmDecoder.function(d.Id, d, buffer.Clear());
        }

        static IEnumerable<DynamicDelegate> UnaryDelegates(MethodInfo method, Moniker id, params byte[] immediates)
        {
            var parameters = method.GetParameters().ToArray();            
            var optype = parameters[0].ParameterType;
            var width = optype.Width();
            var celltype = optype.GetGenericArguments()[0];
            
            var factory = width switch{
                FixedWidth.W128 => Dynop.unaryfactory(HK.vk128(), id, method, celltype),
                FixedWidth.W256 => Dynop.unaryfactory(HK.vk256(), id, method, celltype),
                _ =>throw new NotSupportedException(width.ToString())
            };
            
            foreach(var imm in immediates)            
                yield return factory(imm);                    
        }                    
        
        public static AsmFunction capture<T>(IVUnaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return AsmDecoder.function(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }

        public static AsmFunction BinaryFunction<T>(IVBinaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return AsmDecoder.function(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }

        public static AsmFunction UnaryFunction<T>(IVUnaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return AsmDecoder.function(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }

        public static AsmFunction BinaryFunction<T>(IVBinaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return AsmDecoder.function(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }    
    }
}