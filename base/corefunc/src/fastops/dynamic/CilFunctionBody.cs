//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;

    public class CilFunctionBody
    {
        public static CilFunctionBody From(MethodInfo method)
        {
            return new CilFunctionBody
            {
                Name = method.Name,
                Data = method.GetMethodBody().GetILAsByteArray(),
                ImplSpec = method.GetMethodImplementationFlags()
            };
        }

        public static CilFunctionBody From(DynamicMethod method)
        {
            return new CilFunctionBody
            {
                Name = method.Name,
                Data = CilBytes(method),
                ImplSpec = method.GetMethodImplementationFlags()
            };
        }

        public static CilFunctionBody From(DynamicDelegate src)
            => From(src.DynamicMethod);
        
        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        static byte[] CilBytes(DynamicMethod src)
        {            
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null) throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }

        public string Name {get; private set;}        

        public byte[] Data {get; private set;}

        public MethodImplAttributes ImplSpec {get; private set;}    
    }
}