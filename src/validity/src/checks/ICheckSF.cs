//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ICheckSF : ITestService, ICheckVectors
    {
        bool ExcludeZero => false;        
    }

    public readonly struct CheckSF : ICheckSF
    {
        [MethodImpl(Inline)]
        public static ICheckSF Create(ITestContext context, bool xzero = false)
            => new CheckSF(context, xzero);

        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckSF(ITestContext context, bool xzero = false)
        {
            this.Context= context;
            this.ExcludeZero = xzero;
        }
    }
}