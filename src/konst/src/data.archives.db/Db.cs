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

    [ApiHost(ApiNames.Db, true)]
    public readonly partial struct Db
    {
        [MethodImpl(Inline), Op]
        public static ObjectName name(string src)
            => new ObjectName(src);

        [MethodImpl(Inline), Op]
        public static Relation relate(in ObjectName src, in ObjectName dst)
            => new Relation(src,dst);

        [MethodImpl(Inline), Op]
        public static Relation relate(string src, string dst)
            => relate(name(src), name(dst));

        [MethodImpl(Inline), Op]
        public static Key key(in ObjectName id)
            => new Key(id.Ref.Address);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Key<T> key<T>(T src)
            where T : unmanaged
                => src;

        [MethodImpl(Inline), Op]
        public string literal(N0 n)
            => Literals.asm;

        [MethodImpl(Inline), Op]
        public string literal(N1 n)
            => Literals.cs;
    }
}