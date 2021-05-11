//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ExtractTermInfo
    {
        public ExtractTermKind Kind {get;}

        public int Offset {get;}

        [MethodImpl(Inline)]
        public ExtractTermInfo(ExtractTermKind kind, int offset)
        {
            Offset = offset;
            Kind = kind;
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
            get => new ExtractTermInfo(ExtractTermKind.None, 0);
        }
    }
}