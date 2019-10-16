//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vhdl
{

    public enum STD_ULOGIC : uint
    {
        ///<summary>
        /// Uninitialized
        ///</summary>
        U = 0,
        
        ///<summary>
        /// Forcing unknown
        ///</summary>
        X = 1, 

        ///<summary>
        /// Forcing 0
        ///</summary>
        Off = X << 1, 

        ///<summary>
        /// Forcing 1
        ///</summary>
        On = Off << 1,

        ///<summary>
        /// Hi impedence
        ///</summary>
        Z = On << 1,

        ///<summary>
        /// Weak unknown
        ///</summary>
        W = Z << 1,

        ///<summary>
        /// Weak 0
        ///</summary>
        L = W << 1,

        ///<summary>
        /// Weak 1
        ///</summary>
        H = L << 1,


        ///<summary>
        /// Don't care
        ///</summary>
        D = H << 1

    }

}