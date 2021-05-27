//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public partial class FileTypes
    {
        [MethodImpl(Inline), Op]
        public static unsafe FixedCells<FileType> supported()
            => FixedCells.define<FileType>(memory.@address(_Types), FileTypeCount);

        [MethodImpl(Inline), Op]
        public static IReadOnlyCollection<string> keys()
            => Lookup.Keys;

        static FileTypes()
        {
            Lookup = new();
            EmptyType = FileType.Empty;

            var props = @readonly(typeof(FileTypes).StaticProperties());
            var count = props.Length;

            _Types = alloc<FileType>(count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var prop = ref skip(props,i);
                if(prop.PropertyType.Reifies<IFileType>())
                {
                    var value = (IFileType)prop.GetValue(null);
                    _Types[counter++] = type(value.Rep, value.FileKind, value.FileExt);
                    Lookup[key(value.FileExt)] = _Types[counter];
                }
            }

            FileTypeCount = counter;
        }

        static string key(FS.FileExt src)
            => src.Name.Format().ToLower();

        static FileTypeLookup Lookup;

        static FileType EmptyType;

        [FixedAddressValueType]
        static Index<FileType> _Types;

        static uint FileTypeCount;
    }

    sealed class FileTypeLookup : Dictionary<string,FileType>
    {

    }
}