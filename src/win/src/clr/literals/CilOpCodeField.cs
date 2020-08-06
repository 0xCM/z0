//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public enum StackBehaviour : byte
    {
        Pop0 = 0,
        
        Pop1 = 1,
        
        Pop1_pop1 = 2,
        
        Popi = 3,
        
        Popi_pop1 = 4,
        
        Popi_popi = 5,
        
        Popi_popi8 = 6,
        
        Popi_popi_popi = 7,
        
        Popi_popr4 = 8,
        
        Popi_popr8 = 9,
        
        Popref = 10,
        
        Popref_pop1 = 11,
        
        Popref_popi = 12,
        
        Popref_popi_popi = 13,
        
        Popref_popi_popi8 = 14,
        
        Popref_popi_popr4 = 15,
        
        Popref_popi_popr8 = 16,
        
        Popref_popi_popref = 17,
        
        Push0 = 18,
        
        Push1 = 19,
        
        Push1_push1 = 20,
        
        Pushi = 21,
        
        Pushi8 = 22,
        
        Pushr4 = 23,
        
        Pushr8 = 24,
        
        Pushref = 25,
        
        Varpop = 26,
        
        Varpush = 27,
        
        Popref_popi_pop1 = 28,
    }


    public enum OperandType : byte
    {
        InlineBrTarget = 0,
        
        InlineField = 1,
        
        InlineI = 2,
        
        InlineI8 = 3,
        
        InlineMethod = 4,
        
        InlineNone = 5,
        
        [Obsolete("This API has been deprecated. https://go.microsoft.com/fwlink/?linkid=14202")]
        InlinePhi = 6,

        InlineR = 7,

        InlineSig = 9,

        InlineString = 10,

        InlineSwitch = 11,

        InlineTok = 12,

        InlineType = 13,

        InlineVar = 14,

        ShortInlineBrTarget = 15,

        ShortInlineI = 16,

        ShortInlineR = 17,

        ShortInlineVar = 18,
    }    
    
    public enum FlowControl : byte
    {
        Branch = 0,
        
        Break = 1,
        
        Call = 2,
        
        Cond_Branch = 3,
        
        Meta = 4,
        
        Next = 5,
        
        [Obsolete("This API has been deprecated. https://go.microsoft.com/fwlink/?linkid=14202")]
        Phi = 6,
 
        Return = 7,
 
        Throw = 8,
    }

    public enum OpCodeType : byte
    {
        [Obsolete("This API has been deprecated. https://go.microsoft.com/fwlink/?linkid=14202")]
        Annotation = 0,
 
        Macro = 1,
 
        Nternal = 2,
 
        Objmodel = 3,
 
        Prefix = 4,
 
        Primitive = 5,
    }    
}