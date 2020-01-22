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
        public static IEnumerable<DynamicDelegate> UnaryDelegates(MethodInfo method, Moniker id, params byte[] immediates)
        {
            var parameters = method.GetParameters().ToArray();            
            var optype = parameters[0].ParameterType;
            var width = optype.Width();
            var celltype = optype.GetGenericArguments()[0];
            var factory = UnaryDelegateFactory(width, id, method, celltype); 
            foreach(var imm in immediates)            
                yield return factory(imm);                    
        }                    

        public static IEnumerable<AsmFunction> UnaryFunctions(MethodInfo method, Moniker id, params byte[] immediates)
        {
            var builder = AsmServices.FunctionBuilder();
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var d in UnaryDelegates(method, id, immediates))
                yield return AsmDecoder.function(d.Id, d, buffer.Clear());
        }
        
        public static AsmFunction capture<T>(IVUnaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var builder = AsmServices.FunctionBuilder();
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return builder.BuildFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }

        public static AsmFunction BinaryFunction<T>(IVBinaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var builder = AsmServices.FunctionBuilder();
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return builder.BuildFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }

        public static AsmFunction UnaryFunction<T>(IVUnaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var builder = AsmServices.FunctionBuilder();
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return builder.BuildFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }

        public static AsmFunction BinaryFunction<T>(IVBinaryImm8Resolver256<T> svc, byte imm8)
            where T : unmanaged
        {
            var builder = AsmServices.FunctionBuilder();
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            var buffer = new byte[NativeReader.DefaultBufferLen];
            return builder.BuildFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }
        
        static Func<byte,DynamicDelegate> UnaryDelegateFactory(FixedWidth w, Moniker id, MethodInfo src, Type seg)
        {
            switch(w)
            {
                case FixedWidth.W128:
                    return Dynop.unaryfactory(HK.vk128(), id, src, seg);
                case FixedWidth.W256:
                    return Dynop.unaryfactory(HK.vk256(), id, src, seg);
                default:
                    throw new NotSupportedException(w.ToString());
            }
        }

    }
}