//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public abstract class SFMatch : ISFMatch
    {
        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]   
        protected static SystemCounter counter(bool start = false, int? reps = null) 
            => SystemCounter.Create(start);

        protected SFMatch(ITestContext context, bool xzero = false, int? reps = null)
        {
            this.Context = ValidationContext.From(context);
            this.RepCount = reps ?? Pow2.T07;
            this.ExcludeZero = xzero;
        }

        public IValidationContext Context {get;}

        protected IPolyrand Random
            => Context.Random;

        public int RepCount {get;}

        protected bool ExcludeZero {get;}

        protected void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Context.Deposit(AppMsg.Error(e, caller,file,line));
    }

}