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

    using api = Validator;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost(ApiNames.CheckClose)]
    public readonly struct CheckClose : TCheckClose
    {
        public static TCheckClose Checker => default(CheckClose);

        internal const double Tolerance = .1;

        internal const float Res32 = .0000001f;

        internal const double Res64 = .0000001;

        [MethodImpl(Inline), Op]
        public static bool almost(float lhs, float rhs)
        {
            var dist = fmath.dist(lhs,rhs);
            if(dist.IsNaN() || dist.Infinite() || dist < Res32)
                return true;

            var err = fmath.relerr(lhs,rhs);
            var tolerance = .1f;
            return err < tolerance ? true : throw api.failed(ClaimKind.Close, NotClose(lhs, rhs, err, tolerance));
        }

        [MethodImpl(Inline), Op]
        public static bool almost(double lhs, double rhs)
        {
            var dist = fmath.dist(lhs,rhs);
            if(dist.IsNaN() || dist.Infinite() || dist < Res64)
                return true;

            var err = fmath.relerr(lhs,rhs);
            var tolerance = .1f;
            return err < tolerance ? true : throw api.failed(ClaimKind.Close, NotClose(lhs, rhs, err, tolerance));
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static void close<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                almost(z.float32(lhs), z.float32(rhs));
            else if(typeof(T) == typeof(double))
                almost(z.float64(lhs), z.float64(rhs));
            else
                throw no<T>();
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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void close<T>(Span<T> lhs, Span<T> rhs, T tolerance, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            for(var i = 0; i< CheckLengths.length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                    throw AppErrors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }
    }
}