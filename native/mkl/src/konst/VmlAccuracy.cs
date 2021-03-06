//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    /// <summary>
    /// Controls the accuracy of VML functions
    /// </summary>
    public enum VmlAccuracy
    {
        ///<summary>Selects low accuracy VML functions</summary>
        LowAccuracy = 0x00000001,
        
        ///<summary>Selects high accuracy VML functions</summary>
        HighAccuracy = 0x00000002,
        
        ///<summary>Selects enhanced performance, high accuracy VML functions</summary>
        HighAccuracyP = 0x00000003
    }
}