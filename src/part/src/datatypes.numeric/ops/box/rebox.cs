//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    using NK = NumericKind;

    partial struct Numeric
    {
        /// <summary>
        /// Converts a boxed numeric value of one kind to a boxed numeric value of specified kind, if possible.
        /// If not possible, returns the original value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target kind</param>
        [Op]
        public static object rebox(object src, NK dst)
        {
            var type = src?.GetType() ?? typeof(void);
            var _nk = Numeric.kind(type);
            switch(_nk)
            {
                case NK.I8:
                    return box((sbyte)src, dst);
                case NK.U8:
                    return box((byte)src, dst);
                case NK.I16:
                    return box((short)src, dst);
                case NK.U16:
                    return box((ushort)src, dst);
                case NK.I32:
                    return box((int)src, dst);
                case NK.U32:
                    return box((uint)src, dst);
                case NK.I64:
                    return box((long)src, dst);
                case NK.U64:
                    return box((ulong)src, dst);
                case NK.F32:
                    return box((float)src, dst);
                case NK.F64:
                    return box((double)src, dst);
            }
            return @throw<object>($"The type {type} is not supported");
        }
    }
}

