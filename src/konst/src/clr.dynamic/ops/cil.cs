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

    using static Part;

    partial struct ClrDynamic
    {
        [MethodImpl(Inline), Op]
        public static CilMethod cil(DynamicMethod src)
        {
            var flags = src.GetMethodImplementationFlags();
            var uri = OpUri.located(ApiQuery.hosturi(src.DeclaringType), src.Name, src.Identify());
            MemoryAddress address = pointer(src);
            return new CilMethod(src.MetadataToken, address, uri, src.ResolveSignature(), cilbytes(src), flags);
        }

        [MethodImpl(Inline), Op]
        public static CilMethod cil(DynamicDelegate src)
            => cil(src.Target);

        [MethodImpl(Inline), Op]
        public static CilMethod cil(MemoryAddress @base, OpUri uri, MethodInfo src)
            => new CilMethod(src.MetadataToken, @base, uri, src.ResolveSignature(), src.GetMethodBody().GetILAsByteArray(), src.GetMethodImplementationFlags());

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        [MethodImpl(Inline), Op]
        static byte[] cilbytes(DynamicMethod src)
        {
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null)
                throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }
    }
}