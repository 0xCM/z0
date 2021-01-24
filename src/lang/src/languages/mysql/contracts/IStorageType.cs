//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    partial struct MySql
    {

        public interface IStorageType<T>
        {
            string Name {get;}

            TypeAffinityKind Affinity {get;}
        }

        public interface IFixedStorageType<T> : IStorageType<T>
        {
            ByteSize Size {get;}
        }
    }
}