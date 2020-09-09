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

    public readonly struct Relational
    {

    }

    public readonly struct Related
    {

        public struct Relation<a,b>
        {
            public a A;

            public b B;
        }

        public readonly struct Relations<a,b>
        {
            readonly Relation<a,b>[] Related;

            [MethodImpl(Inline)]
            public static implicit operator Relations<a,b>(Relation<a,b>[] src)
                => new Relations<a,b>(src);

            [MethodImpl(Inline)]
            public Relations(Relation<a,b>[] src)
            {
                Related = src;
            }
        }

        public struct Relation<a,b,c>
        {
            public a A;

            public b B;

            public c C;

        }

        public struct Relation<a,b,c,d>
        {
            public a A;

            public b B;

            public c C;

            public d D;
        }

    }

    public readonly struct Relation
    {

    }
}