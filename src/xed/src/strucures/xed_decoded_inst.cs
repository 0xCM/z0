//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Xed;

    /// The main container for instructions. After decode, it holds an array of
    /// operands with derived information from decode and also valid
    /// #xed_inst_t pointer which describes the operand templates and the
    /// operand order.  See @ref DEC for API documentation.
    public unsafe struct xed_decoded_inst_s
    {
        /// The _operands are storage for information discovered during
        /// decoding. They are also used by encode.  The accessors for these
        /// operands all have the form xed3_operand_{get,set}_*(). They should
        /// be considered internal and subject to change over time. It is
        /// preferred that you use xed_decoded_inst_*() or the
        /// xed_operand_values_*() functions when available.
        public xed_operand_storage_t _operands;

        public fixed byte _operand_order[XED_ENCODE_ORDER_MAX_OPERANDS];

        // Length of the _operand_order[] array.
        public xed_uint8_t _n_operand_order; 

    }
}