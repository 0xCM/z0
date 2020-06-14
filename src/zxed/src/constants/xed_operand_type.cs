//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
 
    /// <summary>
    /// Literals corresponds to the identifiers defined in xed-operand-types.txt
    /// </summary>
    public enum xed_operand_type
    {
        i1, //INT    1
        
        i8, //INT    8
        
        i16, //INT   16
        
        i32, //INT   32
        
        i64, //INT   64
        
        u8, //UINT    8
        
        u16, //UINT   16
        
        u32, //UINT   32
        
        u64, //UINT   64
        
        u128, //UINT  128
        
        u256, //UINT  256
        
        f32, //SINGLE   32
        
        f64, //DOUBLE   64
        
        f80, //LONGDOUBLE   80
        
        b80, //LONGBCD   80        
    }
}