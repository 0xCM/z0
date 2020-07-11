//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public struct AsmFlowInfo
    {
        public OpCodeId Code {get; set;}

        public ConditionCode ConditionCode {get; set;}

        public bool IsStackInstruction {get; set;} 
                
        public FlowControl FlowControl {get; set;}
        
        public bool IsJccShortOrNear {get; set;}
        
        public bool IsJccNear {get; set;}
        
        public bool IsJccShort {get; set;}
        
        public bool IsJmpShort {get; set;}
        
        public bool IsJmpNear {get; set;}
        
        public bool IsJmpShortOrNear {get; set;}
        
        public bool IsJmpFar {get; set;}
        
        public bool IsCallNear {get; set;}
        
        public bool IsCallFar {get; set;}
        
        public bool IsJmpNearIndirect {get; set;}
        
        public bool IsJmpFarIndirect {get; set;}
        
        public bool IsCallNearIndirect {get; set;}
        
        public bool IsCallFarIndirect {get; set;}
    }
}