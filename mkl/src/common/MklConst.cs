//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
    using System.Security;
    
    [SuppressUnmanagedCodeSecurity]
    static class MklCommon
    {
        internal const CallingConvention Cdecl = CallingConvention.Cdecl;

    }
}