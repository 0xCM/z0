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

        [Op]
        public static Index<OpCodeSpec> opcodes()
        {
            var calcs = MC.calcs();
            var count = calcs.AsmCount;

            var buffer = alloc<OpCodeSpec>(count);
            ref var dst = ref first(buffer);
            var ids = calcs.AsmId();
            for(ushort i=0; i<count; i++)
            {
                ref readonly var id = ref skip(ids,i);
                ref readonly var sym = ref calcs.Sym(id);
                var opcode = calcs.OpCode(id);
                ref var record = ref seek(dst,i);
                record.Index = i;
                record.Mnemonic = calcs.Monic(id);
                record.OpId = sym.Name.Content.Content;
                record.OpCodeValue = opcode;
                record.OpCodeBytes = Hex.hexbytes(opcode, LowerCase);
            }

            Array.Sort(buffer);
            return buffer;
        }
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
            ReadOnlySpan<char> Monic(uint id)
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
                => canonicalize(Monic(index(id)));

            public Index<string> Monics()
            {
                var count = AsmCount;
                var length = 0;
                var set = hashset<string>();
                for(ushort i=0; i<count; i++)
                    set.Add(Monic((AsmId)i));
                Index<string> distinct = set.Array();
                distinct.Sort();
                return distinct;
            }

            [MethodImpl(Inline), Op]
            public ReadOnlySpan<AsmId> AsmId()
                => _AsmId;

            [MethodImpl(Inline), Op]
            public ref readonly Sym Sym(AsmId id)
                => ref skip(_AsmIdSym, u32(id));

            [MethodImpl(Inline), Op]
            public ulong OpCode(uint id)
            {
                ulong Bits = 0;
                Bits |= (ulong)skip(OpInfo0, id) << 0;
                Bits |= (ulong)skip(OpInfo1, id) << 32;
                return Bits;
            }

            [MethodImpl(Inline), Op]
            public Hex64 OpCode(AsmId id)
                => OpCode(u32(id));

            [MethodImpl(Inline), Op]
            public uint MonicOffset(AsmId id)
                => offset(OpCode(id));

            [MethodImpl(Inline), Op]
            public uint MonicLength(AsmId id)
                => AsmLength(offset(OpCode(id)));

            [MethodImpl(Inline)]
            static uint index(AsmId id)
                => u32(id);

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
                var length = src.Length;
                if(length == 0)
                    return RP.Empty;

                var result = text.format(src).Replace(Chars.Tab, Chars.Space).Trim();
                if(text.empty(result))
                    return RP.Empty;

                if(result.StartsWith(Chars.Hash))
                    return RP.Empty;

                return
                    result.Replace(" ax,", EmptyString)
                          .Replace(" al,", EmptyString)
                          .Replace(" eax,", EmptyString)
                          .Replace(" rax,",EmptyString).Replace(" st,", String.Empty);
            }
        }
    }
}