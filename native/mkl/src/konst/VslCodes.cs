//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{            
    public enum VslSSMatrixStorage : int
    {
        /// <summary>
        /// Observation vectors are organized by rows. For example, 10 observations
        /// in dimension 3 will conform to a 10 row 3 column matrix
        /// </summary>
        [MklCode("Observation vectors are organized by rows")]
        VSL_SS_MATRIX_STORAGE_ROWS  =    0x00010000,
        
        /// <summary>
        /// Observation vectors are organized by columns. For example, 10 observations
        /// in dimension 3 will conform to a 3 row by 10 column matrix
        /// </summary>
        [MklCode("Observation vectors are organized by columns")]
        VSL_SS_MATRIX_STORAGE_COLS  =   0x00020000
    }
}