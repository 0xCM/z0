//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines polarity - an optional choice between exactly one of two values
    /// From this perspective, an orientation can be viewed as a required choice
    /// of sign. Or, a sign can be viwed as a subsumption of orientation sans duality
    /// </summary>
    /// <remaks>
    /// Note also that this fills in the need for a true mathematical "sign": A number
    /// is either Negative, Positive or Neutral=0.
    /// </remaks>
    public enum Sign : sbyte
    {        
        /// <summary>
        /// Specifies negative polarity and can be interpreted as mathematical sign
        /// </summary>
        Neg = -1,
        
        /// <summary>
        /// Specifies neutral polarity and from a mathemtatical perspectives gives 
        /// a sign classification to the number 0.
        /// </summary>
        None = 0,
            
        /// <summary>
        /// Specifies positive polarity and can be interpreted as mathematical sign
        /// </summary>
        Pos = 1
    }

    public enum Sign8 : byte
    {
        Unsigned = 0,

        Signed = byte.MaxValue ^ sbyte.MaxValue
    }

    public enum Sign16 : ushort
    {
        Unsigned = 0,

        Signed = ushort.MaxValue ^ short.MaxValue
    }    

    public enum Sign32 : uint
    {
        Unsigned = 0,

        Signed = uint.MaxValue ^ int.MaxValue
    }        

    public enum Sign64 : ulong
    {
        Unsigned = 0,

        Signed = ulong.MaxValue ^ long.MaxValue
    }            
}