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

    partial struct Db
    {
        public readonly struct ObjectName
        {
            internal readonly StringRef Ref;

            [MethodImpl(Inline)]
            public ObjectName(string src)
                => Ref = src;

            public ReadOnlySpan<char> Data
            {
                [MethodImpl(Inline)]
                get => Ref.View;
            }

            [MethodImpl(Inline)]
            public static implicit operator ObjectName(string src)
                => new ObjectName(src);
        }

        public readonly struct ObjectName<K>
            where K : unmanaged
        {
            readonly StringRef Ref;

            public K Kind {get;}

            [MethodImpl(Inline)]
            public ObjectName(K kind, string id)
            {
                Kind = kind;
                Ref = id;
            }

            public ReadOnlySpan<char> Data
            {
                [MethodImpl(Inline)]
                get => Ref.View;
            }

            [MethodImpl(Inline)]
            public static implicit operator ObjectName<K>((K kind, string id) x)
                => new ObjectName<K>(x.kind, x.id);
        }
    }
}
