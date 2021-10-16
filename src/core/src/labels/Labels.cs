//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class Labels : IDisposable
    {
        [MethodImpl(Inline), Op]
        public static Label label(string src)
        {
            if(core.empty(src))
                return Label.Empty;
            StringAddress a = src;
            return new Label(a.Address, (byte)src.Length);
        }

        [MethodImpl(Inline), Op]
        public static Label label(ReadOnlySpan<char> src)
            => new Label(address(src), (byte)src.Length);

        public static Labels alocate(ByteSize size)
            => new Labels(memory.native(size));

        [MethodImpl(Inline), Op]
        public static ConstLabels from(ReadOnlySpan<char> src)
            => new ConstLabels(src);

        readonly NativeBuffer Buffer;

        internal readonly MemoryAddress BaseAddress;

        internal readonly ByteSize Size;

        readonly bool CanEdit;

        [MethodImpl(Inline)]
        internal Labels(MemoryAddress @base, ByteSize size)
        {
            Buffer = NativeBuffer.Empty;
            BaseAddress = @base;
            Size = size;
            CanEdit = true;
        }

        [MethodImpl(Inline)]
        internal Labels(NativeBuffer buffer)
        {
            Buffer = buffer;
            BaseAddress = buffer.Address;
            Size = buffer.Size;
            CanEdit = false;
        }

        [MethodImpl(Inline)]
        public bool Editor(out LabelEditor dst)
        {
            if(CanEdit)
            {
                dst = new LabelEditor(this);
                return true;
            }
            dst = default;
            return false;
        }

        public void Dispose()
        {
            if(Buffer.Allocated)
                Buffer.Dispose();
        }
    }
}