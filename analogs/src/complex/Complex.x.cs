//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static root;

    public static class ComplexExtensions
    {
        public static Complex<int> ToComplexNumber(this (int re, int im) x)
            => x;

        public static Complex<double> ToComplexNumber(this (double re, double im) x)
            => x;

        public static Complex<float> ToComplexNumber(this (float re, float im) x)
            => x;
    }
}