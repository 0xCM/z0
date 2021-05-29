//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ToolFlagSpecs : IIndex<ToolFlagSpec>
    {
        readonly Index<ToolFlagSpec> Data;

        [MethodImpl(Inline)]
        public ToolFlagSpecs(ToolFlagSpec[] src)
            => Data = src;

        public ToolFlagSpec[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolFlagSpecs(ToolFlagSpec[] src)
            => new ToolFlagSpecs(src);
    }
}