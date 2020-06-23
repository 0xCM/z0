//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AppErrorMsg;
    using static CheckClose;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface TCheckClose : TCheckLengths
    {
        [MethodImpl(Inline)]   
        bool almost(float lhs, float rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var dist = fmath.dist(lhs,rhs);
            if(dist.IsNaN() || dist.Infinite() || dist < Res32)    
                return true;
                
            var err = fmath.relerr(lhs,rhs);
            var tolerance = .1f;            
            return err < tolerance ? true : throw Failed(ClaimKind.Close, NotClose(lhs, rhs, err, tolerance, caller, file, line));
        }

        [MethodImpl(Inline)]   
        bool almost(double lhs, double rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var dist = fmath.dist(lhs,rhs);
            if(dist.IsNaN() || dist.Infinite() || dist < Res64)    
                return true;

            var err = fmath.relerr(lhs,rhs);            
            var tolerance = .1f;            
            return err < tolerance ? true : throw Failed(ClaimKind.Close, NotClose(lhs, rhs, err, tolerance, caller, file, line));
        }

        [MethodImpl(Inline)]   
        void close<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                almost(As.float32(lhs), As.float32(rhs), caller, file,line);
            else if(typeof(T) == typeof(double))
                almost(As.float64(lhs), As.float64(rhs), caller, file,line);
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Asserts that corresponding elements of two source spans of the same length are "close" as determined by a specified tolerance
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="tolerance">The acceptable difference between corresponding left/right elements</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        void close<T>(Span<T> lhs, Span<T> rhs, T tolerance, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                    throw AppErrors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }
    }
}