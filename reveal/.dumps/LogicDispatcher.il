// 2019-10-22 17:23:24:398
bit unhandled(ILogicExpr expr)
{
    IL_0000: ldstr "{0} unhandled"
    IL_0005: ldarg.1
    IL_0006: call System.String System.String::Format(System.String,System.Object)
    IL_000B: newobj System.Void System.Exception::.ctor(System.String)
    IL_0010: throw

}
bit Dispatch(IEqualityExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: callvirt Z0.Logix.ILogicExpr Z0.Logix.IEqualityExpr::get_Lhs()
    IL_0007: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: callvirt Z0.Logix.ILogicExpr Z0.Logix.IEqualityExpr::get_Rhs()
    IL_0013: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_0018: call System.Boolean Z0.bit::op_Equality(Z0.bit,Z0.bit)
    IL_001D: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_0022: ret

}
bit Dispatch(ILogicVariable expr)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: callvirt Z0.Logix.ILogicExpr Z0.Logix.ILogicVariable::get_Value()
    IL_0007: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_000C: ret

}
bit Dispatch(IVariedLogicExpr expr)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: callvirt Z0.Logix.ILogicExpr Z0.Logix.IVariedLogicExpr::get_BaseExpr()
    IL_0007: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
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
    IL_0006: call Z0.UnaryOp`1<Z0.bit> Z0.Logix.BitOpApi::lookup(Z0.Logix.UnaryLogicOpKind)
    IL_000B: ldarg.0
    IL_000C: ldarg.1
    IL_000D: callvirt Z0.Logix.ILogicExpr Z0.Logix.IUnaryLogicOp::get_Operand()
    IL_0012: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_0017: callvirt Z0.bit Z0.UnaryOp`1<Z0.bit>::Invoke(Z0.bit)
    IL_001C: ret

}
bit Dispatch(IBinaryLogicOp expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.Logix.BinaryLogicOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.BinaryLogicOpKind>::get_OpKind()
    IL_0006: call Z0.BinaryOp`1<Z0.bit> Z0.Logix.BitOpApi::lookup(Z0.Logix.BinaryLogicOpKind)
    IL_000B: ldarg.0
    IL_000C: ldarg.1
    IL_000D: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_LeftArg()
    IL_0012: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_0017: ldarg.0
    IL_0018: ldarg.1
    IL_0019: callvirt Z0.Logix.ILogicExpr Z0.Logix.IBinaryLogicOp::get_RightArg()
    IL_001E: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_0023: callvirt Z0.bit Z0.BinaryOp`1<Z0.bit>::Invoke(Z0.bit,Z0.bit)
    IL_0028: ret

}
bit Dispatch(ITernaryLogicOp expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.Logix.TernaryLogicOpKind Z0.Logix.ILogicOpExpr`1<Z0.Logix.TernaryLogicOpKind>::get_OpKind()
    IL_0006: call Z0.TernaryOp`1<Z0.bit> Z0.Logix.BitOpApi::lookup(Z0.Logix.TernaryLogicOpKind)
    IL_000B: ldarg.0
    IL_000C: ldarg.1
    IL_000D: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_FirstArg()
    IL_0012: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_0017: ldarg.0
    IL_0018: ldarg.1
    IL_0019: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_SecondArg()
    IL_001E: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_0023: ldarg.0
    IL_0024: ldarg.1
    IL_0025: callvirt Z0.Logix.ILogicExpr Z0.Logix.ITernaryLogicOp::get_ThirdArg()
    IL_002A: call Z0.bit Z0.Logix.LogicDispatcher::Route(Z0.Logix.ILogicExpr)
    IL_002F: callvirt Z0.bit Z0.TernaryOp`1<Z0.bit>::Invoke(Z0.bit,Z0.bit,Z0.bit)
    IL_0034: ret

}
void EnableTrace(bool enable)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stfld System.Boolean Z0.Logix.LogicDispatcher::Trace
    IL_0007: ret

}
bit Route_Dynamic(ILogicExpr expr)
{
    IL_0000: ldsfld System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>> Z0.Logix.LogicDispatcher/<>o__12::<>p__1
    IL_0005: brtrue.s IL_002B
    IL_0007: ldc.i4.0
    IL_0008: ldtoken Z0.bit
    IL_000D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0012: ldtoken Z0.Logix.LogicDispatcher
    IL_0017: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_001C: call System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder::Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags,System.Type,System.Type)
    IL_0021: call System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>> System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>>::Create(System.Runtime.CompilerServices.CallSiteBinder)
    IL_0026: stsfld System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>> Z0.Logix.LogicDispatcher/<>o__12::<>p__1
    IL_002B: ldsfld System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>> Z0.Logix.LogicDispatcher/<>o__12::<>p__1
    IL_0030: ldfld System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit> System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>>::Target
    IL_0035: ldsfld System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>> Z0.Logix.LogicDispatcher/<>o__12::<>p__1
    IL_003A: ldsfld System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>> Z0.Logix.LogicDispatcher/<>o__12::<>p__0
    IL_003F: brtrue.s IL_007B
    IL_0041: ldc.i4.2
    IL_0042: ldstr "Dispatch"
    IL_0047: ldnull
    IL_0048: ldtoken Z0.Logix.LogicDispatcher
    IL_004D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0052: ldc.i4.2
    IL_0053: newarr Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo
    IL_0058: dup
    IL_0059: ldc.i4.0
    IL_005A: ldc.i4.1
    IL_005B: ldnull
    IL_005C: call Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo::Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags,System.String)
    IL_0061: stelem.ref
    IL_0062: dup
    IL_0063: ldc.i4.1
    IL_0064: ldc.i4.0
    IL_0065: ldnull
    IL_0066: call Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo::Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags,System.String)
    IL_006B: stelem.ref
    IL_006C: call System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder::InvokeMember(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags,System.String,System.Collections.Generic.IEnumerable`1<System.Type>,System.Type,System.Collections.Generic.IEnumerable`1<Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo>)
    IL_0071: call System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>> System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>>::Create(System.Runtime.CompilerServices.CallSiteBinder)
    IL_0076: stsfld System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>> Z0.Logix.LogicDispatcher/<>o__12::<>p__0
    IL_007B: ldsfld System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>> Z0.Logix.LogicDispatcher/<>o__12::<>p__0
    IL_0080: ldfld System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object> System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>>::Target
    IL_0085: ldsfld System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>> Z0.Logix.LogicDispatcher/<>o__12::<>p__0
    IL_008A: ldarg.0
    IL_008B: ldarg.1
    IL_008C: callvirt System.Object System.Func`4<System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object,System.Object>::Invoke(System.Runtime.CompilerServices.CallSite,Z0.Logix.LogicDispatcher,System.Object)
    IL_0091: callvirt Z0.bit System.Func`3<System.Runtime.CompilerServices.CallSite,System.Object,Z0.bit>::Invoke(System.Runtime.CompilerServices.CallSite,System.Object)
    IL_0096: ret

}
bit Route1(ILogicExpr expr)
{
    IL_0000: ldarg.1
    IL_0001: isinst Z0.Logix.ILogicLiteral
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: brtrue.s IL_004E
    IL_000A: ldarg.1
    IL_000B: isinst Z0.Logix.IEqualityExpr
    IL_0010: stloc.1
    IL_0011: ldloc.1
    IL_0012: brtrue.s IL_0056
    IL_0014: ldarg.1
    IL_0015: isinst Z0.Logix.ILogicVariable
    IL_001A: stloc.2
    IL_001B: ldloc.2
    IL_001C: brtrue.s IL_005E
    IL_001E: ldarg.1
    IL_001F: isinst Z0.Logix.IVariedLogicExpr
    IL_0024: stloc.3
    IL_0025: ldloc.3
    IL_0026: brtrue.s IL_0066
    IL_0028: ldarg.1
    IL_0029: isinst Z0.Logix.IBinaryLogicOp
    IL_002E: stloc.s V_4
    IL_0030: ldloc.s V_4
    IL_0032: brtrue.s IL_006E
    IL_0034: ldarg.1
    IL_0035: isinst Z0.Logix.IUnaryLogicOp
    IL_003A: stloc.s V_5
    IL_003C: ldloc.s V_5
    IL_003E: brtrue.s IL_0077
    IL_0040: ldarg.1
    IL_0041: isinst Z0.Logix.ITernaryLogicOp
    IL_0046: stloc.s V_6
    IL_0048: ldloc.s V_6
    IL_004A: brtrue.s IL_0080
    IL_004C: br.s IL_0089
    IL_004E: ldarg.0
    IL_004F: ldloc.0
    IL_0050: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.ILogicLiteral)
    IL_0055: ret
    IL_0056: ldarg.0
    IL_0057: ldloc.1
    IL_0058: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IEqualityExpr)
    IL_005D: ret
    IL_005E: ldarg.0
    IL_005F: ldloc.2
    IL_0060: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.ILogicVariable)
    IL_0065: ret
    IL_0066: ldarg.0
    IL_0067: ldloc.3
    IL_0068: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IVariedLogicExpr)
    IL_006D: ret
    IL_006E: ldarg.0
    IL_006F: ldloc.s V_4
    IL_0071: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IBinaryLogicOp)
    IL_0076: ret
    IL_0077: ldarg.0
    IL_0078: ldloc.s V_5
    IL_007A: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IUnaryLogicOp)
    IL_007F: ret
    IL_0080: ldarg.0
    IL_0081: ldloc.s V_6
    IL_0083: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.ITernaryLogicOp)
    IL_0088: ret
    IL_0089: ldarg.0
    IL_008A: ldarg.1
    IL_008B: call Z0.bit Z0.Logix.LogicDispatcher::unhandled(Z0.Logix.ILogicExpr)
    IL_0090: ret

}
bit Route(ILogicExpr expr)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.Logix.LogicExprKind Z0.Logix.ILogicExpr::get_ExprKind()
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: switch(IL_0045,IL_0052,IL_002B,IL_006C,IL_005F,IL_0079,IL_0038)
    IL_0029: br.s IL_0086
    IL_002B: ldarg.0
    IL_002C: ldarg.1
    IL_002D: castclass Z0.Logix.ILogicLiteral
    IL_0032: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.ILogicLiteral)
    IL_0037: ret
    IL_0038: ldarg.0
    IL_0039: ldarg.1
    IL_003A: castclass Z0.Logix.IEqualityExpr
    IL_003F: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IEqualityExpr)
    IL_0044: ret
    IL_0045: ldarg.0
    IL_0046: ldarg.1
    IL_0047: castclass Z0.Logix.ILogicVariable
    IL_004C: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.ILogicVariable)
    IL_0051: ret
    IL_0052: ldarg.0
    IL_0053: ldarg.1
    IL_0054: castclass Z0.Logix.IVariedLogicExpr
    IL_0059: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IVariedLogicExpr)
    IL_005E: ret
    IL_005F: ldarg.0
    IL_0060: ldarg.1
    IL_0061: castclass Z0.Logix.IBinaryLogicOp
    IL_0066: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IBinaryLogicOp)
    IL_006B: ret
    IL_006C: ldarg.0
    IL_006D: ldarg.1
    IL_006E: castclass Z0.Logix.IUnaryLogicOp
    IL_0073: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IUnaryLogicOp)
    IL_0078: ret
    IL_0079: ldarg.0
    IL_007A: ldarg.1
    IL_007B: castclass Z0.Logix.ITernaryLogicOp
    IL_0080: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.ITernaryLogicOp)
    IL_0085: ret
    IL_0086: ldarg.0
    IL_0087: ldarg.1
    IL_0088: call Z0.bit Z0.Logix.LogicDispatcher::unhandled(Z0.Logix.ILogicExpr)
    IL_008D: ret

}
bit Satisfied(EqualityExpr expr, bit a, bit b)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: ldarg.3
    IL_0003: callvirt System.Void Z0.Logix.EqualityExpr::SetVars(Z0.bit,Z0.bit)
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call Z0.bit Z0.Logix.LogicDispatcher::Dispatch(Z0.Logix.IEqualityExpr)
    IL_000F: ret

}
