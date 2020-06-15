//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using R = OpCodeDetail;
    using F = OpCodeDetailField;


    public struct OpCodeDetail  : IRecord<F,R>
    {
		public int Sequence {get;}

        public OpCodeId Id {get; set;}

        public bool CanSuppressAllExceptions {get; set;}

        public bool RequireNonZeroOpMaskRegister {get; set;}

        public bool CanUseZeroingMasking {get; set;}

        public bool CanUseLockPrefix {get; set;}

        public bool CanUseXacquirePrefix {get; set;}

        public bool CanUseXreleasePrefix {get; set;}

        public bool CanUseRepPrefix {get; set;}

        public bool CanUseRepnePrefix {get; set;}

        public bool CanUseBndPrefix {get; set;}

        public bool CanUseHintTakenPrefix {get; set;}

        public bool CanUseNotrackPrefix {get; set;}

        public OpCodeTableKind Table {get; set;}

        public MandatoryPrefix MandatoryPrefix {get; set;}
         
        public bool IsGroup {get; set;}
        
        public int GroupIndex {get; set;}

        public int OpCount {get; set;}
        
        public OpCodeOperandKind Op0Kind {get; set;}
        
        public OpCodeOperandKind Op1Kind {get; set;}
        
        public OpCodeOperandKind Op2Kind {get; set;}
        
        public bool CanUseOpMaskRegister {get; set;}
        
        public OpCodeOperandKind Op3Kind {get; set;}
        
        public OpCodeOperandKind Op4Kind {get; set;}
        
        public bool CanBroadcast {get; set;}
                
        public EncodingKind Encoding {get; set;}
        
        public bool IsInstruction {get; set;}
        
        public bool Mode16 {get; set;}
        
        public bool Mode32 {get; set;}
        
        public bool CanUseRoundingControl {get; set;}
        
        public bool Fwait {get; set;}
        
        public bool Mode64 {get; set;}
        
        public int AddressSize {get; set;}
        
        public uint L {get; set;}
        
        public uint W {get; set;}
        
        public bool IsLIG {get; set;}
        
        public bool IsWIG {get; set;}
        
        public bool IsWIG32 {get; set;}
        
        public TupleType TupleType {get; set;}
        
        public int OperandSize {get; set;}
    }
}