//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {

        /// <summary>
        /// Returns true if the source matrix has 0 in each entry and false otherwise
        /// </summary>
        /// <param name="A">The matrix to test</param>
        [MethodImpl(Inline)]
        public static bool testz(BitMatrix8 A)
            => BitConverter.ToUInt64(A.Data) == 0;

        /// <summary>
        /// Returns true if the source matrix has 0 in each entry and false otherwise
        /// </summary>
        /// <param name="A">The matrix to test</param>
        [MethodImpl(Inline)]
        public static bool testz(BitMatrix16 A)
        {
            A.GetCells(out Vec256<ushort> v);
            return dinx.testz(v,v);
        }

        /// <summary>
        /// Returns true if the source matrix has 0 in each entry and false otherwise
        /// </summary>
        /// <param name="A">The matrix to test</param>
        public static bool testz(BitMatrix64 A)
        {
            const int rowstep = 4;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<ulong> v);
                if(!dinx.testz(v, v))
                    return false;
            }
            return true;
        }        

        /// <summary>
        /// Returns true if the source matrix has 0 in each entry and false otherwise
        /// </summary>
        /// <param name="A">The matrix to test</param>
        public static bool testz(BitMatrix32 A)
        {
            const int rowstep = 8;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<uint> vSrc);
                if(!ginx.testz<uint>(vSrc,vSrc))
                    return false;
            }
            return true;
        }
    }
}