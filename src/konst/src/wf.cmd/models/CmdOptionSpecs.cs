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
    public readonly struct CmdOptionSpecs : IIndexedView<CmdOptionSpecs,ushort,CmdOptionSpec>
    {
        readonly IndexedView<CmdOptionSpec> Data;

        [MethodImpl(Inline)]
        public CmdOptionSpecs(CmdOptionSpec[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref readonly CmdOptionSpec this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public CmdOptionSpec[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdOptionSpec> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        public string Format()
            => Seq.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOptionSpecs(CmdOptionSpec[] src)
            => new CmdOptionSpecs(src);
    }
}