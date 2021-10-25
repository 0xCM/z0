//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    readonly struct UniversalNames
    {
        public const string eq = nameof(eq);

        public const string neq = nameof(neq);

        public const string lt = nameof(lt);

        public const string nlt = nameof(nlt);

        public const string le = nameof(le);

        public const string gt = nameof(gt);

        public const string ngt = nameof(ngt);

        public const string ge = nameof(ge);
    }
}