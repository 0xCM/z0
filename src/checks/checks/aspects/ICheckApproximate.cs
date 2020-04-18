//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ICheckApproximate : IValidator
    {
        [MethodImpl(Inline)]
        private static ulong dist(double a, double b)
            => a >= b ? (ulong)(a - b) : (ulong)(b - a);

        [MethodImpl(Inline)]
        private static double relerr(double lhs, double rhs)
        {
            var err = dist(lhs,rhs)/lhs;
            return double.IsNaN(err) ? 0 : err;
        }

        [MethodImpl(Inline)]
        private static bool within(double a, double b, double delta)
            => a > b ? a - b <= delta 
              : b - a <= delta;

        [MethodImpl(Inline)]   
        bool almost(float lhs, float rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var err = relerr(lhs,rhs);
            var tolerance = .1f;            
            return err < tolerance ? true : throw failed(ClaimKind.Close, NotClose(lhs, rhs, err, tolerance, caller, file, line));
        }

        [MethodImpl(Inline)]   
        bool almost(double lhs, double rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var err = relerr(lhs,rhs);
            var tolerance = .1f;            
            return err < tolerance ? true : throw failed(ClaimKind.Close, NotClose(lhs, rhs, err, tolerance, caller, file, line));
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
            for(var i = 0; i< Claim.length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                    throw AppErrors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }
    }
}