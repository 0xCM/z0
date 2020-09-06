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

    public readonly struct DataKind<K> : ITextual
    {
        public readonly K Class;

        [MethodImpl(Inline)]
        public static implicit operator DataKind<K>(K @class)
            => new DataKind<K>(@class);

        [MethodImpl(Inline)]
        public DataKind(K @class)
        {
            Class = @class;
        }
        [MethodImpl(Inline)]
        public string Format()
            => Class.ToString();
    }
}