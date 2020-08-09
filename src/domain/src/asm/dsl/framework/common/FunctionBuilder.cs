//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct FunctionBuilder
    {
        internal readonly Span<asci32> name;

        internal readonly Span<EncodedCommand> buffer;

        internal readonly Span<uint> index;

        [MethodImpl(Inline)]
        public static FunctionBuilder operator +(in FunctionBuilder dst, in EncodedCommand src)
            => Add(dst, src);

        public static implicit operator function(FunctionBuilder src)
            => src.Emit();

        [MethodImpl(Inline)]
        public FunctionBuilder(string name, int capacity)
        {
            this.name = new asci32[1]{name};
            this.buffer = alloc<EncodedCommand>(capacity);
            this.index = new uint[1]{0};
        }

        [MethodImpl(Inline)]
        public FunctionBuilder(asci32[] name, EncodedCommand[] buffer, uint[] index)
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
        public FunctionBuilder Add(in EncodedCommand command)
        {
            if(HasCapacity)
                seek(buffer, Index++) = command;
            return this;
        }

        static function Emit(in FunctionBuilder builder)
        {
            var f = new function(first(builder.name), builder.buffer.ToArray());
            builder.Index = 0;
            builder.Name = asci32.Null;
            builder.buffer.Clear();
            return f;
        }

        public function Emit()
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
        static ref readonly FunctionBuilder Add(in FunctionBuilder dst, in EncodedCommand src)
        {
            dst.Add(src);
            return ref dst;
        }
    }
}