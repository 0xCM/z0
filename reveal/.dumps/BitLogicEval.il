// 2019-10-22 02:15:30:621
bit eval(ILogicExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: isinst Z0.Logix.ILogicVariable
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: brtrue.s IL_0036
    IL_000A: ldarg.0
    IL_000B: isinst Z0.Logix.IVariedLogicExpr
    IL_0010: stloc.1
    IL_0011: ldloc.1
    IL_0012: brtrue.s IL_003D
    IL_0014: ldarg.0
    IL_0015: isinst Z0.Logix.ILogicLiteral
    IL_001A: stloc.2
    IL_001B: ldloc.2
    IL_001C: brtrue.s IL_0044
    IL_001E: ldarg.0
    IL_001F: isinst Z0.Logix.ILogicOpExpr
    IL_0024: stloc.3
    IL_0025: ldloc.3
    IL_0026: brtrue.s IL_004B
    IL_0028: ldarg.0
    IL_0029: isinst Z0.Logix.IEqualityExpr
    IL_002E: stloc.s V_4
    IL_0030: ldloc.s V_4
    IL_0032: brtrue.s IL_0052
    IL_0034: br.s IL_005A
    IL_0036: ldloc.0
    IL_0037: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicVariable)
    IL_003C: ret
    IL_003D: ldloc.1
    IL_003E: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.IVariedLogicExpr)
    IL_0043: ret
    IL_0044: ldloc.2
    IL_0045: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicLiteral)
    IL_004A: ret
    IL_004B: ldloc.3
    IL_004C: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicOpExpr)
    IL_0051: ret
    IL_0052: ldloc.s V_4
    IL_0054: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.IEqualityExpr)
    IL_0059: ret
    IL_005A: ldarg.0
    IL_005B: call Z0.bit Z0.Logix.BitLogicEval::unhandled(Z0.Logix.ILogicExpr)
    IL_0060: ret

}
bit eval(ILogicVariable expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.Logix.ILogicExpr Z0.Logix.ILogicVariable::get_Value()
    IL_0006: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_000B: ret

}
bit eval(IVariedLogicExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.Logix.IExpr Z0.Logix.IVariedLogicExpr::get_BaseExpr()
    IL_0006: isinst Z0.Logix.ILogicExpr
    IL_000B: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0010: ret

}
bit eval(ILogicLiteral expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.bit Z0.Logix.ILogicLiteral::get_Value()
    IL_0006: ret

}
bit eval(ILogicOpExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: isinst Z0.Logix.IUnaryLogicOp
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: brtrue.s IL_0020
    IL_000A: ldarg.0
    IL_000B: isinst Z0.Logix.IBinaryLogicOp
    IL_0010: stloc.1
    IL_0011: ldloc.1
    IL_0012: brtrue.s IL_0027
    IL_0014: ldarg.0
    IL_0015: isinst Z0.Logix.ITernaryLogicOp
    IL_001A: stloc.2
    IL_001B: ldloc.2
    IL_001C: brtrue.s IL_002E
    IL_001E: br.s IL_0035
    IL_0020: ldloc.0
    IL_0021: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.IUnaryLogicOp)
    IL_0026: ret
    IL_0027: ldloc.1
    IL_0028: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.IBinaryLogicOp)
    IL_002D: ret
    IL_002E: ldloc.2
    IL_002F: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ITernaryLogicOp)
    IL_0034: ret
    IL_0035: ldarg.0
    IL_0036: call Z0.bit Z0.Logix.BitLogicEval::unhandled(Z0.Logix.ILogicExpr)
    IL_003B: ret

}
bit eval(IEqualityExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.Logix.ILogicExpr Z0.Logix.IEqualityExpr::get_Lhs()
    IL_0006: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_000B: ldarg.0
    IL_000C: callvirt Z0.Logix.ILogicExpr Z0.Logix.IEqualityExpr::get_Rhs()
    IL_0011: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0016: call System.Boolean Z0.bit::op_Equality(Z0.bit,Z0.bit)
    IL_001B: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_0020: ret

}
bit eval(IUnaryLogicOp expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.Logix.UnaryLogicOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.UnaryLogicOpKind>::get_OpKind()
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldc.i4.1
    IL_0009: beq.s IL_0011
    IL_000B: ldloc.0
    IL_000C: ldc.i4.2
    IL_000D: beq.s IL_0022
    IL_000F: br.s IL_002E
    IL_0011: ldarg.0
    IL_0012: callvirt Z0.Logix.ILogicExpr Z0.Logix.IUnaryLogicOp::get_Operand()
    IL_0017: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_001C: call Z0.bit Z0.bit::not(Z0.bit)
    IL_0021: ret
    IL_0022: ldarg.0
    IL_0023: callvirt Z0.Logix.ILogicExpr Z0.Logix.IUnaryLogicOp::get_Operand()
    IL_0028: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_002D: ret
    IL_002E: ldarg.0
    IL_002F: call Z0.bit Z0.Logix.BitLogicEval::unhandled(Z0.Logix.ILogicExpr)
    IL_0034: ret

}
bit eval(IBinaryLogicOp expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.Logix.BinaryLogicOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.BinaryLogicOpKind>::get_OpKind()
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldc.i4.1
    IL_0009: sub
    IL_000A: switch(IL_0099,IL_0109,IL_0109,IL_0109,IL_0109,IL_007D,IL_00B5,IL_0045,IL_00D1,IL_0109,IL_00ED)
    IL_003B: ldloc.0
    IL_003C: ldc.i4.s 14
    IL_003E: beq.s IL_0061
    IL_0040: br IL_0109
    IL_0045: ldarg.0
    IL_0046: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_004B: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0050: ldarg.0
    IL_0051: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_0056: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_005B: call Z0.bit Z0.bit::and(Z0.bit,Z0.bit)
    IL_0060: ret
    IL_0061: ldarg.0
    IL_0062: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_0067: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_006C: ldarg.0
    IL_006D: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_0072: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0077: call Z0.bit Z0.bit::or(Z0.bit,Z0.bit)
    IL_007C: ret
    IL_007D: ldarg.0
    IL_007E: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_0083: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0088: ldarg.0
    IL_0089: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_008E: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0093: call Z0.bit Z0.bit::xor(Z0.bit,Z0.bit)
    IL_0098: ret
    IL_0099: ldarg.0
    IL_009A: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_009F: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00A4: ldarg.0
    IL_00A5: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_00AA: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00AF: call Z0.bit Z0.bit::nor(Z0.bit,Z0.bit)
    IL_00B4: ret
    IL_00B5: ldarg.0
    IL_00B6: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_00BB: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00C0: ldarg.0
    IL_00C1: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_00C6: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00CB: call Z0.bit Z0.bit::nand(Z0.bit,Z0.bit)
    IL_00D0: ret
    IL_00D1: ldarg.0
    IL_00D2: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_00D7: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00DC: ldarg.0
    IL_00DD: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_00E2: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00E7: call Z0.bit Z0.bit::xnor(Z0.bit,Z0.bit)
    IL_00EC: ret
    IL_00ED: ldarg.0
    IL_00EE: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_00F3: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_00F8: ldarg.0
    IL_00F9: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_00FE: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0103: call Z0.bit Z0.bit::implies(Z0.bit,Z0.bit)
    IL_0108: ret
    IL_0109: ldarg.0
    IL_010A: call Z0.bit Z0.Logix.BitLogicEval::unhandled(Z0.Logix.ILogicExpr)
    IL_010F: ret

}
bit eval(ITernaryLogicOp expr)
{
    IL_0000: ldarg.0
    IL_0001: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_FirstArg()
    IL_0006: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_000B: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_0010: brtrue.s IL_001E
    IL_0012: ldarg.0
    IL_0013: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_ThirdArg()
    IL_0018: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_001D: ret
    IL_001E: ldarg.0
    IL_001F: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_SecondArg()
    IL_0024: call Z0.bit Z0.Logix.BitLogicEval::eval(Z0.Logix.ILogicExpr)
    IL_0029: ret

}
bit unhandled(ILogicExpr expr)
{
    IL_0000: ldstr "{0} unhandled"
    IL_0005: ldarg.0
    IL_0006: call System.String System.String::Format(System.String,System.Object)
    IL_000B: newobj System.Void System.Exception::.ctor(System.String)
    IL_0010: throw

}
