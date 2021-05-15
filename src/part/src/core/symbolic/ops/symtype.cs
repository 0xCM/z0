//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Symbols
    {
       public static ref SymTypeInfo symtype<T>(out SymTypeInfo dst)
            where T : unmanaged, Enum
        {
            var t = typeof(T);
            dst.TypeName = t.Name;
            dst.DataType = (PrimalCode)ClrEnums.ecode(t);
            dst.SymCount = (ushort)t.GetFields().Length;
            dst.TypeNameData = text.utf16(dst.TypeName).ToArray();
            dst.TypeNameSize = (ushort)dst.TypeNameData.Length;
            return ref dst;
        }
    }
}