//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Args : IIndex<uint2,IAsmOp>
    {
        readonly Index<uint2,IAsmOp> Data;

        [MethodImpl(Inline)]
        public Args(IAsmOp[] src)
            => Data = src;

        public Args(IAsmOp a, IAsmOp b, IAsmOp c, IAsmOp d)
            => Data = new IAsmOp[4]{a,b,c,d};

        public Args(IAsmOp a, IAsmOp b, IAsmOp c)
            => Data = new IAsmOp[3]{a,b,c};

        public Args(IAsmOp a)
            => Data = new IAsmOp[1]{a};

        public Args(IAsmOp a, IAsmOp b)
            => Data = new IAsmOp[2]{a,b};

        public ref IAsmOp this[uint2 index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public ReadOnlySpan<IAsmOp> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<IAsmOp> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public IAsmOp[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public static Args Empty
        {
            [MethodImpl(Inline)]
            get => new Args(sys.empty<IAsmOp>());
        }
    }

}