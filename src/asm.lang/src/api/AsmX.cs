//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public partial struct AsmX
    {
        public static AsmX create()
            => new AsmX(new char[64]);

        readonly AsmSymbols S;

        public AsmSymbols SymbolSet
        {
            [MethodImpl(Inline), Op]
            get => S;
        }

        readonly Index<char> Buffer;

        byte Position;

        readonly Symbols<AsmMnemonicCode> Codes;

        readonly Symbols<Gp8> Gp8Sym;

        readonly Symbols<Gp16> Gp16Sym;

        readonly Symbols<Gp32> Gp32Sym;

        readonly Symbols<Gp64> Gp64Sym;

        readonly Symbols<KReg> KRegSym;

        AsmX(Index<char> buffer)
        {
            Buffer = buffer;
            S = AsmSymbols.create();
            Codes = Symbols.cache<AsmMnemonicCode>();
            Gp8Sym = Symbols.cache<Gp8>();
            Gp16Sym = Symbols.cache<Gp16>();
            Gp32Sym = Symbols.cache<Gp32>();
            Gp64Sym = Symbols.cache<Gp64>();
            KRegSym = Symbols.cache<KReg>();
            Position = 0;
        }

        [MethodImpl(Inline), Op]
        void Clear()
        {
            first(recover<char,CharBlock64>(Buffer)) = CharBlock64.Null;
            Position = 0;
        }

        byte Capacity
        {
            [MethodImpl(Inline)]
            get => (byte)Buffer.Length;
        }

        [MethodImpl(Inline), Op]
        void Render(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Buffer[Position++] = skip(src,i);
        }

        [MethodImpl(Inline), Op]
        void Render<K>(Sym<K> src)
            where K : unmanaged
        {
            var data = src.Expr.Data;
            var len = data.Length;
            for(var i=0; i<len; i++)
                Buffer[Position++] = skip(data,i);
        }

        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B,C>(Sym<A> a, Sym<B> b, Sym<C> c)
            where A : unmanaged
            where B : unmanaged
            where C : unmanaged
        {
            Clear();
            Render(a);
            Render(Chars.Space);
            Render(b);
            Render(Chars.Comma);
            Render(c);
            return Emit();
        }

        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B>(Sym<A> a, Sym<B> b, Imm8 c)
            where A : unmanaged
            where B : unmanaged
        {
            Clear();
            Render(a);
            Render(Chars.Space);
            Render(b);
            Render(Chars.Comma);
            Render<byte>(c);
            return Emit();
        }

        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B>(Sym<A> a, Sym<B> b, Imm64 c)
            where A : unmanaged
            where B : unmanaged
        {
            Clear();
            Render(a);
            Render(Chars.Space);
            Render(b);
            Render(Chars.Comma);
            Render<ulong>(c);
            return Emit();
        }

        [MethodImpl(Inline), Op]
        void Render(char src)
            => Buffer[Position++] = src;

        [Op]
        public void Render<T>(Imm<T> src)
            where T : unmanaged
                => Render(src.Format());

        [Op]
        AsmExpr Emit()
            => slice(Buffer.Edit, 0, Position);
    }
}