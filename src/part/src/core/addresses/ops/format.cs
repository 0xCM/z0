//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Addresses
    {
       [Op]
        public static string format(RelativeAddress src)
            => src.Offset.FormatAsmHex(4);

        [Op, Closures(Closure)]
        public static string format<T>(RelativeAddress<T> src)
            where T : unmanaged
        {
            if(width<T>() == 8)
                return string.Format("{0} + {1}", src.Base, @as<T,byte>(src.Offset).FormatAsmHex());
            else if(width<T>() == 16)
                return string.Format("{0} + {1}", src.Base, @as<T,ushort>(src.Offset).FormatAsmHex());
            else if(width<T>() == 32)
                return string.Format("{0} + {1}", src.Base, @as<T,uint>(src.Offset).FormatAsmHex());
            else
                return string.Format("{0} + {1}", src.Base, @as<T,ulong>(src.Offset).FormatAsmHex());
        }
    }
}