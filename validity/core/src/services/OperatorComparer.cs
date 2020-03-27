//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;


    public abstract class OperatorComparer<W,T> : SFMatch
        where W : struct, ITypeWidth
        where T : unmanaged
    {
        protected OperatorComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)        
        {
            
        }

        protected string CaseName(ISFuncApi f)
        {
            var id = Identify.Op(f.Id.Name, default(W).Class, NumericTypes.kind<T>(),true);
            var owner = Identify.Owner(Context.HostType);
            var host = Context.HostType.Name;
            return $"{owner}/{host}/{id}";            
        }
    }


}