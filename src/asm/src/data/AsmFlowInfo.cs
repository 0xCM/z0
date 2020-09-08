//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public struct AsmFlowInfo
    {
        public OpCodeId Code;

        public ConditionCode ConditionCode;

        public bool IsStackInstruction; 
                
        public FlowControl FlowControl;
        
        public bool IsJccShortOrNear;
        
        public bool IsJccNear;
        
        public bool IsJccShort;
        
        public bool IsJmpShort;
        
        public bool IsJmpNear;
        
        public bool IsJmpShortOrNear;
        
        public bool IsJmpFar;
        
        public bool IsCallNear;
        
        public bool IsCallFar;
        
        public bool IsJmpNearIndirect;
        
        public bool IsJmpFarIndirect;
        
        public bool IsCallNearIndirect;
        
        public bool IsCallFarIndirect;
    }
}