//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly ref struct AsmMovHandler
    {
        readonly Span<Arrow<Imm64,IceRegister>> Buffer;

        readonly Span<int> I;

        [MethodImpl(Inline)]
        public AsmMovHandler(int capacity)
        {
            Buffer = new Arrow<Imm64,IceRegister>[capacity];
            I = new int[]{0};
        }

        [MethodImpl(Inline)]
        public void Handle(in Instruction i)
        {
            if(i.Mnemonic == Mnemonic.Mov && i.Op1Kind == OpKind.Immediate64 && i.Op0Kind == OpKind.Register)
                Handle(i.Immediate64, i.Op0Register);
        }

        public ReadOnlySpan<Arrow<Imm64,IceRegister>> Collected
        {
            [MethodImpl(Inline)]
            get => Buffer.Slice(0, Index);
        }

        public int CollectionCount
        {
            [MethodImpl(Inline)]
            get => Index;
        }

        Arrow<Imm64,IceRegister> this[int index]
        {
            [MethodImpl(Inline)]
            set => seek(Buffer, (uint)index) = value;
        }

        ref int Index
        {
            [MethodImpl(Inline)]
            get => ref z.first(I);
        }

        bool HasCapacity
        {
            [MethodImpl(Inline)]
            get => Index < Buffer.Length;
        }

        [MethodImpl(Inline)]
        void Handle(Imm64 src, IceRegister dst)
        {
            if(HasCapacity)
                this[Index++] = DataFlows.connect(src, dst);
        }
    }
}