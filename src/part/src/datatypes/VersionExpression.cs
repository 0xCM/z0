//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [DataType]
    public readonly struct VersionExpresson
    {
        public string Value {get;}

        [MethodImpl(Inline)]
        public VersionExpresson(string src)
        {
            Value = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator VersionExpresson(string src)
            => new VersionExpresson(src);
    }
}