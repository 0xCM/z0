//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;

    using static VslRngMethod;

    public enum VslGammaMethod
    {
        [MklCode("")]
        GNorm = VSL_RNG_METHOD_GAMMA_GNORM,

        [MklCode("")]
        GNormAccurate = VSL_RNG_METHOD_GAMMA_GNORM_ACCURATE
    }
}