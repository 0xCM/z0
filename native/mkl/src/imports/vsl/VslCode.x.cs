//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;
	using System.Runtime.CompilerServices;

    using static Part;

    public static class VslCodeX
    {
        [MethodImpl(Inline)]
        public static bool IsError(this VslRngStatus status)
            => status != VslRngStatus.VSL_ERROR_OK;

        [MethodImpl(Inline)]
        public static bool IsError(this VslSSStatus status)
            => status != VslSSStatus.VSL_SS_OK;

        [MethodImpl(Inline)]
        public static bool ThrowOnError(this VslRngStatus status, [CallerFilePath]string file = null, [CallerLineNumber]int? line = null)
            =>!status.IsError() ? false : throw new Exception($"{file} line {line}: VSL RNG Error Code {status}");

        [MethodImpl(Inline)]
        public static bool AutoThrow(this VslSSStatus status, [CallerFilePath]string file = null, [CallerLineNumber]int? line = null)
            =>!status.IsError() ? false : throw new Exception($"{file} line {line}: VSL SS Error Code {status}");
    }
}