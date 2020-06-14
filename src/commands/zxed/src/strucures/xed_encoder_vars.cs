//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    public struct xed_encoder_vars_t
    {
        /// _iforms is a dynamically generated structure containing the values of
        /// various encoding decisions
        public xed_encoder_iforms_t _iforms;
        
        // the index of the iform in the xed_encode_iform_db table
        public xed_uint16_t _iform_index;
        
        /// Encode output array size, specified by caller of xed_encode()
        public xed_uint32_t _ilen;

        /// Used portion of the encode output array
        public xed_uint32_t _olen;

        public xed_uint32_t _bit_offset;
    }
}