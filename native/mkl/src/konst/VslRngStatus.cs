//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    public enum VslRngStatus
    {
        VSL_ERROR_OK = 0,

        VSL_ERROR_MEM_FAILURE  = -4,

        VSL_RNG_ERROR_INVALID_BRNG_INDEX = - 1000,
    
        VSL_RNG_ERROR_LEAPFROG_UNSUPPORTED = - 1002,
    
        VSL_RNG_ERROR_SKIPAHEAD_UNSUPPORTED = - 1003,
    
        VSL_RNG_ERROR_BRNGS_INCOMPATIBLE = - 1005,
    
        VSL_RNG_ERROR_BAD_STREAM = - 1006,
    
        VSL_RNG_ERROR_BRNG_TABLE_FULL    = - 1007,
    
        VSL_RNG_ERROR_BAD_STREAM_STATE_SIZE     = - 1008,
    
        VSL_RNG_ERROR_BAD_WORD_SIZE = - 1009,
    
        VSL_RNG_ERROR_BAD_NSEEDS = - 1010,
    
        VSL_RNG_ERROR_BAD_NBITS = - 1011,
    
        VSL_RNG_ERROR_QRNG_PERIOD_ELAPSED = - 1012,
    
        VSL_RNG_ERROR_LEAPFROG_NSTREAMS_TOO_BIG = - 1013,
    
        VSL_RNG_ERROR_BRNG_NOT_SUPPORTED = - 1014,

        /* abstract stream related errors */
        VSL_RNG_ERROR_BAD_UPDATE = - 1120,
        
        VSL_RNG_ERROR_NO_NUMBERS = - 1121,
        
        VSL_RNG_ERROR_INVALID_ABSTRACT_STREAM = - 1122,

        /* non determenistic stream related errors */
        VSL_RNG_ERROR_NONDETERM_NOT_SUPPORTED     = - 1130,

        VSL_RNG_ERROR_NONDETERM_NRETRIES_EXCEEDED = - 1131,

        /* ARS5 stream related errors */
        VSL_RNG_ERROR_ARS5_NOT_SUPPORTED        = - 1140,

        /* Multinomial distribution probability array related errors */
        VSL_DISTR_MULTINOMIAL_BAD_PROBABILITY_ARRAY    = - 1150,

        /* read/write stream to file errors */
        VSL_RNG_ERROR_FILE_CLOSE = - 1100,
        
        VSL_RNG_ERROR_FILE_OPEN = - 1101,
        
        VSL_RNG_ERROR_FILE_WRITE = - 1102,
        
        VSL_RNG_ERROR_FILE_READ = - 1103,

        VSL_RNG_ERROR_BAD_FILE_FORMAT = - 1110,
        
        VSL_RNG_ERROR_UNSUPPORTED_FILE_VER = - 1111,

        VSL_RNG_ERROR_BAD_MEM_FORMAT = - 1200
    }
}