//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Rules;

    [ApiHost]
    public readonly partial struct CmpPredEval
    {
        public static CmpEval<T> eval<T>(EQ<T> pred)
            where T : unmanaged
        {
            return default;
        }
    }
}
