//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

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

        protected SFMatch(IValidationContext context, bool xzero = false, int? reps = null)
        {
            this.Context = context;
            this.RepCount = reps ?? Pow2.T07;
            this.ExcludeZero = xzero;
        }

        public IValidationContext Context {get;}

        protected IPolyrand Random
            => Context.Random;

        public int RepCount {get;}

        protected bool ExcludeZero {get;}

        protected void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Context.Notify(AppMsg.Error(e, caller,file,line));
    }

    public abstract class SFComparer<T> : SFMatch
        where T : unmanaged
    {
        protected SFComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)        
        {


        }
    }

    public abstract class OperatorComparer<W,T> : SFMatch
        where W : struct, ITypeWidth
        where T : unmanaged
    {
        protected OperatorComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)        
        {

            
        }

        protected string CaseName(ISFuncApi f)
        {
            var id = OpIdentity.operation(f.Id.Name, default(W).Class, NumericTypes.kind<T>(),true);
            var owner = TypeIdentity.owner(Context.HostType);
            var host = Context.HostType.Name;
            return $"{owner}/{host}/{id}";            
        }
    }

}