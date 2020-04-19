//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    static class TestCaseIdentity
    {
        const char Sep = UriDelimiters.PathSep;

        public static OpIdentity SubjectId<T>(string opname)
            where T : unmanaged
                => Identify.NumericOp(opname, NumericKinds.kind<T>());

        public static OpIdentity SFuncBaseline<K>(string opname)
            where K : unmanaged
                => Identify.sfunc<K>($"{opname}_baseline");

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string sfunc(Type host, ISFuncApi f)
            => $"{Identify.owner(host)}{Sep}{host.Name}{Sep}{f.Id}";
    }
}