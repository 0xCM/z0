//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [DataType]
    public readonly struct CmdOptions : IIndexedView<CmdOptions,ushort,CmdOption>
    {
        readonly IndexedView<CmdOption> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdOption[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref readonly CmdOption this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public CmdOption[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdOption> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        public string Format()
            => Seq.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions(CmdOption[] src)
            => new CmdOptions(src);
    }
}