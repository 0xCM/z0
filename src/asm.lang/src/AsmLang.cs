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
    public ref partial struct AsmLang
    {
        public static AsmLang create()
            => new AsmLang(new char[64]);

        readonly AsmSymbols SymSpace;

        public AsmSymbols LangSymbols
        {
            [MethodImpl(Inline), Op]
            get => SymSpace;
        }

        readonly Span<char> Buffer;

        byte Position;

        readonly Symbols<AsmMnemonicCode> Codes;

        readonly Symbols<Gp8> Gp8Sym;

        readonly Symbols<Gp16> Gp16Sym;

        readonly Symbols<Gp32> Gp32Sym;

        readonly Symbols<Gp64> Gp64Sym;

        readonly Symbols<KReg> KRegSym;

        AsmLang(Span<char> buffer)
        {
            Buffer = buffer;
            SymSpace = AsmSymbols.create();
            Codes = Symbols.cache<AsmMnemonicCode>().Index;
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
                seek(Buffer, Position++) = skip(src,i);
        }

        [MethodImpl(Inline), Op]
        void Render<K>(Sym<K> src)
            where K : unmanaged
        {
            var data = src.Expr.Data;
            var len = data.Length;
            for(var i=0; i<len; i++)
                seek(Buffer, Position++) = skip(data,i);
        }

        [MethodImpl(Inline), Op]
        void Render(char src)
            => seek(Buffer, Position++) = src;

        [Op]
        public void Render(Imm64 src)
            => Render(src.Format());

        [MethodImpl(Inline), Op]
        AsmExpr Emit()
            => slice(Buffer, 0, Position);
    }
}