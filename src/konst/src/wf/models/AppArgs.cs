//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppArgs : IIndex<AppArg>
    {
        readonly IndexedSeq<AppArg> Data;

        [MethodImpl(Inline)]
        public AppArgs(AppArg[] src)
            => Data = src;

        public ref AppArg this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public AppArg[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Span<AppArg> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator AppArgs(AppArg[] src)
            => new AppArgs(src);

        [MethodImpl(Inline)]
        public static implicit operator AppArgs(string[] src)
            => new AppArgs(src.Map(x => new AppArg(x)));
    }
}