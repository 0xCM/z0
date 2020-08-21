//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiDataType]
    public readonly struct Purpose
    {
        public string Description {get;}

        public static Purpose Without
        {
            [MethodImpl(Inline)]
            get => new Purpose(EmptyString);
        }

        [MethodImpl(Inline)]
        public static Purpose Some(string description)
            => new Purpose(description);

        [MethodImpl(Inline)]
        public Purpose(string description)
        {
            Description = description ?? EmptyString;
        }

        public bool None
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Description);
        }

        public bool Has
        {
            [MethodImpl(Inline)]
            get => !string.IsNullOrWhiteSpace(Description);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Description ?? EmptyString;
    }
}