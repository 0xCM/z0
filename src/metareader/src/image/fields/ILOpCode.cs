//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum ILOpCode : ushort
    {
        Nop = (ushort)0,
    
        Break = (ushort)1,
    
        Ldarg_0 = (ushort)2,
    
        Ldarg_1 = (ushort)3,
    
        Ldarg_2 = (ushort)4,
    
        Ldarg_3 = (ushort)5,
    
        Ldloc_0 = (ushort)6,
    
        Ldloc_1 = (ushort)7,
    
        Ldloc_2 = (ushort)8,
    
        Ldloc_3 = (ushort)9,
    
        Stloc_0 = (ushort)10,
    
        Stloc_1 = (ushort)11,
    
        Stloc_2 = (ushort)12,
    
        Stloc_3 = (ushort)13,
    
        Ldarg_s = (ushort)14,
    
        Ldarga_s = (ushort)15,
    
        Starg_s = (ushort)16,
    
        Ldloc_s = (ushort)17,
    
        Ldloca_s = (ushort)18,
    
        Stloc_s = (ushort)19,
    
        Ldnull = (ushort)20,
    
        Ldc_i4_m1 = (ushort)21,
        Ldc_i4_0 = (ushort)22,
        Ldc_i4_1 = (ushort)23,
        Ldc_i4_2 = (ushort)24,
        Ldc_i4_3 = (ushort)25,
        Ldc_i4_4 = (ushort)26,
        Ldc_i4_5 = (ushort)27,
        Ldc_i4_6 = (ushort)28,
        Ldc_i4_7 = (ushort)29,
        Ldc_i4_8 = (ushort)30,
        Ldc_i4_s = (ushort)31,
        Ldc_i4 = (ushort)32,
        Ldc_i8 = (ushort)33,
        Ldc_r4 = (ushort)34,
        Ldc_r8 = (ushort)35,
        Dup = (ushort)37,
        Pop = (ushort)38,
        Jmp = (ushort)39,
        Call = (ushort)40,
        Calli = (ushort)41,
        Ret = (ushort)42,
        Br_s = (ushort)43,
        Brfalse_s = (ushort)44,
        Brtrue_s = (ushort)45,
        Beq_s = (ushort)46,
        Bge_s = (ushort)47,
        Bgt_s = (ushort)48,
        Ble_s = (ushort)49,
        Blt_s = (ushort)50,
        Bne_un_s = (ushort)51,
        Bge_un_s = (ushort)52,
        Bgt_un_s = (ushort)53,
        Ble_un_s = (ushort)54,
        Blt_un_s = (ushort)55,
        Br = (ushort)56,
        Brfalse = (ushort)57,
        Brtrue = (ushort)58,
        Beq = (ushort)59,
        Bge = (ushort)60,
        Bgt = (ushort)61,
        Ble = (ushort)62,
        Blt = (ushort)63,
        Bne_un = (ushort)64,
        Bge_un = (ushort)65,
        Bgt_un = (ushort)66,
        Ble_un = (ushort)67,
        Blt_un = (ushort)68,
        Switch = (ushort)69,
        Ldind_i1 = (ushort)70,
        Ldind_u1 = (ushort)71,
        
        Ldind_i2 = (ushort)72,
        
        Ldind_u2 = (ushort)73,
        
        Ldind_i4 = (ushort)74,
        
        Ldind_u4 = (ushort)75,
        
        Ldind_i8 = (ushort)76,
        
        Ldind_i = (ushort)77,
        
        Ldind_r4 = (ushort)78,
        
        Ldind_r8 = (ushort)79,
        
        Ldind_ref = (ushort)80,
        
        Stind_ref = (ushort)81,
        
        Stind_i1 = (ushort)82,
        
        Stind_i2 = (ushort)83,
        
        Stind_i4 = (ushort)84,
        
        Stind_i8 = (ushort)85,
        
        Stind_r4 = (ushort)86,
        
        Stind_r8 = (ushort)87,
        
        Add = (ushort)88,
        
        Sub = (ushort)89,
        
        Mul = (ushort)90,
        
        Div = (ushort)91,
        
        Div_un = (ushort)92,
        
        Rem = (ushort)93,
        
        Rem_un = (ushort)94,
        
        And = (ushort)95,
        
        Or = (ushort)96,
        
        Xor = (ushort)97,
        
        Shl = (ushort)98,
        
        Shr = (ushort)99,
        
        Shr_un = (ushort)100,
        
        Neg = (ushort)101,
        
        Not = (ushort)102,
        
        Conv_i1 = (ushort)103,
        
        Conv_i2 = (ushort)104,
        
        Conv_i4 = (ushort)105,
        
        Conv_i8 = (ushort)106,
        
        Conv_r4 = (ushort)107,
        
        Conv_r8 = (ushort)108,
        
        Conv_u4 = (ushort)109,
        
        Conv_u8 = (ushort)110,
        
        Callvirt = (ushort)111,
        
        Cpobj = (ushort)112,
        
        Ldobj = (ushort)113,
        
        Ldstr = (ushort)114,
        
        Newobj = (ushort)115,
        
        Castclass = (ushort)116,
        
        Isinst = (ushort)117,
        
        Conv_r_un = (ushort)118,
        
        Unbox = (ushort)121,
        Throw = (ushort)122,
        Ldfld = (ushort)123,
        Ldflda = (ushort)124,
        Stfld = (ushort)125,
        Ldsfld = (ushort)126,
        Ldsflda = (ushort)127,
        Stsfld = (ushort)128,
        Stobj = (ushort)129,
        Conv_ovf_i1_un = (ushort)130,
        Conv_ovf_i2_un = (ushort)131,
        Conv_ovf_i4_un = (ushort)132,
        Conv_ovf_i8_un = (ushort)133,
        Conv_ovf_u1_un = (ushort)134,
        Conv_ovf_u2_un = (ushort)135,
        Conv_ovf_u4_un = (ushort)136,
        Conv_ovf_u8_un = (ushort)137,
        Conv_ovf_i_un = (ushort)138,
        Conv_ovf_u_un = (ushort)139,
        Box = (ushort)140,
        Newarr = (ushort)141,
        Ldlen = (ushort)142,
        Ldelema = (ushort)143,
        
        Ldelem_i1 = (ushort)144,
        
        Ldelem_u1 = (ushort)145,
        
        Ldelem_i2 = (ushort)146,
        
        Ldelem_u2 = (ushort)147,
        
        Ldelem_i4 = (ushort)148,
        
        Ldelem_u4 = (ushort)149,
                    
        Ldelem_i8 = (ushort)150,
        
        Ldelem_i = (ushort)151,
        
        Ldelem_r4 = (ushort)152,
        
        Ldelem_r8 = (ushort)153,
        
        Ldelem_ref = (ushort)154,
        
        Stelem_i = (ushort)155,
        
        Stelem_i1 = (ushort)156,
        
        Stelem_i2 = (ushort)157,
        
        Stelem_i4 = (ushort)158,
        
        Stelem_i8 = (ushort)159,
        
        Stelem_r4 = (ushort)160,
        
        Stelem_r8 = (ushort)161,
        
        Stelem_ref = (ushort)162,
        
        Ldelem = (ushort)163,
        
        Stelem = (ushort)164,
        
        Unbox_any = (ushort)165,
        
        Conv_ovf_i1 = (ushort)179,
        
        Conv_ovf_u1 = (ushort)180,
        
        Conv_ovf_i2 = (ushort)181,
        
        Conv_ovf_u2 = (ushort)182,
        
        Conv_ovf_i4 = (ushort)183,
        
        Conv_ovf_u4 = (ushort)184,
        Conv_ovf_i8 = (ushort)185,
        Conv_ovf_u8 = (ushort)186,
        Refanyval = (ushort)194,
        Ckfinite = (ushort)195,
        Mkrefany = (ushort)198,
        Ldtoken = (ushort)208,
        Conv_u2 = (ushort)209,
        Conv_u1 = (ushort)210,
        Conv_i = (ushort)211,
        Conv_ovf_i = (ushort)212,
        Conv_ovf_u = (ushort)213,
        Add_ovf = (ushort)214,
        Add_ovf_un = (ushort)215,
        Mul_ovf = (ushort)216,
        Mul_ovf_un = (ushort)217,
        Sub_ovf = (ushort)218,
        Sub_ovf_un = (ushort)219,
        Endfinally = (ushort)220,
        Leave = (ushort)221,
        Leave_s = (ushort)222,
        Stind_i = (ushort)223,
        Conv_u = (ushort)224,
        Arglist = (ushort)65024,
        Ceq = (ushort)65025,
        Cgt = (ushort)65026,
        Cgt_un = (ushort)65027,
        Clt = (ushort)65028,
        Clt_un = (ushort)65029,
        Ldftn = (ushort)65030,
        Ldvirtftn = (ushort)65031,

        Ldarg = (ushort)65033,

        Ldarga = (ushort)65034,

        Starg = (ushort)65035,

        Ldloc = (ushort)65036,

        Ldloca = (ushort)65037,

        Stloc = (ushort)65038,

        Localloc = (ushort)65039,

        Endfilter = (ushort)65041,

        Unaligned = (ushort)65042,

        Volatile = (ushort)65043,

        Tail = (ushort)65044,

        Initobj = (ushort)65045,

        Constrained = (ushort)65046,

        Cpblk = (ushort)65047,

        Initblk = (ushort)65048,

        Rethrow = (ushort)65050,

        Sizeof = (ushort)65052,

        Refanytype = (ushort)65053,

        Readonly = (ushort)65054,
    }

}