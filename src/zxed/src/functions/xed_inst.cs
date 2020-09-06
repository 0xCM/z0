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
    using static xed_nonterminal_enum_t;
    using static xed_reg_enum_t;
    using static xed_operand_type_enum_t;
    using static xed_operand_enum_t;

     [ApiHost]
     public readonly struct xed_inst
     {
          [MethodImpl(Inline), Op]
          public static xed_operand_enum_t xed_operand_name(in xed_operand_t p)
               => p._name;

          [MethodImpl(Inline), Op]
          public static xed_operand_visibility_enum_t xed_operand_visibility(in xed_operand_t p)
               => p._operand_visibility;

          // @ingroup DEC
          // @return The #xed_operand_type_enum_t of the operand template.
          // This is probably not what you want.
          [MethodImpl(Inline), Op]
          public static xed_operand_type_enum_t xed_operand_type(in xed_operand_t p)
               => (xed_operand_type_enum_t)p._type.data;

          // @ingroup DEC
          // @return The #xed_operand_element_xtype_enum_t of the operand template.
          // This is probably not what you want.
          [MethodImpl(Inline), Op]
          public static xed_operand_element_xtype_enum_t xed_operand_xtype(in xed_operand_t p)
               => p._xtype;

          [MethodImpl(Inline), Op]
          public static xed_operand_width_enum_t xed_operand_width(in xed_operand_t p)
               => p._oc2;

          [MethodImpl(Inline), Op]
          public static xed_nonterminal_enum_t xed_nonterminal_name(in xed_operand_t p)
               => p._nt ? p.u_nt : XED_NONTERMINAL_INVALID;

          // @ingroup DEC
          // Careful with this one -- use #xed_decoded_inst_get_reg()! This one is
          // probably not what you think it is. It is only used for hard-coded
          // registers implicit in the instruction encoding. Most likely you want to
          // get the #xed_operand_enum_t and then look up the instruction using
          // #xed_decoded_inst_get_reg(). The hard-coded registers are also available
          // that way.
          // @param p  an operand template,  #xed_operand_t.
          // @return  the implicit or suppressed registers, type #xed_reg_enum_t
          [MethodImpl(Inline), Op]
          public static xed_reg_enum_t xed_operand_reg(in xed_operand_t p)
               => xed_operand_type(p) == XED_OPERAND_TYPE_REG ? p.u_reg : XED_REG_INVALID;

          // Careful with this one; See #xed_operand_is_register().
          // @param p  an operand template,  #xed_operand_t.
          // @return 1 if the operand template represents are register-type
          // operand.

          //   Related functions:
          //    Use #xed_decoded_inst_get_reg() to get the decoded name of /// the
          //    register, #xed_reg_enum_t. Use #xed_operand_is_register() to test
          //    #xed_operand_enum_t names.
          [MethodImpl(Inline), Op]
          public static xed_uint32_t xed_operand_template_is_register(in xed_operand_t p)
               => p._nt || p._type == (byte)XED_OPERAND_TYPE_REG;


          // @ingroup DEC
          // @param p  an operand template,  #xed_operand_t.
          // These operands represent branch displacements, memory displacements and
          // various immediates
          [MethodImpl(Inline), Op]
          public static xed_uint32_t xed_operand_xmm(in xed_operand_t p)
               => xed_operand_type(p) == XED_OPERAND_TYPE_IMM_CONST ? p.u_imm : 0;


          // @name xed_inst_t Template Operand Enum Name Classification
          //@{
          // @ingroup DEC
          // Tests the enum for inclusion in XED_OPERAND_REG0 through XED_OPERAND_REG15.
          // @param name the operand name, type #xed_operand_enum_t
          // @return 1 if the operand name is REG0...REG15, 0 otherwise.
          //
          //Note there are other registers for memory addressing; See
          // #xed_operand_is_memory_addressing_register .
          [MethodImpl(Inline), Op]
          public static xed_uint32_t xed_operand_is_register(in xed_operand_enum_t name)
               => name >= XED_OPERAND_REG0 && name <= XED_OPERAND_REG8;


          /// @ingroup DEC
          /// Tests the enum for inclusion in XED_OPERAND_{BASE0,BASE1,INDEX,SEG0,SEG1}
          /// @param name the operand name, type #xed_operand_enum_t
          /// @return 1 if the operand name is for a memory addressing register operand, 0
          /// otherwise. See also #xed_operand_is_register .
          [MethodImpl(Inline), Op]
          public static xed_uint8_t xed_operand_is_memory_addressing_register(xed_operand_enum_t name)
               =>  name == XED_OPERAND_BASE0 ||
                   name == XED_OPERAND_INDEX ||
                   name == XED_OPERAND_SEG0  ||
                   name == XED_OPERAND_BASE1 ||
                   name == XED_OPERAND_SEG1;

          [MethodImpl(Inline), Op]
          public static xed_iform_enum_t xed_inst_iform_enum(in xed_inst_t p)
               => p._iform_enum;
     }
}