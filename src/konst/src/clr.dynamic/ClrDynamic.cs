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

    [ApiHost]
    public readonly struct ClrDynamic
    {
        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        public static IntPtr pointer(DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        /// <summary>
        /// Creates a dynamic pointer from an untyped dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="handle">A proxy for the unmanaged pointer</param>
        [MethodImpl(Inline), Op]
        public static DynamicPointer pointer(DynamicDelegate src)
            => new DynamicPointer(src, pointer(src.TargetMethod));

        /// <summary>
        /// Creates a dynamic pointer from a generic dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="handle">A proxy for the unmanaged pointer</param>
        /// <typeparam name="D">The delegate type</typeparam>
        public static DynamicPointer pointer<D>(DynamicDelegate<D> src)
            where D : Delegate
                => pointer(src);

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        [MethodImpl(Inline), Op]
        public static byte[] bytes(DynamicMethod src)
        {
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null)
                throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }

        /// <summary>
        /// Returns the size of the method, if known; otherwise, returns the monoidal zero
        /// </summary>
        /// <param name="src">The source method</param>
        static ByteSize size(MethodInfo src)
            => src.Tag<SizeAttribute>().MapValueOrDefault(a => (ByteSize)a.Size, ByteSize.Empty);

        [MethodImpl(Inline), Op]
        public static CilMethod cil(DynamicMethod src)
            => new CilMethod(src.Name, bytes(src), src.GetMethodImplementationFlags());

        [MethodImpl(Inline), Op]
        public static CilMethod cil(MethodInfo src)
        {
            var body = src.GetMethodBody()?.GetILAsByteArray() ?? sys.empty<byte>();
            return new CilMethod(src.Name, body, src.GetMethodImplementationFlags());
        }

        [MethodImpl(Inline), Op]
        public static CilMethod cil(MemoryAddress @base, OpUri uri, MethodInfo src)
            => new CilMethod(@base, uri, src.GetMethodBody().GetILAsByteArray(), src.GetMethodImplementationFlags());

        [MethodImpl(Inline), Op]
        public static CilMethod cil(DynamicDelegate src)
            => cil(src.TargetMethod);

        [MethodImpl(Inline)]
        public static CilMethod cil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => cil(src.Untyped);

        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle handle(DynamicMethod src)
        {
            var getMethodDescriptorInfo = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return (RuntimeMethodHandle)getMethodDescriptorInfo.Invoke(src, null);
        }

        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle handle(MethodInfo src)
            => src.MethodHandle;

        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle handle(Delegate src)
            => src.Method.MethodHandle;

        [MethodImpl(Inline), Op]
        public static MethodBase method(RuntimeMethodHandle src)
             => MethodBase.GetMethodFromHandle(src);

        [MethodImpl(Inline), Op]
        public static LocatedMethod jit(IdentifiedMethod src, int? size = null)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return new LocatedMethod(src.Id, src.Method, (MemoryAddress)src.MethodHandle.GetFunctionPointer(), size);
        }

        [MethodImpl(Inline)]
        public static MemoryAddress jit(ApiMember src)
        {
            RuntimeHelpers.PrepareMethod(src.Method.MethodHandle);
            return src.Method.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline), Op]
        static LocatedMethod jit(MethodInfo src, int? size = null)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return new LocatedMethod(OpIdentity.Empty, src, (MemoryAddress)src.MethodHandle.GetFunctionPointer(), size);
        }

        /// <summary>
        /// Jits the method declared by a specified type
        /// </summary>
        /// <param name="src">The source type</param>
        public static LocatedMethod[] jit(Type src)
            => src.DeclaredMethods().Select(m => jit(m, size(m)));

        [MethodImpl(Inline), Op]
        public static IntPtr jit(Delegate src)
        {
            RuntimeHelpers.PrepareDelegate(src);
            return src.Method.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline), Op]
        public static DynamicPointer jit(DynamicDelegate src)
        {
            RuntimeHelpers.PrepareDelegate(src.DynamicOp);
            return DynamicPointer.From(src);
        }

        [MethodImpl(Inline)]
        public static DynamicPointer jit<D>(DynamicDelegate<D> src)
            where D : Delegate
                => jit(src.Untyped);
    }
}