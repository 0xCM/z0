//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public abstract class Validator : IValidator
    {
        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]   
        protected static SystemCounter counter(bool start = false) 
            => SystemCounter.Create(start);

        protected Validator(ITestContext context, bool xzero = false)
        {
            this.Context = context;
            this.RepCount = context.RepCount;
            this.ExcludeZero = xzero;
        }
        
        public ITestContext Context {get;}


        protected IPolyrand Random
            => Context.Random;

        public int RepCount {get;}

        protected bool ExcludeZero {get;}

    }
}