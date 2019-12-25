//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public abstract class t_gmath<X> : UnitTest<X>    
        where X : t_gmath<X>, new()
    {

        protected void VerifyOp<K>(BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, 
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                where K : unmanaged
        {
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(BinaryPred<K> baseline, BinaryPred<K> op, bool nonzero = false, 
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where K : unmanaged
        {
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();            

            for(var i = 0; i<len; i++)
                Claim.eq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

       protected K[] RandArray<K>(bool nonzero = false)
            where K : unmanaged
        {
            var config = Config.Get<K>();
             return nonzero 
                ? Random.NonZeroArray<K>(config.SampleSize, SampleDomain<K>())                
                : Random.Array<K>(config.SampleSize, SampleDomain<K>());
        }

    }
}
