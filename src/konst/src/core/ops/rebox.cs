//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using TC = System.TypeCode;

    partial struct core
    {
        /// <summary>
        /// Uncoditionaly converts a boxed numeric value of one kind to a boxed numeric value of specified kind, if possible.
        /// If not possible, returns the original value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target kind</param>
        [Op]
        public static object rebox(object src, NumericKind dst)
        {
            var tc = Type.GetTypeCode(src?.GetType());
            switch(tc)
            {
                case TC.SByte:
                    return box((sbyte)src, dst);

                case TC.Byte:
                    return box((byte)src, dst);

                case TC.Int16:
                    return box((short)src, dst);

                case TC.UInt16:
                    return box((ushort)src, dst);
                
                case TC.Int32:
                    return box((int)src, dst);

                case TC.UInt32:
                    return box((uint)src, dst);

                case TC.Int64:
                    return box((long)src, dst);

                case TC.UInt64:
                    return box((ulong)src, dst);

                case TC.Single:
                    return box((float)src, dst);

                case TC.Double:
                    return box((double)src, dst);
            }
            return src;
        }
    }
}