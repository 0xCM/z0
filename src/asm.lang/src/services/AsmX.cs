//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public partial struct AsmX
    {
        public static AsmX create()
            => new AsmX(new char[128]);

        readonly AsmSymbols S;

        public AsmSymbols SymbolSet
        {
            [MethodImpl(Inline), Op]
            get => S;
        }

        readonly Index<char> Buffer;

        byte Position;

        AsmX(Index<char> buffer)
        {
            Buffer = buffer;
            S = AsmSymbols.create();
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
        AsmExpr Produce<A,B>(Sym<A> a, Sym<B> b, Imm8 c)
            where A : unmanaged
            where B : unmanaged
                => Produce<A,B,byte>(a,b,c);

        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B>(Sym<A> a, Sym<B> b, Imm16 c)
            where A : unmanaged
            where B : unmanaged
                => Produce<A,B,ushort>(a,b,c);

        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B>(Sym<A> a, Sym<B> b, Imm32 c)
            where A : unmanaged
            where B : unmanaged
                => Produce<A,B,uint>(a,b,c);

        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B>(Sym<A> a, Sym<B> b, Imm64 c)
            where A : unmanaged
            where B : unmanaged
                => Produce<A,B,ulong>(a,b,c);


        [MethodImpl(Inline), Op]
        AsmExpr Produce<A,B,T>(Sym<A> a, Sym<B> b, Imm<T> c)
            where A : unmanaged
            where B : unmanaged
            where T : unmanaged
        {
            Clear();
            Render(a);
            Render(Chars.Space);
            Render(b);
            Render(Chars.Comma);
            Render(c);
            return Emit();
        }

        [Op]
        AsmExpr Emit()
            => slice(Buffer.Edit, 0, Position);

        [Op]
        void Render<T>(Imm<T> src)
            where T : unmanaged
                => Render("0" + src.Format());

        [MethodImpl(Inline), Op]
        void Render(char src)
            => Buffer[Position++] = src;

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
    }
}