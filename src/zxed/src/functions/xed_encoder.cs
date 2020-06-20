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
    using static Root;

    using static xed_operand_mode;

    public struct xed_encoder
    {
        xed_decoded_inst_t State;

        xed_operand_storage_t Operands
        {
            [MethodImpl(Inline)]
            get => State._operands;
        }

        [MethodImpl(Inline)]
        public static xed_encoder Init(in xed_decoded_inst_t state)
            => new xed_encoder(state);

        [MethodImpl(Inline)]
        public static xed_encoder Init()
            => new xed_encoder(default(xed_decoded_inst_t));

        [MethodImpl(Inline)]
        xed_encoder(in xed_decoded_inst_t state)
        {
            State = state;
        }

        /// <summary>
        /// mode64   NOREX=0  NEEDREX=1 REXW[w] REXB[b] REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline)]
        Option<byte> Test1()        
            => (Operands.mode == mode64 && !Operands.norex && Operands.needrex) 
                ? some((byte)1) 
                : none<byte>();        

        /// <summary>
        /// mode64   NOREX=0  REX=1     REXW[w] REXB[b] REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline)]
        Option<byte> Test2()
            => (Operands.mode == mode64 && !Operands.norex && Operands.rex) 
                ? some((byte)2) 
                : none<byte>();

        /// <summary>
        /// mode64   NOREX=0            REXW[w]=1 REXB[b] REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline)]
        Option<byte> Test3()
            => (Operands.mode == mode64 && !Operands.norex && Operands.rexw) 
                ? some((byte)3) 
                : none<byte>();
        
        /// <summary>
        /// mode64   NOREX=0            REXW[w] REXB[b]=1 REXX[x] REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline)]
        Option<byte> Test4()
            => (Operands.mode == mode64 && !Operands.norex && Operands.rexb) 
                ? some((byte)4) 
                : none<byte>();

        /// <summary>
        /// mode64   NOREX=0            REXW[w] REXB[b] REXX[x]=1 REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline)]
        Option<byte> Test5()
            => (Operands.mode == mode64 && !Operands.norex && Operands.rexx) 
                ? some((byte)5) 
                : none<byte>();

        /// <summary>
        /// mode64   NOREX=0            REXW[w] REXB[b] REXX[x]=1 REXR[r] -> 0b0100 wrxb
        /// </summary>
        [MethodImpl(Inline)]
        Option<byte> Test6()
            => (Operands.mode == mode64 && !Operands.norex && Operands.rexr) 
                ? some((byte)6) 
                : none<byte>();

        readonly Func<Option<byte>>[] Tests
            => new Func<Option<byte>>[]{Test1, Test2, Test3, Test4, Test5, Test6};

        // See xed-encoder-3.c xed_encode_nonterminal_REX_PREFIX_ENC_BIND
        public void rex_prefix_enc()
        {
            var tests = Tests;
            for(var i=0; i<tests.Length; i++)
            {
                var test = tests[i]();
                if(test)
                {
                    State.ev._iforms.x_REX_PREFIX_ENC = test.Value;                
                    break;
                }
            }
        }
    }
}