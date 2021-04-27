//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    public readonly struct ClrTable
    {
        public CliTableKind Kind {get;}

        [MethodImpl(Inline)]
        public ClrTable(CliTableKind value)
            => Kind = (CliTableKind)value;

        public string Format()
            => string.Format("{0:X2}",(byte)Kind);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ClrTable(CliTableKind src)
            => new ClrTable(src);

        [MethodImpl(Inline)]
        public static implicit operator CliTableKind(ClrTable src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ClrTable(TableIndex src)
            => new ClrTable((CliTableKind)src);

        [MethodImpl(Inline)]
        public static implicit operator TableIndex(ClrTable src)
            => (TableIndex)src.Kind;
    }
}