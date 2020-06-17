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

    public readonly struct MemberCil : IMemberCil
    {
        public static IMemberCil Service => default(MemberCil);

        [MethodImpl(Inline)]
        public CilBody ExtractCil(DynamicMethod src)
            => CilBody.Define(src.Name, bytes(src), src.GetMethodImplementationFlags());

        [MethodImpl(Inline)]
        public CilBody ExtractCil(MethodInfo src)
            => CilBody.Define(src.Name,src.GetMethodBody().GetILAsByteArray(), src.GetMethodImplementationFlags());

        [MethodImpl(Inline)]
        public CilBody ExtractCil(DynamicDelegate src)
            => ExtractCil(src.TargetMethod);

        [MethodImpl(Inline)]
        public CilBody ExtractCil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => ExtractCil(src.Untyped);

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

    public interface IMemberCil : IService
    {
        [MethodImpl(Inline)]
        CilBody ExtractCil(DynamicMethod src)
            => MemberCil.Service.ExtractCil(src);

        [MethodImpl(Inline)]
        CilBody ExtractCil(MethodInfo src)
            => MemberCil.Service.ExtractCil(src);

        [MethodImpl(Inline)]
        CilBody ExtractCil(DynamicDelegate src)
            => MemberCil.Service.ExtractCil(src);

        [MethodImpl(Inline)]
        CilBody ExtractCil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => MemberCil.Service.ExtractCil(src);
    }
}