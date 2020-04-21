//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public abstract class OperatorComparer<W,T> : SFMatch
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        protected OperatorComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)        
        {
            
        }

        protected string CaseName(ISFuncApi f)
        {
            var id = Identify.Op(f.Id.Name, Widths.type<W>(), NumericKinds.kind<T>(),true);
            var owner = Identify.Owner(Context.ValidatorType);
            var host = Context.ValidatorType.Name;
            return $"{owner}/{host}/{id}";            
        }
    }
}