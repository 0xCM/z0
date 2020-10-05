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

    partial struct Refs
    {
        [MethodImpl(Inline), Op]
        public static uint user(Vector128<ulong> src)
        {
            unpack(vcell(src,1), out _, out var user);
            return user;
        }

        [MethodImpl(Inline), Op]
        public static void unpack(ulong src, out uint length, out uint user)
        {
            length = (uint)src;
            user  = (uint)(src >> 32);
        }

        [MethodImpl(Inline), Op]
        public static void unpack(Vector128<ulong> src, out uint length, out uint user)
            => unpack(vcell(src,1), out length, out user);


        [MethodImpl(Inline), Op]
        public static void unpack(Vector128<ulong> src, out MemoryAddress a, out uint length, out uint user)
        {
            a = Refs.location(src);
            unpack(src, out length, out user);
        }

        [MethodImpl(Inline), Op]
        public static ref Vector128<ulong> pack(MemoryAddress address, uint length, uint user, out Vector128<ulong> dst)
        {
            dst = pack(address, length, user);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ulong pack(uint length, uint user, out ulong dst)
        {
            dst = (ulong)length | ((ulong)user << 32);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> pack(MemoryAddress address, uint length, uint user)
            => vparts(N128.N, address, pack(length*scale<char>(), user, out var dst));
    }
}