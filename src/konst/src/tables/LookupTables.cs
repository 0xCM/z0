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
    using static z;

    [ApiHost]
    public readonly partial struct LookupTables
    {
        [Op, Closures(UInt8k)]
        public static LookupGrid<byte,byte,byte,T> grid<T>(W8 ixj)
            => new LookupGrid<byte,byte,byte,T>(new byte[256,256], new T[256*256]);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T lookup<T>(in LookupGrid<byte,byte,byte,T> src, byte i, byte j)
            where T : unmanaged
                => ref lookup<byte,byte,byte,T>(src,i,j);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T lookup<T>(in TableSpan<N256,N256,T> src, byte i, byte j)
            where T : unmanaged
                => ref src[i,j];

        [MethodImpl(Inline)]
        static LuFx64<K> luFx<K>(TableSpan<ulong> index, TableSpan<K> values)
            where K : unmanaged
                => new LuFx64<K>(index,values);

        [MethodImpl(Inline)]
        public static ref T lookup<I,J,S,T>(in LookupGrid<I,J,S,T> src, I i, J j)
            where I : unmanaged
            where J : unmanaged
            where S : unmanaged
        {
            var i64 = uint64(i);
            var j64 = uint64(j);
            var ixj = uint64(src.Index[i64,j64]);
            return ref src.Values[ixj];
        }
    }
}