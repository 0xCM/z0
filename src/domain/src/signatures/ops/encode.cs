//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct Signatures
    {
        [MethodImpl(Inline), Op]
        public static Signature encode(string identifier, Type r)
            => new Signature(identifier, vparts(W, z32, 0,0,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(string identifier, Type a, Type r)
            => new Signature(identifier, vparts(W, (uint)a.MetadataToken, 0,0,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(string identifier, Type a, Type b, Type r)
            => new Signature(identifier, vparts(W, (uint)a.MetadataToken, (uint)b.MetadataToken,0,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(string identifier, Type a, Type b, Type c, Type r)
            => new Signature(identifier, vparts(W, (uint)a.MetadataToken, (uint)b.MetadataToken,(uint)c.MetadataToken,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(in StringRef identifier, Type r)
            => new Signature(identifier, vparts(W, z32, 0,0,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(in StringRef identifier, Type a, Type r)
            => new Signature(identifier, vparts(W, (uint)a.MetadataToken, 0,0,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(in StringRef identifier, Type a, Type b, Type r)
            => new Signature(identifier, vparts(W, (uint)a.MetadataToken, (uint)b.MetadataToken,0,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature encode(in StringRef identifier, Type a, Type b, Type c, Type r)
            => new Signature(identifier, vparts(W, (uint)a.MetadataToken, (uint)b.MetadataToken,(uint)c.MetadataToken,0,0,0,0, (uint)r.MetadataToken));

        [MethodImpl(Inline), Op]
        public static Signature fx(string identifier, U8 a)
            => define<byte>(identifier);

        [MethodImpl(Inline), Op]
        public static Signature fx(string identifier, U8 a, U8 r)
            => define<byte,ushort>(identifier);

        [MethodImpl(Inline), Op]
        public static Signature fx(string identifier, U8 a, U8 b, U8 r)
            => define<byte,ushort,uint>(identifier);

        [MethodImpl(Inline), Op]
        public static Signature fx(string identifier, U8 a, U8 b, U8 c, U8 r)
            => define<byte,ushort,uint,ulong>(identifier);

    }
}