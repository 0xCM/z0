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

    public readonly struct MethodTable
    {
        public Type Type {get;}

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public MethodTable(Type src)
        {
            Type = src;
            Address = src.TypeHandle.Value;
        }

        public unsafe ByteSize Size
        {
            [MethodImpl(Inline)]
            get => *(Address).Pointer<uint>()/size<uint>();
        }

        public string Format()
            => string.Format("{0}:{1}", Type.Name, Size);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator MethodTable(Type src)
            => new MethodTable(src);
    }
}