//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;

    using C = AsciCode;

    partial class AsciCodes     
    {
        [MethodImpl(Inline), Op]
        public static AsciCode2 define(C a, C b)
        {
            var x0 = (ushort)a;
            var x1 = (ushort)((ushort)b << 8);
            return new AsciCode2((ushort)(x0 | x1));
        }

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(C a, C b, C c, C d)
        {
            var x0 = (uint)a;
            var x1 = (uint)((uint)b << 8);
            var x2 = (uint)((uint)c << 16);
            var x3 = (uint)((uint)d << 24);
            return new AsciCode4(x0 | x1 | x2 | x3);
        }

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode define(N1 n, in byte src)
            => ref to<byte,AsciCode>(src);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode2 define(N2 n, in ushort src)
            => ref to<ushort,AsciCode2>(src);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 define(N4 n, in uint src)
            => ref to<uint,AsciCode4>(src);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 define(N8 n, in ulong src)
            => ref to<ulong,AsciCode8>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(N4 n, string src)
        {
            var dst = 0u;
            var data = span(src);
            ref readonly var src16 = ref head(data);
            ref var dst8 = ref imagine<uint,byte>(ref dst);
            seek(ref dst8, 0) = (byte)skip(src16, 0);
            seek(ref dst8, 1) = (byte)skip(src16, 1);
            seek(ref dst8, 2) = (byte)skip(src16, 2);
            seek(ref dst8, 3) = (byte)skip(src16, 3);
            return define(n, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsciCode16 define(N16 n, ulong lo, ulong hi)
            => new AsciCode16(Vector128.Create(lo,hi).AsByte());

        [MethodImpl(Inline), Op]
        public static AsciCode2 define(N2 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,ushort>(src)));

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(N4 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static AsciCode8 define(N8 n, ReadOnlySpan<byte> src)
            => define(n, head(cast<byte,uint>(src)));
    }
}