//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Dsl;

    using static Root;
    using static Konst;

    public readonly ref struct MovHandler 
    {
        readonly Span<ArrowPath<imm64,Register>> Buffer;

        readonly Span<int> I;

        [MethodImpl(Inline)]
        public MovHandler(int capacity)
        {
            Buffer = new ArrowPath<imm64,Register>[capacity];
            I = new int[]{0};
        }

        [MethodImpl(Inline)]
        public void Handle(in Instruction i)
        {
            if(i.Mnemonic == Mnemonic.Mov && i.Op1Kind == OpKind.Immediate64 && i.Op0Kind == OpKind.Register)
                Handle(i.Immediate64, i.Op0Register);
        }

        public ReadOnlySpan<ArrowPath<imm64,Register>> Collected
        {
            [MethodImpl(Inline)]
            get => Buffer.Slice(0, Index);
        }

        public int CollectionCount
        {
            [MethodImpl(Inline)]
            get => Index;
        }

        ArrowPath<imm64,Register> this[int index]
        {
            [MethodImpl(Inline)]
            set => seek(Buffer,index) = value;
        }
        
        ref int Index
        {
            [MethodImpl(Inline)]
            get => ref Root.head(I);
        }
        
        bool HasCapacity
        {
            [MethodImpl(Inline)]
            get => Index < Buffer.Length;
        }
        
        [MethodImpl(Inline)]
        void Handle(imm64 src, Register dst)
        {
            if(HasCapacity)
                this[Index++] = Arrows.connect(src,dst);
        }   
    }
}