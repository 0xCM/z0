//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;

    using static VslRngMethod;

    public enum VslGaussianMethod
    {
        BoxMuller1 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER,

        BoxMuller2 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2,

        IDCF = VSL_RNG_METHOD_GAUSSIAN_ICDF,
    }
}