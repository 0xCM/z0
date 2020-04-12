//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Kinds;
    using static Scalars;

    partial class XTend
    {
        /// <summary>
        /// Returns the clr cell type of a vector of specified kind
        /// </summary>
        /// <param name="kind">The vector kind</param>
        public static Type CellType(this VectorKind kind)       
        {
            if(kind.HasCellType(z8i))
                return typeof(sbyte);
            else if(kind.HasCellType(z8))
                return typeof(byte);
            else if(kind.HasCellType(z16i))
                return typeof(short);
            else if(kind.HasCellType(z16))
                return typeof(ushort);
            else if(kind.HasCellType(z32i))
                return typeof(int);
            else if(kind.HasCellType(z32))
                return typeof(uint);
            else if(kind.HasCellType(z64i))
                return typeof(long);
            else if(kind.HasCellType(z64))
                return typeof(ulong);
            else if(kind.HasCellType(z32f))
                return typeof(float);
            else if(kind.HasCellType(z64f))
                return typeof(double);
            else 
                return typeof(void);                
        }
    }
}