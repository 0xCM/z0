//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using static Part;

    /// <summary>
    /// An enumeration of all of the operation codes that are used in the CLI Common Intermediate Language.
    /// </summary>
    public enum OperationCode
    {
        /// <summary>
        ///
        /// </summary>
        Nop=0x00,
        /// <summary>
        ///
        /// </summary>
        Break=0x01,
        /// <summary>
        ///
        /// </summary>
        Ldarg_0=0x02,

        Ldarg_1=0x03,

        Ldarg_2=0x04,

        Ldarg_3=0x05,

        Ldloc_0=0x06,

        Ldloc_1=0x07,

        Ldloc_2=0x08,

        Ldloc_3=0x09,

        Stloc_0=0x0a,

        Stloc_1=0x0b,

        Stloc_2=0x0c,

        Stloc_3=0x0d,

        Ldarg_S=0x0e,

        Ldarga_S=0x0f,

        Starg_S=0x10,

        Ldloc_S=0x11,

        Ldloca_S=0x12,

        Stloc_S=0x13,

        Ldnull=0x14,

        Ldc_I4_M1=0x15,

        Ldc_I4_0=0x16,

        Ldc_I4_1=0x17,

        Ldc_I4_2=0x18,

        Ldc_I4_3=0x19,

        Ldc_I4_4=0x1a,

        Ldc_I4_5=0x1b,

        Ldc_I4_6=0x1c,

        Ldc_I4_7=0x1d,

        Ldc_I4_8=0x1e,

        Ldc_I4_S=0x1f,

        Ldc_I4=0x20,

        Ldc_I8=0x21,

        Ldc_R4=0x22,

        Ldc_R8=0x23,

        Dup=0x25,
        /// <summary>
        ///
        /// </summary>
        Pop=0x26,
        /// <summary>
        ///
        /// </summary>
        Jmp=0x27,
        /// <summary>
        ///
        /// </summary>
        Call=0x28,
        /// <summary>
        ///
        /// </summary>
        Calli=0x29,
        /// <summary>
        ///
        /// </summary>
        Ret=0x2a,

        Br_S=0x2b,

        Brfalse_S=0x2c,

        Brtrue_S=0x2d,

        Beq_S=0x2e,

        Bge_S=0x2f,

        Bgt_S=0x30,

        Ble_S=0x31,

        Blt_S=0x32,

        Bne_Un_S=0x33,

        Bge_Un_S=0x34,

        Bgt_Un_S=0x35,

        Ble_Un_S=0x36,

        Blt_Un_S=0x37,

        Br=0x38,

        Brfalse=0x39,

        Brtrue=0x3a,

        Beq=0x3b,

        Bge=0x3c,

        Bgt=0x3d,

        Ble=0x3e,

        Blt=0x3f,

        Bne_Un=0x40,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Bge_Un=0x41,

        Bgt_Un=0x42,

        Ble_Un=0x43,

        Blt_Un=0x44,
        /// <summary>
        ///
        /// </summary>
        Switch=0x45,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_I1=0x46,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_U1=0x47,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_I2=0x48,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_U2=0x49,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_I4=0x4a,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_U4=0x4b,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_I8=0x4c,

        Ldind_I=0x4d,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_R4=0x4e,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_R8=0x4f,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldind_Ref=0x50,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_Ref=0x51,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_I1=0x52,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_I2=0x53,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_I4=0x54,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_I8=0x55,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_R4=0x56,

        Stind_R8=0x57,
        /// <summary>
        ///
        /// </summary>
        Add=0x58,
        /// <summary>
        ///
        /// </summary>
        Sub=0x59,
        /// <summary>
        ///
        /// </summary>
        Mul=0x5a,
        /// <summary>
        ///
        /// </summary>
        Div=0x5b,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Div_Un=0x5c,
        /// <summary>
        ///
        /// </summary>
        Rem=0x5d,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Rem_Un=0x5e,
        /// <summary>
        ///
        /// </summary>
        And=0x5f,
        /// <summary>
        ///
        /// </summary>
        Or=0x60,
        /// <summary>
        ///
        /// </summary>
        Xor=0x61,

        Shl=0x62,
        /// <summary>
        ///
        /// </summary>
        Shr=0x63,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Shr_Un=0x64,
        /// <summary>
        ///
        /// </summary>
        Neg=0x65,
        /// <summary>
        ///
        /// </summary>
        Not=0x66,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_I1=0x67,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_I2=0x68,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_I4=0x69,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_I8=0x6a,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_R4=0x6b,

        Conv_R8=0x6c,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_U4=0x6d,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_U8=0x6e,
        /// <summary>
        ///
        /// </summary>
        Callvirt=0x6f,
        /// <summary>
        ///
        /// </summary>
        Cpobj=0x70,
        /// <summary>
        ///
        /// </summary>
        Ldobj=0x71,
        /// <summary>
        ///
        /// </summary>
        Ldstr=0x72,
        /// <summary>
        ///
        /// </summary>
        Newobj=0x73,
        /// <summary>
        ///
        /// </summary>
        Castclass=0x74,
        /// <summary>
        ///
        /// </summary>
        Isinst=0x75,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_R_Un=0x76,

        Unbox=0x79,
        /// <summary>
        ///
        /// </summary>
        Throw=0x7a,
        /// <summary>
        ///
        /// </summary>
        Ldfld=0x7b,
        /// <summary>
        ///
        /// </summary>
        Ldflda=0x7c,
        /// <summary>
        ///
        /// </summary>
        Stfld=0x7d,
        /// <summary>
        ///
        /// </summary>
        Ldsfld=0x7e,
        /// <summary>
        ///
        /// </summary>
        Ldsflda=0x7f,
        /// <summary>
        ///
        /// </summary>
        Stsfld=0x80,
        /// <summary>
        ///
        /// </summary>
        Stobj=0x81,

        Conv_Ovf_I1_Un=0x82,

        Conv_Ovf_I2_Un=0x83,

        Conv_Ovf_I4_Un=0x84,

        Conv_Ovf_I8_Un=0x85,

        Conv_Ovf_U1_Un=0x86,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U2_Un=0x87,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U4_Un=0x88,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U8_Un=0x89,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_I_Un=0x8a,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U_Un=0x8b,
        /// <summary>
        ///
        /// </summary>
        Box=0x8c,
        /// <summary>
        ///
        /// </summary>
        Newarr=0x8d,
        /// <summary>
        ///
        /// </summary>
        Ldlen=0x8e,
        /// <summary>
        ///
        /// </summary>
        Ldelema=0x8f,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_I1=0x90,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_U1=0x91,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_I2=0x92,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_U2=0x93,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_I4=0x94,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_U4=0x95,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_I8=0x96,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_I=0x97,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_R4=0x98,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_R8=0x99,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Ldelem_Ref=0x9a,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_I=0x9b,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_I1=0x9c,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_I2=0x9d,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_I4=0x9e,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_I8=0x9f,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_R4=0xa0,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_R8=0xa1,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stelem_Ref=0xa2,
        /// <summary>
        ///
        /// </summary>
        Ldelem=0xa3,
        /// <summary>
        ///
        /// </summary>
        Stelem=0xa4,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Unbox_Any=0xa5,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_I1=0xb3,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U1=0xb4,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_I2=0xb5,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U2=0xb6,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_I4=0xb7,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U4=0xb8,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_I8=0xb9,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U8=0xba,
        /// <summary>
        ///
        /// </summary>
        Refanyval=0xc2,
        /// <summary>
        ///
        /// </summary>
        Ckfinite=0xc3,
        /// <summary>
        ///
        /// </summary>
        Mkrefany=0xc6,
        /// <summary>
        ///
        /// </summary>
        Ldtoken=0xd0,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_U2=0xd1,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_U1=0xd2,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_I=0xd3,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_I=0xd4,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_Ovf_U=0xd5,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Add_Ovf=0xd6,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Add_Ovf_Un=0xd7,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Mul_Ovf=0xd8,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Mul_Ovf_Un=0xd9,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Sub_Ovf=0xda,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Sub_Ovf_Un=0xdb,
        /// <summary>
        ///
        /// </summary>
        Endfinally=0xdc,
        /// <summary>
        ///
        /// </summary>
        Leave=0xdd,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Leave_S=0xde,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Stind_I=0xdf,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Conv_U=0xe0,
        /// <summary>
        ///
        /// </summary>
        Arglist=0xfe00,
        /// <summary>
        ///
        /// </summary>
        Ceq=0xfe01,
        /// <summary>
        ///
        /// </summary>
        Cgt=0xfe02,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Cgt_Un=0xfe03,
        /// <summary>
        ///
        /// </summary>
        Clt=0xfe04,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId="Member")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Clt_Un=0xfe05,
        /// <summary>
        ///
        /// </summary>
        Ldftn=0xfe06,
        /// <summary>
        ///
        /// </summary>
        Ldvirtftn=0xfe07,

        Ldarg=0xfe09,

        Ldarga=0xfe0a,

        Starg=0xfe0b,

        Ldloc=0xfe0c,

        Ldloca=0xfe0d,

        Stloc=0xfe0e,

        Localloc=0xfe0f,
        /// <summary>
        ///
        /// </summary>
        Endfilter=0xfe11,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Unaligned_=0xfe12,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Volatile_=0xfe13,
        /// <summary>
        ///
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId="Member")]
        Tail_=0xfe14,

        Initobj=0xfe15,

        Constrained_=0xfe16,

        Cpblk=0xfe17,

        Initblk=0xfe18,

        No_=0xfe19,

        Rethrow=0xfe1a,

        Sizeof=0xfe1c,

        Refanytype=0xfe1d,

        Readonly_=0xfe1e,

        Array_Create,

        Array_Create_WithLowerBound,

        Array_Get,

        Array_Set,

        Array_Addr,

        Invalid,
    }

}