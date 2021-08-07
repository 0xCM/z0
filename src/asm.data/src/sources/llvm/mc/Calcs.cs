//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    [ApiHost("llvm.mc")]
    public readonly partial struct MC
    {
        [MethodImpl(NotInline), Op]
        public static Calcs calcs()
            => new Calcs(Symbols.index<AsmId>(), AsmStrs, OpInfo0, OpInfo1);

        [ApiHost("llvm.mc.calcs")]
        public readonly ref struct Calcs
        {
            readonly ReadOnlySpan<AsmId> _AsmId;

            readonly ReadOnlySpan<Sym> _AsmIdSym;

            readonly ReadOnlySpan<char> AsmStrs;

            readonly ReadOnlySpan<uint> OpInfo0;

            readonly ReadOnlySpan<uint> OpInfo1;

            [MethodImpl(Inline)]
            internal Calcs(Symbols<AsmId> asmid, ReadOnlySpan<char> strs, ReadOnlySpan<uint> a, ReadOnlySpan<uint> b)
            {
                _AsmId = asmid.Kinds;
                _AsmIdSym = asmid.Untyped().Storage;
                AsmStrs = strs;
                OpInfo0 = a;
                OpInfo1 = b;
                Require.equal(OpInfo0.Length, OpInfo1.Length);
            }

            public uint CharCount
            {
                [MethodImpl(Inline), Op]
                get => (uint)AsmStrs.Length;
            }

            public uint AsmCount
            {
                [MethodImpl(Inline), Op]
                get => (uint)OpInfo0.Length;
            }

            public uint OpInfoHiCount
            {
                [MethodImpl(Inline), Op]
                get => (uint)OpInfo1.Length;
            }

            [MethodImpl(Inline), Op]
            public ReadOnlySpan<char> Monic(ushort id)
            {
                var opcode = OpCode(id);
                var i = offset(opcode);
                var n = AsmLength(i);
                if(n != 0)
                    return slice(AsmStrs, i, n);
                else
                    return default;

                //return {AsmStrs+(Bits & 16383)-1, Bits};
            }

            [MethodImpl(Inline), Op]
            public string Monic(AsmId id)
                => canonicalize(Monic((ushort)id));

            [MethodImpl(Inline), Op]
            public ReadOnlySpan<AsmId> AsmId()
                => _AsmId;

            [MethodImpl(Inline), Op]
            public ref readonly Sym Sym(AsmId id)
                => ref skip(_AsmIdSym, (ushort)id);

            [MethodImpl(Inline), Op]
            public ulong OpCode(ushort id)
            {
                ulong Bits = 0;
                Bits |= (ulong)skip(OpInfo0, id) << 0;
                Bits |= (ulong)skip(OpInfo1, id) << 32;
                return Bits;
            }

            [MethodImpl(Inline), Op]
            public Hex64 OpCode(AsmId id)
                => OpCode((ushort)id);

            [MethodImpl(Inline), Op]
            public uint MonicOffset(AsmId id)
                => offset(OpCode(id));

            [MethodImpl(Inline), Op]
            public uint MonicLength(AsmId id)
                => AsmLength(offset(OpCode(id)));

            [MethodImpl(Inline), Op]
            public static uint offset(ulong bits)
                => (uint)((bits & 16383ul)-1);

            [MethodImpl(Inline), Op]
            uint AsmLength(uint offset)
            {
                var count = (uint)AsmStrs.Length;
                var n = z32;
                for(var i=offset; i<count; i++)
                {
                    ref readonly var c = ref skip(AsmStrs,i);
                    if(SQ.nil(c))
                        break;
                    else
                        n++;
                }
                return n;
            }

            [Op]
            static string canonicalize(ReadOnlySpan<char> src)
            {
                const string NA = "NA";
                var result = text.format(src).Replace(Chars.Tab,Chars.Space).Trim();
                if(empty(result))
                    result = NA;
                else
                {
                    var chars = text.span(result);
                    var count = chars.Length;
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var c = ref skip(chars,i);
                        switch(c)
                        {
                            case Chars.Hash:
                            case Chars.Comma:
                            case Chars.LBrace:
                            case Chars.Dollar:
                            case Chars.Underscore:
                            case Chars.Space:
                                result = NA;
                            break;
                        }
                    }
                }
                return result;
            }
        }
    }
}