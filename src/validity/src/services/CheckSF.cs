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

    public abstract class CheckSF : ICheckSF
    {
        public ITestContext Context {get;}

        protected bool ExcludeZero {get;}

        protected CheckSF(ITestContext context, bool xzero = false)
        {
            this.Context= context;
            this.ExcludeZero = xzero;
        }

        protected IPolyrand Random => Checker.Random;

        protected int RepCount  => Checker.RepCount;

        protected ICheckNumeric Claim => CheckNumeric.Checker;

        protected ICheckSF Checker => this;

        [MethodImpl(Inline)]   
        protected SystemCounter counter(bool start = false) 
            => Checker.counter(start);

        protected string CaseName(ISFuncApi f)
            => Checker.CaseName(f);

        protected void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Checker.Error(e,caller,file,line);
    }
}