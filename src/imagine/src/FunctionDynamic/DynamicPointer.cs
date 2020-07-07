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

    /// <summary>
    /// Encloses a pointer to the native definition of a dynamic delegate
    /// </summary>
    public unsafe readonly struct DynamicPointer
    {
        readonly DynamicDelegate Op;

        public readonly IntPtr Handle;

        [MethodImpl(Inline)]
        public static DynamicPointer From(DynamicDelegate src)
            => new DynamicPointer(src, pointer(src.TargetMethod));

        [MethodImpl(Inline)]
        internal DynamicPointer(DynamicDelegate op, IntPtr handle)
        {
            Op = op;
            Handle = handle;
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

        public byte* BytePtr
        {
            [MethodImpl(Inline)]
            get => Handle.ToPointer<byte>();
        }
        
        public Delegate DynamicOp 
            => Op.DynamicOp;
        
        public MethodInfo SourceMethod
            => Op.SourceMethod;

        public MethodInfo DynamicMethod
            => Op.TargetMethod;
    }
}