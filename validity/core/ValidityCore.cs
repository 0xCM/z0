//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.ValidityCore)]

namespace Z0.Parts
{
    public sealed class ValidityCore : Part<ValidityCore>
    {        
        
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class Validity
    {
        const char Sep = UriDelimiters.FS;

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, ISFuncApi f)
            => $"{Identify.owner(host)}{Sep}{host.Name}{Sep}{f.Id}";

    }

    public static class ServiceFactory
    {
        public static ISFMatch<T,T> UnaryOpMatch<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new SFOpMatch1<T>(context);

        public static ISFMatch<T,T,T> BinaryOpMatch<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new SBinaryOpComparer<T>(context);

        public static ISFMatch<T,T,T> BinaryOpMatch<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
            => new SBinaryOpComparer<T>(context,xzero);

        public static ISFMatch<T,T,T,T> TernaryOpMatch<T>(this ITestContext context, bool xzero = false, T t = default)
            where T : unmanaged
                => new SFOpMatch3<T>(context,xzero);

        public static ISFMatch<T,T,bit> BinaryPredicateMatch<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new SBinaryPredMatch<T>(context);

        public static ISFMatch<T,T,T,bit> TernaryPredicateComparer<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new STernaryPredMatch<T>(context);        
    }
}