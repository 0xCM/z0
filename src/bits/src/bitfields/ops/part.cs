//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitFieldPart<T> part<T>(Identifier name, T start, T end)
            where T : unmanaged
                => new BitFieldPart<T>(name, start, end);

        [MethodImpl(Inline), Op]
        public static BitfieldPart part(Identifier name, byte startpos, byte endpos)
            => new BitfieldPart(name, startpos, endpos);

        [MethodImpl(Inline)]
        public static BitfieldPart part<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => part((Identifier)id.ToString(), startpos, endpos);

        public static BitfieldPart part<I,W>(in BitFieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = ClrEnums.scalar<I,byte>(entry.FieldIndex);
            var width = ClrEnums.scalar<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = part((Identifier)entry.FieldName, start, end);
            start = (byte)(end + 1);
            return seg;
        }
    }
}