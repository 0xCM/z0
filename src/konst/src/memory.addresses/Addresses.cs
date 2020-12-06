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

    using DW = DataWidth;

    [ApiHost]
    public readonly struct Addresses
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static bool equals(RelativeAddress a, RelativeAddress b)
            => a.Offset == b.Offset && a.Grain == b.Grain;

        [MethodImpl(Inline), Op]
        public static unsafe MemberAddress member(MethodInfo src)
            => new MemberAddress(src, src.MethodHandle.Value.ToPointer());

        [MethodImpl(Inline), Op]
        public static unsafe MemberAddress member(FieldInfo src)
            => new MemberAddress(src, src.FieldHandle.Value.ToPointer());

        [Op]
        public static string format(RelativeAddress src)
            => src.Offset.FormatSmallHex(true);

        [Op, Closures(Closure)]
        public static string format<T>(RelativeAddress<T> src)
            where T : unmanaged
        {
            if(memory.bitwidth<T>() == 8)
                return memory.@as<T,byte>(src.Offset).FormatAsmHex();
            else if(memory.bitwidth<T>() == 16)
                return memory.@as<T,ushort>(src.Offset).FormatAsmHex();
            else if(memory.bitwidth<T>() == 32)
                return memory.@as<T,uint>(src.Offset).FormatAsmHex();
            else
                return memory.@as<T,ulong>(src.Offset).FormatAsmHex();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RelativeAddress<T> relative<T>(T offset)
            where T : unmanaged
                => new RelativeAddress<T>(offset);

        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(byte offset)
            => new RelativeAddress(offset, DW.W8);

        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(ushort offset)
            => new RelativeAddress(offset, DW.W16);

        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(uint offset)
            => new RelativeAddress(offset, DW.W32);
    }
}