//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static xed_operand_mode;

    [ApiHost]
    public struct xed_encoder
    {
        xed_decoded_inst_t[] Storage;

        ref xed_decoded_inst_t State
        {
            [MethodImpl(Inline), Op]
            get => ref Storage[0];
        }

        ref xed_operand_storage_t Operands
        {
            [MethodImpl(Inline), Op]
            get => ref State._operands;
        }

        public static xed_encoder Init(in xed_decoded_inst_t state)
            => new xed_encoder(state);

        public static xed_encoder Init()
            => new xed_encoder(default(xed_decoded_inst_t));

        xed_encoder(in xed_decoded_inst_t state)
            => Storage = new xed_decoded_inst_t[1]{state};

        [MethodImpl(Inline), Op]
        public static byte? nullz(byte src)
            => src != 0 ? src : (byte?)null;

        [MethodImpl(Inline), Op]
        public static byte? eval(bool state)
            => nullz(z.@byte(state));

        /// <summary>
        /// mode64   NOREX=0  NEEDREX=1 REXW[w] REXB[b] REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline), Op]
        byte? Test1()
            => eval(Operands.mode == mode64 && !Operands.norex && Operands.needrex);

        /// <summary>
        /// mode64   NOREX=0  REX=1     REXW[w] REXB[b] REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline), Op]
        byte? Test2()
            => eval(Operands.mode == mode64 && !Operands.norex && Operands.rex);

        /// <summary>
        /// mode64   NOREX=0            REXW[w]=1 REXB[b] REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline), Op]
        byte? Test3()
            => eval(Operands.mode == mode64 && !Operands.norex && Operands.rexw);

        /// <summary>
        /// mode64   NOREX=0            REXW[w] REXB[b]=1 REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline), Op]
        byte? Test4()
            => eval(Operands.mode == mode64 && !Operands.norex && Operands.rexb);

        /// <summary>
        /// mode64   NOREX=0            REXW[w] REXB[b] REXX[x]=1 REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline), Op]
        byte? Test5()
            => eval(Operands.mode == mode64 && !Operands.norex && Operands.rexx);

        /// <summary>
        /// mode64   NOREX=0            REXW[w] REXB[b] REXX[x]=1 REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline), Op]
        byte? Test6()
            => eval(Operands.mode == mode64 && !Operands.norex && Operands.rexr);

        readonly Func<byte?>[] Tests
            => new Func<byte?>[]{Test1, Test2, Test3, Test4, Test5, Test6};

        // See xed-encoder-3.c xed_encode_nonterminal_REX_PREFIX_ENC_BIND
        [Op]
        public void rex_prefix_enc()
        {
            var tests = Tests;
            for(var i=0; i<tests.Length; i++)
            {
                var test = tests[i]();
                if(test.HasValue)
                {
                    State.ev._iforms.x_REX_PREFIX_ENC = test.Value;
                    break;
                }
            }
        }

        [Op]
        public static void rex_prefix_enc(ReadOnlySpan<Func<byte?>> tests, ref xed_decoded_inst_t state)
        {
            var count = tests.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var f = ref skip(tests,i);
                var test = f();
                if(test.HasValue)
                {
                    state.ev._iforms.x_REX_PREFIX_ENC = test.Value;
                    break;
                }
            }
        }
    }
}