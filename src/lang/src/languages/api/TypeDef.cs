//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using lang;

    using static Root;
    using static core;

    public readonly struct TypeDef<T> : IType<T>
        where T : unmanaged
    {
        StringAddress Name {get;}

        public ByteSize StorageSize {get;}

        public BitWidth DataWidth {get;}

        [MethodImpl(Inline)]
        public TypeDef(string name, BitWidth width)
        {
            Name = name;
            DataWidth = width;
            StorageSize = size<T>();
        }

        public string TypeName
        {
            [MethodImpl(Inline)]
            get => Name.Format();
        }
    }

    public readonly struct TypeDef : IType
    {
        StringAddress Name {get;}

        public ByteSize StorageSize {get;}

        public BitWidth DataWidth {get;}

        [MethodImpl(Inline)]
        public TypeDef(string name, ByteSize storage, BitWidth width)
        {
            Name = name;
            StorageSize = storage;
            DataWidth = width;
        }

        public string TypeName
        {
            [MethodImpl(Inline)]
            get => Name.Format();
        }
    }
}