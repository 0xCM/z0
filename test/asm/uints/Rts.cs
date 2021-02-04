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

    [ApiDeep]
    public readonly struct Rts
    {
        [MethodImpl(Inline)]
        public static T[] init<T>(RuntimeFieldHandle handle)
        {
            var dst = new T[]{};
            RuntimeHelpers.InitializeArray(dst, handle);
            return dst;
        }

        [MethodImpl(Inline)]
        public static MemoryAddress location(FieldInfo f)
            => f.FieldHandle.Value;

        [Ignore]
        public static ulong[] data()
            => init<ulong>(typeof(Rts).Fields()[0].FieldHandle);

        public static ReadOnlySpan<byte> U8Data
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

        public static ReadOnlySpan<uint> U32Data
            => recover<uint>(U8Data);

        public static ReadOnlySpan<ushort> U16Data
            => recover<ushort>(U8Data);

        public static ReadOnlySpan<ulong> U64Data
            => recover<ulong>(U8Data);
    }
}