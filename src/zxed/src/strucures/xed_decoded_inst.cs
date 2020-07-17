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
    using static Xed;

    /// The main container for instructions. After decode, it holds an array of
    /// operands with derived information from decode and also valid
    /// #xed_inst_t pointer which describes the operand templates and the
    /// operand order.  See @ref DEC for API documentation.
    [ApiHost]
    public struct xed_decoded_inst_t
    {
        [MethodImpl(Inline)]
        public static xed_decoded_inst_t init(byte? size = null)
            => new xed_decoded_inst_t(size ?? XED_ENCODE_ORDER_MAX_OPERANDS);

        /// The _operands are storage for information discovered during
        /// decoding. They are also used by encode.  The accessors for these
        /// operands all have the form xed3_operand_{get,set}_*(). They should
        /// be considered internal and subject to change over time. It is
        /// preferred that you use xed_decoded_inst_*() or the
        /// xed_operand_values_*() functions when available.
        public xed_operand_storage_t _operands;

        //public fixed byte _operand_order[XED_ENCODE_ORDER_MAX_OPERANDS];
        readonly byte[] _operand_order;

        // Length of the _operand_order[] array.
        public xed_uint8_t _n_operand_order; 

        readonly byte[] _enc_data;

        readonly byte[] _dec_data;

        public byte[] _enc
        {
            [MethodImpl(Inline), Op]
            get => _enc_data;
        }

        public byte[] _dec
        {
            [MethodImpl(Inline), Op]
            get => _dec_data;
        }

        public xed_uint8_t _decoded_length;

        public xed_inst_t _inst;

        /* user_data is available as a user data storage field after
         * decoding. It does not live across re-encodes or re-decodes. */
        public xed_uint64_t user_data; 

        public xed_encoder_vars_t ev;
        
        [MethodImpl(Inline), Op]
        xed_decoded_inst_t(xed_uint8_t size) 
        {
            _n_operand_order = size;
            _operand_order = Root.alloc<byte>(_n_operand_order);
            _enc_data = Root.array<byte>();
            _dec_data = Root.array<byte>();
            _decoded_length = default;
            _inst = default;
            ev = default;
            user_data = default;
            _operands = default;
        }

        public xed_uint8_t HasModRm
        {
            [MethodImpl(Inline), Op]
            get => _operands.has_modrm;
        }

        public xed_uint8_t Rm
        {
            [MethodImpl(Inline), Op]
            get => _operands.rm;
            [MethodImpl(Inline), Op]
            set => _operands.rm = value;
        }

        public xed_chip_enum_t Chip
        {
            [MethodImpl(Inline), Op]
            get => _operands.chip;

            [MethodImpl(Inline), Op]
            set => _operands.chip = value;
        }
    }
}