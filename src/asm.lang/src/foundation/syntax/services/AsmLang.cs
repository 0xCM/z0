//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMnemonicCode;
    using static AsmRegOps;
    using static memory;

    [ApiHost]
    public ref struct AsmLang
    {
        public static AsmLang create()
            => new AsmLang(new char[64]);

        const string BufferOut ="<buffer-out>";

        readonly Span<char> Buffer;

        readonly Index<AsmMnemonicCode, Sym<AsmMnemonicCode>> Codes;

        readonly Index<Gp8, Sym<Gp8>> Gp8Sym;

        readonly Index<Gp16, Sym<Gp16>> Gp16Sym;

        readonly Index<Gp32, Sym<Gp32>> Gp32Sym;

        readonly Index<Gp64, Sym<Gp64>> Gp64Sym;

        AsmLang(Span<char> buffer)
        {
            Buffer = buffer;
            Codes = Symbols.cache<AsmMnemonicCode>().Index;
            Gp8Sym = Symbols.cache<Gp8>().Index;
            Gp16Sym =Symbols.cache<Gp16>().Index;
            Gp32Sym =Symbols.cache<Gp32>().Index;
            Gp64Sym =Symbols.cache<Gp64>().Index;
        }

        void Clear()
        {
            first(recover<char,CharBlock64>(Buffer)) = CharBlock64.Null;
        }

        byte Capacity
        {
            get => (byte)Buffer.Length;
        }

        [MethodImpl(Inline), Op]
        ReadOnlySpan<char> Symbol(AsmMnemonicCode code)
            => Codes[code].Expr.Data;

        [MethodImpl(Inline), Op]
        ReadOnlySpan<char> Symbol(Gp8 code)
            => Gp8Sym[code].Expr.Data;

        [MethodImpl(Inline), Op]
        void Copy(ReadOnlySpan<char> src, Span<char> dst)
        {
            var count = root.min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);

        }


        // 22 /r            | AND r8, r/m8     | RM    | Valid       | Valid           | r8 AND r/m8.                              |
        [Op]
        public ReadOnlySpan<char> and(r8 dst, r8 src)
        {
            Clear();

            byte j = 0;
            byte l = 0;
            var monic = Symbol(AND);
            var op0 = Symbol(dst);
            var op1 = Symbol(src);
            var required = (byte)(monic.Length + 1 + op0.Length + 1 + op1.Length);
            if(required > Capacity)
            {
                Copy(BufferOut, Buffer);
                return Buffer;
            }

            ref var target = ref first(Buffer);

            l = (byte)monic.Length;
            for(var i=0; i<l; i++)
                seek(target,j++) = skip(monic,i);

            seek(target,j++) = Chars.Space;

            l = (byte)op0.Length;
            for(var i=0; i<l; i++)
                seek(target,j++) = skip(op0,i);

            seek(target,j++) = Chars.Comma;

            l = (byte)op1.Length;
            for(var i=0; i<l; i++)
                seek(target,j++) = skip(op1,i);

            return Buffer;
        }

    }
}