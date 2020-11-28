//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    public readonly struct CheckBinaryPredSF<T> : ICheckSF<T,T,Bit32>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckBinaryPredSF(ITestContext context, bool xz = false)
        {
            Context = context;
            ExcludeZero = xz;
        }
    }
}