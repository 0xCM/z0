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

    public readonly struct RuleId<T> : IKeyed<RuleId,string>
    {
        public string Key
        {
            [MethodImpl(Inline)]
            get => typeof(T).AssemblyQualifiedName;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => typeof(T) == typeof(void);
        }

        public static implicit operator RuleId(RuleId<T> src)
            => new RuleId(src.Key);
    }
}