//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CreditTypes;

    partial class Credits
    {
        [MethodImpl(Inline), Op]
        public static ContentType type(ContentRef src)
        {
            var isolated = (ushort)((ushort)(ContentField.Type) & (ushort)src);
            var value = isolated >> (byte)ContentLevel.Type;
            return (ContentType)value;
        }
    }
}