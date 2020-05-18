//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{    
	public static class DecoderTestParserConstants 
    {
		internal const string NoEncode = "noencode";
		internal const string InvalidNoMoreBytes = "nobytes";
		internal const string Broadcast = "bcst";
		internal const string Xacquire = "xacquire";
		internal const string Xrelease = "xrelease";
		internal const string Rep = "rep";
		internal const string Repe = "repe";
		internal const string Repne = "repne";
		internal const string Lock = "lock";
		internal const string ZeroingMasking = "zmsk";
		internal const string SuppressAllExceptions = "sae";
		internal const string Vsib32 = "vsib32";
		internal const string Vsib64 = "vsib64";
		internal const string RoundToNearest = "rc-rn";
		internal const string RoundDown = "rc-rd";
		internal const string RoundUp = "rc-ru";
		internal const string RoundTowardZero = "rc-rz";
		internal const string Op0Kind = "op0";
		internal const string Op1Kind = "op1";
		internal const string Op2Kind = "op2";
		internal const string Op3Kind = "op3";
		internal const string Op4Kind = "op4";
		internal const string EncodedHexBytes = "enc";
		internal const string DecoderOptions_AmdBranches = "amdbr";
		internal const string DecoderOptions_ForceReservedNop = "resnop";
		internal const string DecoderOptions_Umov = "umov";
		internal const string DecoderOptions_Xbts = "xbts";
		internal const string DecoderOptions_Cmpxchg486A = "cmpxchg486a";
		internal const string DecoderOptions_OldFpu = "oldfpu";
		internal const string DecoderOptions_Pcommit = "pcommit";
		internal const string DecoderOptions_Loadall286 = "loadall286";
		internal const string DecoderOptions_Loadall386 = "loadall386";
		internal const string DecoderOptions_Cl1invmb = "cl1invmb";
		internal const string DecoderOptions_MovTr = "movtr";
		internal const string DecoderOptions_Jmpe = "jmpe";
		internal const string DecoderOptions_NoPause = "nopause";
		internal const string DecoderOptions_NoWbnoinvd = "nowbnoinvd";
		internal const string DecoderOptions_NoLockMovCR0 = "nolockmovcr0";
		internal const string DecoderOptions_NoMPFX_0FBC = "nompfx_0fbc";
		internal const string DecoderOptions_NoMPFX_0FBD = "nompfx_0fbd";
		internal const string DecoderOptions_NoLahfSahf64 = "nolahfsahf64";
		internal const string DecoderOptions_NoInvalidCheck = "noinvalidcheck";
		internal const string SegmentPrefix_ES = "es:";
		internal const string SegmentPrefix_CS = "cs:";
		internal const string SegmentPrefix_SS = "ss:";
		internal const string SegmentPrefix_DS = "ds:";
		internal const string SegmentPrefix_FS = "fs:";
		internal const string SegmentPrefix_GS = "gs:";
		internal const string OpMask_k1 = "k1";
		internal const string OpMask_k2 = "k2";
		internal const string OpMask_k3 = "k3";
		internal const string OpMask_k4 = "k4";
		internal const string OpMask_k5 = "k5";
		internal const string OpMask_k6 = "k6";
		internal const string OpMask_k7 = "k7";
		internal const string ConstantOffsets = "co";
		internal const string OpKind_Register = "r";
		internal const string OpKind_NearBranch16 = "nb16";
		internal const string OpKind_NearBranch32 = "nb32";
		internal const string OpKind_NearBranch64 = "nb64";
		internal const string OpKind_FarBranch16 = "fb16";
		internal const string OpKind_FarBranch32 = "fb32";
		internal const string OpKind_Immediate8 = "i8";
		internal const string OpKind_Immediate16 = "i16";
		internal const string OpKind_Immediate32 = "i32";
		internal const string OpKind_Immediate64 = "i64";
		internal const string OpKind_Immediate8to16 = "i8to16";
		internal const string OpKind_Immediate8to32 = "i8to32";
		internal const string OpKind_Immediate8to64 = "i8to64";
		internal const string OpKind_Immediate32to64 = "i32to64";
		internal const string OpKind_Immediate8_2nd = "i8_2nd";
		internal const string OpKind_MemorySegSI = "segsi";
		internal const string OpKind_MemorySegESI = "segesi";
		internal const string OpKind_MemorySegRSI = "segrsi";
		internal const string OpKind_MemorySegDI = "segdi";
		internal const string OpKind_MemorySegEDI = "segedi";
		internal const string OpKind_MemorySegRDI = "segrdi";
		internal const string OpKind_MemoryESDI = "esdi";
		internal const string OpKind_MemoryESEDI = "esedi";
		internal const string OpKind_MemoryESRDI = "esrdi";
		internal const string OpKind_Memory64 = "m64";
		internal const string OpKind_Memory = "m";
	}
}