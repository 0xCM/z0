//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class mkl
    {            
        [MethodImpl(Inline)]    
        internal static IntPtr Handle(this IMklTask src)
            => (src as MklTask);

        [MethodImpl(Inline)]
        public static IVslSSTask<float> sstask(int dim, float[] samples)        
            => VslSSTaskF32.Define(dim, samples);

        [MethodImpl(Inline)]
        public static IVslSSTask<double> sstask(int dim, double[] samples)        
            => VslSSTaskF64.Define(dim, samples);
    }
}