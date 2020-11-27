//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CaseLogs, true)]
    public readonly struct CaseLogs
    {
        [MethodImpl(Inline)]
        public static CaseLog<F,T> create<F,T>(FS.FilePath dst)
            where T : struct, ITabular
            where F : unmanaged, Enum
                => new CaseLog<F,T>(dst);

        [Op]
        public static CaseLog create(FS.FilePath dst)
            => new CaseLog(create<TestCaseField,TestCaseRecord>(dst));
    }
}