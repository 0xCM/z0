//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines the symbols that represent base-8 digits
    /// </summary>
    public enum OctalSym : ushort
    {
        /// <summary>
        /// Specifies 0 base 8, asci code 48
        /// </summary>
        o0 = '0',

        /// <summary>
        /// Specifies 1 base 8, asci code 49
        /// </summary>
        o1 = '1',
        
        /// <summary>
        /// Specifies 2 base 8, asci code 50
        /// </summary>
        o2 = '2',
        
        /// <summary>
        /// Specifies 3 base 8, asci code 51
        /// </summary>
        o3 = '3',

        /// <summary>
        /// Specifies 4 base 8, asci code 52
        /// </summary>
        o4 = '4',

        /// <summary>
        /// Specifies 5 base 8
        /// </summary>
        o5 = '5',

        /// <summary>
        /// Specifies 6 base 8
        /// </summary>
        o6 = '6',

        /// <summary>
        /// Specifies 7 base 8
        /// </summary>
        o7 = '7',    

        /// <summary>
        /// The first declared symbol
        /// </summary>
        First = o1,

        /// <summary>
        /// The last declared symbol
        /// </summary>
        Last = o7,

        /// <summary>
        /// The symbol declaration count
        /// </summary>
        Count = Last - First + 1                
    }    
}