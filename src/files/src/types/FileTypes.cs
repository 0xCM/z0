//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FileTypeModels;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct FileTypes
    {
        public static AsmFileType Asm => default(AsmFileType);

        public static BinFileType Bin => default(BinFileType);

        public static CsFileType Cs => default(CsFileType);

        public static DllFileType Dll => default(DllFileType);

        public static ExeFileType Exe => default(ExeFileType);

        static FileTypes()
        {
            Lookup = new();
            EmptyFileType = FileType.Empty;

            var props = @readonly(typeof(FileTypes).StaticProperties());
            var count = props.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var prop = ref skip(props,i);
                if(prop.PropertyType.Reifies<IFileType>())
                {
                    var value = (IFileType)prop.GetValue(null);
                    Lookup[value.RuntimeType] = type(value.RuntimeType, value.FileKind, value.Extensions);
                }
            }
        }

        static FileTypeLookup Lookup;

        static FileType EmptyFileType;

        [Op]
        public static FileType lookup(Type key)
        {
            if(Lookup.TryGetValue(key, out var value))
                return value;
            else
                return EmptyFileType;
        }
    }
}