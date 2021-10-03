//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class StringBuffer : IStringBuffer
    {
        public MemoryAddress Base {get;protected set;}

        public ByteSize Size {get; protected set;}

        protected StringBuffer(MemoryAddress @base, ByteSize size)
        {
            Base = @base;
            Size = size;
        }

        protected StringBuffer()
        {
            Base = 0;
            Size = 0;
        }
    }

    public abstract class StringBuffer<T> : StringBuffer
        where T : StringBuffer<T>, new()
    {
        public static T create(MemoryAddress @base, ByteSize size)
        {
            var dst = new T();
            dst.Base = @base;
            dst.Size = size;
            return dst;
        }
    }
}