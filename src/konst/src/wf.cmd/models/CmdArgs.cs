//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdArgs : IIndex<CmdArg>
    {
        readonly Index<CmdArg> Data;

        [MethodImpl(Inline)]
        public CmdArgs(CmdArg[] src)
            => Data = src;

        public ref CmdArg this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref CmdArg this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public CmdArg[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Span<CmdArg> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
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

        [MethodImpl(Inline)]
        public static implicit operator CmdArgs(CmdArg[] src)
            => new CmdArgs(src);

        public static CmdArgs Empty
        {
            [MethodImpl(Inline)]
            get => new CmdArgs(sys.empty<CmdArg>());
        }
    }
}