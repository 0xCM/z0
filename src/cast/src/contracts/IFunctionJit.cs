//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    public interface IFunctionInfo
    {
        ByteSize Size(MethodInfo src)        
            => FunctionInfo.size(src);
    }

    public readonly struct FunctionInfo : IFunctionInfo
    {
        /// <summary>
        /// Returns the size of the method, if known; otherwise, returns the monoidal zero
        /// </summary>
        /// <param name="src">The source method</param>
        public static ByteSize size(MethodInfo src)
            => src.Tag<SizeAttribute>().MapValueOrDefault(a => a.Size, ByteSize.Empty);
    }
    
    public interface IFunctionJit
    {
        /// <summary>
        /// Jits the source method and confers its size, if specified
        /// </summary>
        /// <param name="src">The method to jit</param>
        /// <param name="size">The method size, if specified</param>
        LocatedMethod Jit(MethodInfo src, int? size = null)
            => FunctionJit.jit(src, size);

        IntPtr Jit(Delegate src)
            => FunctionJit.jit(src);

        DynamicPointer Jit(DynamicDelegate src)
            => FunctionJit.jit(src);

        DynamicPointer Jit<D>(DynamicDelegate<D> src)            
            where D : Delegate
                => FunctionJit.jit(src);
    }
}