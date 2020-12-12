//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    partial struct Addresses
    {
       [Op]
        public static string format(RelativeAddress src)
            => src.Offset.FormatSmallHex(true);

        [Op, Closures(Closure)]
        public static string format<T>(RelativeAddress<T> src)
            where T : unmanaged
        {
            if(bitwidth<T>() == 8)
                return @as<T,byte>(src.Offset).FormatAsmHex();
            else if(bitwidth<T>() == 16)
                return @as<T,ushort>(src.Offset).FormatAsmHex();
            else if(bitwidth<T>() == 32)
                return @as<T,uint>(src.Offset).FormatAsmHex();
            else
                return @as<T,ulong>(src.Offset).FormatAsmHex();
        }
    }
}