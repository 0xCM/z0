//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class Validator : IValidator
    {
        protected Validator(ITestContext context, bool xzero = false)
        {
            this.Context = context;
            this.ExcludeZero = xzero;
        }
        
        public ITestContext Context {get;}

        protected IPolyrand Random
            => Context.Random;

        public int RepCount
            => Context.RepCount;

        protected bool ExcludeZero {get;}
    }
}