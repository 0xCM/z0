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

    [ApiHost]
    public readonly partial struct ClrDynamic
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static CilMethod cil(DynamicMethod src)
            => new CilMethod(src.Name, bytes(src), src.GetMethodImplementationFlags());

        [MethodImpl(Inline), Op]
        public static CilMethod cil(DynamicDelegate src)
            => cil(src.Target);

        [MethodImpl(Inline)]
        public static CilMethod cil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => cil(src.Untyped);

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
        public static LocatedMethod jit(IdentifiedMethod src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return new LocatedMethod(src.Id, src.Method, (MemoryAddress)src.MethodHandle.GetFunctionPointer());
        }

        [MethodImpl(Inline)]
        public static MemoryAddress jit(ApiMember src)
        {
            RuntimeHelpers.PrepareMethod(src.Method.MethodHandle);
            return src.Method.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline), Op]
        static LocatedMethod jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return new LocatedMethod(OpIdentity.Empty, src, (MemoryAddress)src.MethodHandle.GetFunctionPointer());
        }

        /// <summary>
        /// Jits the method declared by a specified type
        /// </summary>
        /// <param name="src">The source type</param>
        public static Index<LocatedMethod> jit(Type src)
            => src.DeclaredMethods().Select(m => jit(m));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemorySlots<I> slots<I>(Type src)
            where I : unmanaged
                => new MemorySlots<I>(slots(src));

        [MethodImpl(Inline), Op]
        public static MemorySlots slots(Type src)
            => jit(src).Map(m => new MemorySegment(m.Address, m.Size));

        [MethodImpl(Inline)]
        public static MemorySlots<E> slots<E,T>(T src)
            where E : unmanaged
                => slots<E>(typeof(T));

        [MethodImpl(Inline), Op]
        public static IntPtr jit(Delegate src)
        {
            RuntimeHelpers.PrepareDelegate(src);
            return src.Method.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline), Op]
        public static DynamicPointer jit(DynamicDelegate src)
        {
            RuntimeHelpers.PrepareDelegate(src.Operation);
            return pointer(src, pointer(src.Target));
        }

        [MethodImpl(Inline)]
        public static DynamicPointer jit<D>(DynamicDelegate<D> src)
            where D : Delegate
                => jit(src.Untyped);

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        [MethodImpl(Inline), Op]
        static byte[] bytes(DynamicMethod src)
        {
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null)
                throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }

        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        static IntPtr pointer(DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }
    }
}