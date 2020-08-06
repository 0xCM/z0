//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FunctionCil : IFunctionCil
    {
        public static FunctionCil Service => default;

        [MethodImpl(Inline)]
        public static CilCode extract(DynamicMethod src)
            => CilCode.define(src.Name, bytes(src), src.GetMethodImplementationFlags());

        [MethodImpl(Inline)]
        public static CilCode extract(MethodInfo src)
            => CilCode.define(src.Name,src.GetMethodBody().GetILAsByteArray(), src.GetMethodImplementationFlags());

        [MethodImpl(Inline)]
        public static CilCode extract(DynamicDelegate src)
            => extract(src.TargetMethod);

        [MethodImpl(Inline)]
        public static CilCode extract<D>(DynamicDelegate<D> src)
            where D : Delegate
                => extract(src.Untyped);

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        internal static byte[] bytes(DynamicMethod src)
        {            
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null) throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }
    }
}