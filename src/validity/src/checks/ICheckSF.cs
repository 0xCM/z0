//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ICheckSF : ITestService, TCheckVectors
    {
        bool ExcludeZero => false;
    }

    public readonly struct CheckSF : ICheckSF
    {
        [MethodImpl(Inline)]
        public static ICheckSF Create(ITestContext context, bool xz = false)
            => new CheckSF(context, xz);

        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckSF(ITestContext context, bool xz = false)
        {
            Context= context;
            ExcludeZero = xz;
        }
    }
}