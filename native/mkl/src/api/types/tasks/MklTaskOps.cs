//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    static class MklTaskOps
    {
        [MethodImpl(Inline)]
        public static void Set<T>(this VslSSTaskHandle<T> task, VslSSTaskParameter param, ref int value, [CallerFilePath]string file = null, [CallerLineNumber]int? line = null)
            where T : unmanaged
                => VSL.vsliSSEditTask(task, param, ref value).AutoThrow();

        [MethodImpl(Inline)]
        public static void Set<T>(this VslSSTaskHandle<T> task, VslSSTaskParameter param, ref double value, [CallerFilePath]string file = null, [CallerLineNumber]int? line = null)
            where T : unmanaged
            => VSL.vsldSSEditTask(task, param, ref value).AutoThrow(file,line);

        [MethodImpl(Inline)]
        public static void Set<T>(this VslSSTaskHandle<T> task, VslSSTaskParameter param, ref T value, [CallerFilePath]string file = null, [CallerLineNumber]int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
               VSL.vslsSSEditTask(task, param, ref memory.float32(ref value)).AutoThrow(file,line);
            else if(typeof(T) == typeof(double))
                VSL.vsldSSEditTask(task, param, ref memory.float64(ref value)).AutoThrow(file,line);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        public static void Compute(this VslSSTaskHandle<float> task, VslSSComputeRoutine routine, VslSSComputeMethod method, [CallerFilePath]string file = null, [CallerLineNumber]int? line = null)
            => VSL.vslsSSCompute(task, routine, method).AutoThrow(file,line);

        [MethodImpl(Inline)]
        public static void Compute(this VslSSTaskHandle<double> task, VslSSComputeRoutine routine, VslSSComputeMethod method, [CallerFilePath] string file = null, [CallerLineNumber]int? line = null)
            => VSL.vsldSSCompute(task, routine, method).AutoThrow(file,line);

        [MethodImpl(Inline)]
        public static void Compute<T>(this VslSSTaskHandle<T> task, VslSSComputeRoutine routine, VslSSComputeMethod method, [CallerFilePath] string file = null, [CallerLineNumber]int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                VSL.vslsSSCompute(task, routine, method).AutoThrow(file, line);
            else if(typeof(T) == typeof(double))
                VSL.vsldSSCompute(task, routine, method).AutoThrow(file, line);
            else
                throw Unsupported.define<T>();
        }
   }
}