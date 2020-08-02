//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    /// <summary>
    /// 
    /// </summary>
    public enum xed_operand_element_type_enum_t : byte
    {

        /// <summary>
        /// None
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_INVALID,
    
        /// <summary>
        /// Unsigned integer
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_UINT, 
        
        /// <summary>
        /// Signed integer
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_INT, 
        
        /// <summary>
        /// 32b FP single precision
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_SINGLE, 
        
        /// <summary>
        /// 64b FP double precision
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_DOUBLE, 
        
        /// <summary>
        /// 80b FP x87
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_LONGDOUBLE, 
        
        /// <summary>
        /// 80b decimal BCD
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_LONGBCD, 
        
        /// <summary>
        ///  a structure of various fields
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_STRUCT, 
        
        /// <summary>
        /// depends on other fields in the instruction
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_VARIABLE,
        
        /// <summary>
        /// 16b floating point
        /// </summary>
        XED_OPERAND_ELEMENT_TYPE_FLOAT16, 
        
        XED_OPERAND_ELEMENT_TYPE_LAST
    }
}