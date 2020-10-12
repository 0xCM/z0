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
        [MethodImpl(Inline), Op]
        public static EncodedRoutine define(asci32[] name, EncodedInstruction[] commands, uint[] index)
            => new EncodedRoutine(name, commands, index);

        internal readonly Span<asci32> Identifier;

        internal readonly Span<EncodedInstruction> Buffer;

        internal readonly Span<uint> Index;

        [MethodImpl(Inline)]
        public static EncodedRoutine operator +(in EncodedRoutine dst, in EncodedInstruction src)
            => Add(dst, src);

        public static implicit operator EncodedData(EncodedRoutine src)
            => src.Emit();

        [MethodImpl(Inline)]
        public EncodedRoutine(string name, int capacity)
        {
            Identifier = new asci32[1]{name};
            Buffer = alloc<EncodedInstruction>(capacity);
            Index = new uint[1]{0};
        }

        [MethodImpl(Inline)]
        public EncodedRoutine(asci32[] name, EncodedInstruction[] buffer, uint[] index)
        {
            Identifier = name;
            Buffer = buffer;
            Index = index;
        }

        public bool HasCapacity
        {
            [MethodImpl(Inline)]
            get => Entry < Buffer.Length - 1;
        }

        [MethodImpl(Inline)]
        public EncodedRoutine Add(in EncodedInstruction command)
        {
            if(HasCapacity)
                seek(Buffer, Entry++) = command;
            return this;
        }

        static EncodedData Emit(in EncodedRoutine builder)
        {
            var f = new EncodedData(first(builder.Identifier), builder.Buffer.ToArray());
            builder.Entry = 0;
            builder.Name = asci32.Null;
            builder.Buffer.Clear();
            return f;
        }

        public EncodedData Emit()
            => Emit(this);

        ref uint Entry
        {
            [MethodImpl(Inline)]
            get => ref first(Index);
        }

        ref asci32 Name
        {
            [MethodImpl(Inline)]
            get => ref first(Identifier);
        }

        [MethodImpl(Inline)]
        static ref readonly EncodedRoutine Add(in EncodedRoutine dst, in EncodedInstruction src)
        {
            dst.Add(src);
            return ref dst;
        }

        public readonly struct EncodedData
        {
            public readonly asci32 Name;

            public readonly EncodedInstruction[] Commands;

            [MethodImpl(Inline)]
            public EncodedData(asci32 name, EncodedInstruction[] commands)
            {
                Name = name;
                Commands = commands;
            }

            public ref EncodedInstruction this[int index]
            {
                [MethodImpl(Inline)]
                get => ref Commands[index];
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Commands.Length == 0;
            }
        }

    }
}