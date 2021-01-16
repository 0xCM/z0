//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [ApiHost]
    public readonly struct DataTypes
    {
        [MethodImpl(Inline), Op]
        public static DataType empty()
            => new DataType(new EmptyDataType());

        [Op]
        public static DataType metadata(Type src)
        {
            var interfaces = src.Interfaces();
            var itype = typeof(IDataType);
            if(Index.contains(interfaces, itype))
                return metadata((IDataType)Activator.CreateInstance(src));
            else
                return DataType.Empty;
        }

        [Op]
        public static bool metadata(Type src, out DataType dst)
        {
            var interfaces = src.Interfaces();
            var itype = typeof(IDataType);
            if(Index.contains(interfaces, itype))
            {
                dst = metadata((IDataType)Activator.CreateInstance(src));
                return true;
            }
            else
            {
                dst = DataType.Empty;
                return false;
            }
        }

        [MethodImpl(Inline)]
        public static DataType metadata<T>(T src)
            where T : IDataType
                => new DataType(src);
    }
}