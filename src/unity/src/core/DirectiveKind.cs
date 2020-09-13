//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    public readonly struct DirectiveKind<K> : IDirectiveKind<DirectiveKind<K>, K>
        where K : unmanaged, IDirectiveKind<K>
    {
        public K Kind {get;}

        [MethodImpl(Inline)]
        public DirectiveKind(K kind)
            => Kind = kind;
    }

    public struct KindBits<T>
    {
        [MethodImpl(Inline)]
        public KindBits(T src)
        {
            Data = src;
        }

        public readonly T Data;
    }

    public readonly struct KindBits
    {
        public struct Kind8
        {
            readonly byte Data;
        }

        public struct Kind16
        {
            readonly ushort Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Kind24
        {
            readonly Kind16 LO;

            readonly Kind8 Hi;
        }

        public struct Kind32
        {
            readonly uint Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Kind40
        {
            readonly Kind32 Lo;

            readonly Kind8 Hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Kind48
        {
            readonly Kind24 LO;

            readonly Kind24 Hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Kind56
        {
            readonly Kind48 LO;

            readonly Kind8 Hi;
        }

        public struct Kind64
        {
            readonly ulong Data;
        }
    }
}