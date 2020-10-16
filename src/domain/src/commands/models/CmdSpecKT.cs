//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct CmdSpecData<K,T>
        where K : unmanaged
    {
        public CmdId Id;

        public TableSpan<CmdOption<K,T>> Options;
    }

    public readonly struct CmdSpec<K,T> : ICmdSpec<CmdSpec<K,T>,K,T>
        where K : unmanaged
    {
        internal readonly CmdOption<K,T>[] OptionStorage;

        public CmdId Id {get;}

        public ReadOnlySpan<CmdOption<K,T>> Options
            => OptionStorage;

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdOption<K,T>[] options)
        {
            Id = id;
            OptionStorage = options;
        }

        public CmdSpecData<K,T> Data
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}