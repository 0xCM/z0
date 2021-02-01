//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ModuleMemory : ITextual
    {
        public Name ModuleName {get;}

        public MemoryAddress BaseAddress {get;}

        public ByteSize MemorySize {get;}

        [MethodImpl(Inline)]
        public ModuleMemory(Name module, MemoryAddress @base, ByteSize size)
        {
            ModuleName = module;
            BaseAddress = @base;
            MemorySize = size;
        }

        public MemorySegment Segment
        {
            [MethodImpl(Inline)]
            get => memseg(BaseAddress, MemorySize);
        }

        public MemoryAddress LastAddress
        {
            [MethodImpl(Inline)]
            get => BaseAddress + MemorySize;
        }

        public string Format()
            => string.Format("{0,-64}: {1}({2})", ModuleName, Segment, MemorySize);

        public override string ToString()
            => Format();
    }
}