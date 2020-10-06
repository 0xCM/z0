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

    using Z0.Asm;

    public readonly ref struct EncodedRoutine
    {
        internal readonly Span<asci32> name;

        internal readonly Span<EncodedInstruction> buffer;

        internal readonly Span<uint> index;

        [MethodImpl(Inline)]
        public static EncodedRoutine operator +(in EncodedRoutine dst, in EncodedInstruction src)
            => Add(dst, src);

        public static implicit operator EncodedAsmRoutine(EncodedRoutine src)
            => src.Emit();

        [MethodImpl(Inline)]
        public EncodedRoutine(string name, int capacity)
        {
            this.name = new asci32[1]{name};
            this.buffer = alloc<EncodedInstruction>(capacity);
            this.index = new uint[1]{0};
        }

        [MethodImpl(Inline)]
        public EncodedRoutine(asci32[] name, EncodedInstruction[] buffer, uint[] index)
        {
            this.name = name;
            this.buffer = buffer;
            this.index = index;
        }

        public bool HasCapacity
        {
            [MethodImpl(Inline)]
            get => Index < buffer.Length - 1;
        }

        [MethodImpl(Inline)]
        public EncodedRoutine Add(in EncodedInstruction command)
        {
            if(HasCapacity)
                seek(buffer, Index++) = command;
            return this;
        }

        static EncodedAsmRoutine Emit(in EncodedRoutine builder)
        {
            var f = new EncodedAsmRoutine(first(builder.name), builder.buffer.ToArray());
            builder.Index = 0;
            builder.Name = asci32.Null;
            builder.buffer.Clear();
            return f;
        }

        public EncodedAsmRoutine Emit()
            => Emit(this);

        ref uint Index
        {
            [MethodImpl(Inline)]
            get => ref first(index);
        }

        ref asci32 Name
        {
            [MethodImpl(Inline)]
            get => ref first(name);
        }

        [MethodImpl(Inline)]
        static ref readonly EncodedRoutine Add(in EncodedRoutine dst, in EncodedInstruction src)
        {
            dst.Add(src);
            return ref dst;
        }
    }
}