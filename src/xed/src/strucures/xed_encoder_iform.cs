//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    public struct xed_encoder_iform_t
    {
        //index of the field binding function in xed_encode_fb_lu_table
        public xed_uint8_t _fb_ptrn_index;
        
        //index of the emit function in xed_encode_emit_lu_table
        public xed_uint8_t _emit_ptrn_index;
        
        public xed_uint8_t _nom_opcode;
        
        public xed_uint8_t _legacy_map;
        
        //start index of the field values in xed_encode_fb_values_table
        public xed_uint16_t _fb_values_index;    

    }

}