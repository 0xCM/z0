//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using FT = FixedKind;

    [Flags]
    public enum FixedOperationKind : uint
    {
       /// <summary>
       /// Classifies nothing
       /// </summary>        
        None = 0,

       /// <summary>
       /// Classifies functions with fixed operand and return types
       /// </summary>        
        FixedSigClass = FixedOperationClass.LastClass << 1,

       /// <summary>
       /// Classifies a signature position
       /// </summary>        
        FixedSlot = FixedSigClass << 1,

       /// <summary>
       /// Classifies a fixed operand type
       /// </summary>        
        Operand = FixedSigClass << 1,

       /// <summary>
       /// Classifies a fixed return type
       /// </summary>        
        Return = Operand << 1,
                
       /// <summary>
       /// The first slot
       /// </summary>        
        Slot0 = Return << 1,

       /// <summary>
       /// The second slot
       /// </summary>        
        Slot1 = Slot0 << 1,

       /// <summary>
       /// The third slot
       /// </summary>        
        Slot2 = Slot1 << 1,

       /// <summary>
       /// The fourth slot
       /// </summary>        
        Slot3 = Slot2 << 1,

       /// <summary>
       /// The pentultimate slot
       /// </summary>        
        Slot4 = Slot3 << 1,

       /// <summary>
       /// The last slot
       /// </summary>        
        Slot5 = Slot4 << 1,
    
       /// <summary>
       /// The signature specification lower bound
       /// </summary>        
        SigSpec = Slot5 << 1,
        
       /// <summary>
       /// The last class
       /// </summary>        
        LastClass = SigSpec,

       /// <summary>
       /// 1-bit value in slot
       /// </summary>        
        FixedSlot1 = FixedSlot | Fixed1,

       /// <summary>
       /// 8-bit value in slot
       /// </summary>        
        FixedSlot8 = FixedSlot | Fixed8,

       /// <summary>
       /// 16-bit value in slot
       /// </summary>        
        FixedSlot16 = FixedSlot | Fixed16,

       /// <summary>
       /// 32-bit value in slot
       /// </summary>        
        FixedSlot32 = FixedSlot | Fixed32,

       /// <summary>
       /// 54-bit value in slot
       /// </summary>        
        FixedSlot64 = FixedSlot | Fixed64,

       /// <summary>
       /// 128-bit value in slot
       /// </summary>        
        FixedSlot128 = FixedSlot | Fixed128,

       /// <summary>
       /// 256-bit value in slot
       /// </summary>        
        FixedSlot256 = FixedSlot | Fixed256,

       /// <summary>
       /// 512-bit value in slot
       /// </summary>        
        FixedSlot512 = FixedSlot | Fixed512,

       /// <summary>
       /// The first operand slot
       /// </summary>        
        Operand0 = Slot0 | Operand,

       /// <summary>
       /// The second operand slot
       /// </summary>        
        Operand1 = Slot1 | Operand,

       /// <summary>
       /// The third operand slot
       /// </summary>        
        Operand2 = Slot2 | Operand,

       /// <summary>
       /// The fourth operand slot
       /// </summary>        
        Operand3 = Slot3 | Operand,

       /// <summary>
       /// The fifth operand slot
       /// </summary>        
        Operand4 = Slot4 | Operand,
       
       /// <summary>
       /// The retun slot
       /// </summary>        
        ReturnSlot = Slot5 | Return,

       /// <summary>
       /// 1-bit operand in slot 0
       /// </summary>        
       Fixed1x0 = Operand0 | FixedSlot1,

       /// <summary>
       /// 1-bit operand in slot 1
       /// </summary>        
       Fixed1x1 = Operand1 | FixedSlot1,

       /// <summary>
       /// 1-bit operand in slot 2
       /// </summary>        
       Fixed1x2 = Operand2 | FixedSlot1,

       /// <summary>
       /// 1-bit operand in slot 3
       /// </summary>        
       Fixed1x3 = Operand2 | FixedSlot1,

       /// <summary>
       /// 1-bit operand in slot 4
       /// </summary>        
       Fixed1x4 = Operand4 | FixedSlot1,

       /// <summary>
       /// 8-bit operand in slot 0
       /// </summary>        
       Fixed8x0 = Operand0 | FixedSlot8,
    
       /// <summary>
       /// 8-bit operand in slot 1
       /// </summary>        
       Fixed8x1 = Operand1 | FixedSlot8,

       /// <summary>
       /// 8-bit operand in slot 2
       /// </summary>        
       Fixed8x2 = Operand2 | FixedSlot8,

       /// <summary>
       /// 8-bit operand in slot 3
       /// </summary>        
       Fixed8x3 = Operand2 | FixedSlot8,

       /// <summary>
       /// 8-bit operand in slot 4
       /// </summary>        
       Fixed8x4 = Operand4 | FixedSlot8,

       /// <summary>
       /// 16-bit operand in slot 0
       /// </summary>        
       Fixed16x0 = Operand0 | FixedSlot16,
    
       /// <summary>
       /// 16-bit operand in slot 1
       /// </summary>        
       Fixed16x1 = Operand1 | FixedSlot16,

       /// <summary>
       /// 16-bit operand in slot 2
       /// </summary>        
       Fixed16x2 = Operand2 | FixedSlot16,

       /// <summary>
       /// 16-bit operand in slot 3
       /// </summary>        
       Fixed16x3 = Operand2 | FixedSlot16,

       /// <summary>
       /// 16-bit operand in slot 4
       /// </summary>        
       Fixed16x4 = Operand4 | FixedSlot16,

       /// <summary>
       /// 32-bit operand in slot 0
       /// </summary>        
       Fixed32x0 = Operand0 | FixedSlot32,
    
       /// <summary>
       /// 32-bit operand in slot 1
       /// </summary>        
       Fixed32x1 = Operand1 | FixedSlot32,

       /// <summary>
       /// 32-bit operand in slot 2
       /// </summary>        
       Fixed32x2 = Operand2 | FixedSlot32,

       /// <summary>
       /// 32-bit operand in slot 3
       /// </summary>        
       Fixed32x3 = Operand2 | FixedSlot32,

       /// <summary>
       /// 32-bit operand in slot 4
       /// </summary>        
       Fixed32x4 = Operand4 | FixedSlot32,

       /// <summary>
       /// 64-bit operand in slot 0
       /// </summary>        
       Fixed64x0 = Operand0 | FixedSlot64,
    
       /// <summary>
       /// 64-bit operand in slot 1
       /// </summary>        
       Fixed64x1 = Operand1 | FixedSlot64,

       /// <summary>
       /// 64-bit operand in slot 2
       /// </summary>        
       Fixed64x2 = Operand2 | FixedSlot64,

       /// <summary>
       /// 64-bit operand in slot 3
       /// </summary>        
       Fixed64x3 = Operand2 | FixedSlot64,

       /// <summary>
       /// 64-bit operand in slot 4
       /// </summary>        
       Fixed64x4 = Operand4 | FixedSlot64,

       /// <summary>
       /// 64-bit operand in slot 0
       /// </summary>        
       Fixed128x0 = Operand0 | FixedSlot128,
    
       /// <summary>
       /// 128-bit operand in slot 1
       /// </summary>        
       Fixed128x1 = Operand1 | FixedSlot128,

       /// <summary>
       /// 128-bit operand in slot 2
       /// </summary>        
       Fixed128x2 = Operand2 | FixedSlot128,

       /// <summary>
       /// 128-bit operand in slot 3
       /// </summary>        
       Fixed128x3 = Operand2 | FixedSlot128,

       /// <summary>
       /// 128-bit operand in slot 4
       /// </summary>        
       Fixed128x4 = Operand4 | FixedSlot128,
 
       /// <summary>
       /// 64-bit operand in slot 0
       /// </summary>        
       Fixed256x0 = Operand0 | FixedSlot256,
    
       /// <summary>
       /// 256-bit operand in slot 1
       /// </summary>        
       Fixed256x1 = Operand1 | FixedSlot256,

       /// <summary>
       /// 256-bit operand in slot 2
       /// </summary>        
       Fixed256x2 = Operand2 | FixedSlot256,

       /// <summary>
       /// 256-bit operand in slot 3
       /// </summary>        
       Fixed256x3 = Operand2 | FixedSlot256,

       /// <summary>
       /// 256-bit operand in slot 4
       /// </summary>        
       Fixed256x4 = Operand4 | FixedSlot256,

       /// <summary>
       /// 64-bit operand in slot 0
       /// </summary>        
       Fixed512x0 = Operand0 | FixedSlot512,
    
       /// <summary>
       /// 512-bit operand in slot 1
       /// </summary>        
       Fixed512x1 = Operand1 | FixedSlot512,

       /// <summary>
       /// 512-bit operand in slot 2
       /// </summary>        
       Fixed512x2 = Operand2 | FixedSlot512,

       /// <summary>
       /// 512-bit operand in slot 3
       /// </summary>        
       Fixed512x3 = Operand2 | FixedSlot512,

       /// <summary>
       /// 512-bit operand in slot 4
       /// </summary>        
       Fixed512x4 = Operand4 | FixedSlot512,

       /// <summary>
       /// 8-bit return in last slot
       /// </summary>        
       Return1 = ReturnSlot | FixedSlot1,

       /// <summary>
       /// 8-bit return in last slot
       /// </summary>        
       Return8 = ReturnSlot | FixedSlot8,

       /// <summary>
       /// 16-bit return in last slot
       /// </summary>        
       Return16 = ReturnSlot | FixedSlot16,

       /// <summary>
       /// 32-bit return in last slot
       /// </summary>        
       Return32 = ReturnSlot | FixedSlot32,

       /// <summary>
       /// 64-bit return in last slot
       /// </summary>        
       Return64 = ReturnSlot | FixedSlot64,

       /// <summary>
       /// 128-bit return in last slot
       /// </summary>        
       Return128 = ReturnSlot | FixedSlot128,

       /// <summary>
       /// 256-bit return in last slot
       /// </summary>        
       Return256 = ReturnSlot | FixedSlot256,

       /// <summary>
       /// 512-bit return in last slot
       /// </summary>        
       Return512 = ReturnSlot | FixedSlot512,

       /// <summary>
       /// An 8-bit emitter
       /// </summary>        
       Emitter1 = SigSpec | Return1,

       /// <summary>
       /// An 8-bit emitter
       /// </summary>        
       Emitter8 = SigSpec | Return8,

       /// <summary>
       /// An 16-bit emitter
       /// </summary>        
       Emitter16 = SigSpec | Return16,

       /// <summary>
       /// An 32-bit emitter
       /// </summary>        
       Emitter32 = SigSpec | Return32,

       /// <summary>
       /// An 54-bit emitter
       /// </summary>        
       Emitter64 = SigSpec | Return64,

       /// <summary>
       /// An 128-bit emitter
       /// </summary>        
       Emitter128 = SigSpec | Return128,

       /// <summary>
       /// An 256-bit emitter
       /// </summary>        
       Emitter256 = SigSpec | Return256,

       /// <summary>
       /// An 512-bit emitter
       /// </summary>        
       Emitter512 = SigSpec | Return512,

       /// <summary>
       /// A 1-bit unary operator
       /// </summary>        
       UnaryOp1 = SigSpec | Fixed1x0 | Return1,

       /// <summary>
       /// An 8-bit unary operator
       /// </summary>        
       UnaryOp8 = SigSpec | Fixed8x0 | Return8,

       /// <summary>
       /// An 16-bit unary operator
       /// </summary>        
       UnaryOp16 = SigSpec | Fixed16x0 | Return16,

       /// <summary>
       /// An 32-bit unary operator
       /// </summary>        
       UnaryOp32 =  SigSpec | Fixed32x0 | Return32,

       /// <summary>
       /// An 64-bit unary operator
       /// </summary>        
       UnaryOp64 = SigSpec | Fixed64x0 | Return64,

       /// <summary>
       /// An 128-bit unary operator
       /// </summary>        
       UnaryOp128 = SigSpec | Fixed128x0 | Return128,

       /// <summary>
       /// An 256-bit unary operator
       /// </summary>        
       UnaryOp256 = SigSpec | Fixed256x0 | Return256,

       /// <summary>
       /// An 512-bit unary operator
       /// </summary>        
       UnaryOp512 = SigSpec | Fixed512x0 | Return512,

       /// <summary>
       /// A 1-bit binary operator
       /// </summary>        
       BinaryOp1 = SigSpec | Fixed1x0 | Fixed8x1 | Return1,

       /// <summary>
       /// An 8-bit binary operator
       /// </summary>        
       BinaryOp8 = SigSpec | Fixed8x0 | Fixed8x1 | Return8,

       /// <summary>
       /// An 16-bit binary operator
       /// </summary>        
       BinaryOp16 = SigSpec | Fixed16x0 | Fixed16x1 | Return16,

       /// <summary>
       /// An 32-bit binary operator
       /// </summary>        
       BinaryOp32 =  SigSpec | Fixed32x0 | Fixed32x1 |Return32,

       /// <summary>
       /// An 64-bit binary operator
       /// </summary>        
       BinaryOp64 = SigSpec | Fixed64x0 | Fixed64x1 | Return64,

       /// <summary>
       /// An 128-bit binary operator
       /// </summary>        
       BinaryOp128 = SigSpec | Fixed128x0 | Fixed128x1 | Return128,

       /// <summary>
       /// An 256-bit binary operator
       /// </summary>        
       BinaryOp256 = SigSpec | Fixed256x0 | Fixed256x1 | Return256,

       /// <summary>
       /// An 512-bit binary operator
       /// </summary>        
       BinaryOp512 = SigSpec | Fixed512x0 | Fixed512x1 | Return512,

       /// <summary>
       /// A 1-bit ternary operator
       /// </summary>        
       TernaryOp1 = SigSpec | Fixed1x0 | Fixed8x1 | Fixed8x2 | Return1,
 
       /// <summary>
       /// An 8-bit ternary operator
       /// </summary>        
       TernaryOp8 = SigSpec | Fixed8x0 | Fixed8x1 | Fixed8x2 | Return8,

       /// <summary>
       /// An 16-bit ternary operator
       /// </summary>        
       TernaryOp16 = SigSpec | Fixed16x0 | Fixed16x1 | Fixed16x2 | Return16,

       /// <summary>
       /// An 32-bit ternary operator
       /// </summary>        
       TernaryOp32 =  SigSpec | Fixed32x0 | Fixed32x1 | Fixed32x2 | Return32,

       /// <summary>
       /// An 64-bit ternary operator
       /// </summary>        
       TernaryOp64 = SigSpec | Fixed64x0 | Fixed64x1 | Fixed64x2 | Return64,

       /// <summary>
       /// An 128-bit ternary operator
       /// </summary>        
       TernaryOp128 = SigSpec | Fixed128x0 | Fixed128x1 | Fixed128x2 | Return128,

       /// <summary>
       /// An 256-bit ternary operator
       /// </summary>        
       TernaryOp256 = SigSpec | Fixed256x0 | Fixed256x1 | Fixed256x2 | Return256,

       /// <summary>
       /// An 512-bit ternary operator
       /// </summary>        
       TernaryOp512 = SigSpec | Fixed512x0 | Fixed512x1 | Fixed512x2 | Return512,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed1"/>
       /// </summary>        
       Fixed1 = FT.Fixed1,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed8"/>
       /// </summary>        
       Fixed8 = FT.Fixed8,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed16"/>
       /// </summary>        
       Fixed16 = FT.Fixed16,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed32"/>
       /// </summary>        
       Fixed32 = FT.Fixed32,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed64"/>
       /// </summary>        
       Fixed64 = FT.Fixed64,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed128"/>
       /// </summary>        
       Fixed128 = FT.Fixed128,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed256"/>
       /// </summary>        
       Fixed256 = FT.Fixed256,

       /// <summary>
       /// Redeclaration of <see cref="FT.Fixed512"/>
       /// </summary>        
       Fixed512 = FT.Fixed512,
    }
}