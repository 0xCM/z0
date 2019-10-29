// 2019-10-28 07:21:27:495
ILogicDispatcher get_Instance()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Logix.LogicDispatcher
    IL_0008: ldloc.0
    IL_0009: box Z0.Logix.LogicDispatcher
    IL_000E: ret

}
bit unhandled(ILogicExpr expr)
{
    IL_0000: ldstr "{0} unhandled"
    IL_0005: ldarg.1
    IL_0006: call System.String System.String::Format(System.String,System.Object)
    IL_000B: newobj System.Void System.Exception::.ctor(System.String)
    IL_0010: throw

}
bit Dispatch(IComparisonExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: callvirt Z0.Logix.ILogicExpr Z0.Logix.IComparisonExpr::get_Lhs()
    IL_0007: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: callvirt Z0.Logix.ILogicExpr Z0.Logix.IComparisonExpr::get_Rhs()
    IL_0013: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_0018: call System.Boolean Z0.bit::op_Equality(Z0.bit,Z0.bit)
    IL_001D: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_0022: ret

}
bit Dispatch(ILogicVarExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: callvirt Z0.Logix.ILogicExpr Z0.Logix.ILogicVarExpr::get_Value()
    IL_0007: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_000C: ret

}
bit Dispatch(IVariedLogicExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: callvirt Z0.Logix.ILogicExpr Z0.Logix.IVariedLogicExpr::get_BaseExpr()
    IL_0007: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_000C: ret

}
bit Dispatch(ILogicLiteral expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.bit Z0.Logix.ILogicLiteral::get_Value()
    IL_0006: ret

}
bit Dispatch(IUnaryLogicOp expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.Logix.UnaryLogicOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.UnaryLogicOpKind>::get_OpKind()
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: callvirt Z0.Logix.ILogicExpr Z0.Logix.IUnaryOp`1<Z0.Logix.ILogicExpr>::get_Arg()
    IL_000D: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_0012: call Z0.bit Z0.Logix.LogicOpApi::eval(Z0.Logix.UnaryLogicOpKind,Z0.bit)
    IL_0017: ret

}
bit Dispatch(IBinaryLogicOp expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.Logix.BinaryLogicOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.BinaryLogicOpKind>::get_OpKind()
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_000D: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_0012: ldarg.0
    IL_0013: ldarg.1
    IL_0014: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_0019: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_001E: call Z0.bit Z0.Logix.LogicOpApi::eval(Z0.Logix.BinaryLogicOpKind,Z0.bit,Z0.bit)
    IL_0023: ret

}
bit Dispatch(ITernaryLogicOp expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.Logix.TernaryBitOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.TernaryBitOpKind>::get_OpKind()
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_FirstArg()
    IL_000D: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_0012: ldarg.0
    IL_0013: ldarg.1
    IL_0014: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_SecondArg()
    IL_0019: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_001E: ldarg.0
    IL_001F: ldarg.1
    IL_0020: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_ThirdArg()
    IL_0025: call Z0.bit Z0.Logix.LogicDispatcher::Eval(Z0.Logix.ILogicExpr)
    IL_002A: call Z0.bit Z0.Logix.LogicOpApi::eval(Z0.Logix.TernaryBitOpKind,Z0.bit,Z0.bit,Z0.bit)
    IL_002F: ret

}
