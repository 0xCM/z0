//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RuleId : IKeyed<RuleId,string>
    {
        public string Key {get;}

        [MethodImpl(Inline)]
        public RuleId(string id)
            => Key = id;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Key);
        }

        [MethodImpl(Inline)]
        public static implicit operator RuleId(string src)
            => new RuleId(src);

        public static RuleId Empty
        {
            [MethodImpl(Inline)]
            get => new RuleId(EmptyString);
        }
    }
}