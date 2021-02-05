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

    /// <summary>
    /// Encloses a pointer to the native definition of a dynamic delegate
    /// </summary>
    public unsafe readonly struct DynamicPointer
    {
        readonly DynamicDelegate Op;

        public IntPtr Handle {get;}

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

        public Delegate Operation
            => Op.Operation;

        public MethodInfo Source
            => Op.Source;

        public MethodInfo Target
            => Op.Target;
    }
}