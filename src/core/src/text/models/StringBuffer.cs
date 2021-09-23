//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public unsafe readonly struct StringRef
    {
        readonly MemoryAddress Base;

        public readonly uint Length;

        public readonly uint Hash;

        [MethodImpl(Inline)]
        public StringRef(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
            Hash = alg.hash.marvin(cover(@base.Pointer<char>(), length));
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => cover(Base.Pointer<char>(), Length);
        }
    }

    public interface IStringBuffer
    {
        MemoryAddress Base {get;}

        ByteSize Size {get;}
    }

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