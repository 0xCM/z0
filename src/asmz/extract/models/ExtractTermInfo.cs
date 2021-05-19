//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ExtractTermInfo
    {
        public ExtractTermKind Kind {get;}

        public int Offset {get;}

        public sbyte Modifier {get;}

        [MethodImpl(Inline)]
        public ExtractTermInfo(ExtractTermKind kind, int offset, sbyte modifier)
        {
            Offset = offset;
            Kind = kind;
            Modifier = modifier;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Kind == ExtractTermKind.None;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Kind != ExtractTermKind.None && Offset > 0;
        }

        public static ExtractTermInfo Empty
        {
            [MethodImpl(Inline)]
            get => new ExtractTermInfo(ExtractTermKind.None, 0, 0);
        }
    }
}