//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Part;

    public ref struct AsmMovHandler
    {
        readonly Span<Link<Imm64,IceRegister>> Buffer;

        int Index;

        [MethodImpl(Inline)]
        public AsmMovHandler(int capacity)
        {
            Buffer = new Link<Imm64,IceRegister>[capacity];
            Index = 0;
        }

        [MethodImpl(Inline)]
        public void Handle(in IceInstruction i)
        {
            if(i.Mnemonic == IceMnemonic.Mov && i.Op1Kind == IceOpKind.Immediate64 && i.Op0Kind == IceOpKind.Register)
                Handle(i.Immediate64, i.Op0Register);
        }

        public ReadOnlySpan<Link<Imm64,IceRegister>> Collected
        {
            [MethodImpl(Inline)]
            get => Buffer.Slice(0, Index);
        }

        public int CollectionCount
        {
            [MethodImpl(Inline)]
            get => Index;
        }

        Link<Imm64,IceRegister> this[int index]
        {
            [MethodImpl(Inline)]
            set => seek(Buffer, (uint)index) = value;
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
                this[Index++] = Graphs.link(src, dst);
        }
    }
}