//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a <see cref='CommandOptionSpec'/> index
    /// </summary>
    public readonly struct CmdOptions : IIndex<CmdOptions,ushort,CmdOption>
    {
        readonly Index<CmdOption> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdOption[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref CmdOption this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public CmdOption[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public string Format()
            => Seq.format(Storage);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions(CmdOption[] src)
            => new CmdOptions(src);

        [MethodImpl(Inline)]
        public static implicit operator CmdOption[](CmdOptions src)
            => src.Storage;
    }
}