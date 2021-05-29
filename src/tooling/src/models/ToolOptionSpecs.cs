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
    public readonly struct ToolOptionSpecs : IIndex<ToolOptionSpecs,ushort,ToolOptionSpec>
    {
        readonly Index<ToolOptionSpec> Data;

        [MethodImpl(Inline)]
        public ToolOptionSpecs(ToolOptionSpec[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref ToolOptionSpec this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ToolOptionSpec[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public string Format()
            => Seq.format(Storage);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolOptionSpecs(ToolOptionSpec[] src)
            => new ToolOptionSpecs(src);

        [MethodImpl(Inline)]
        public static implicit operator ToolOptionSpec[](ToolOptionSpecs src)
            => src.Storage;
    }
}