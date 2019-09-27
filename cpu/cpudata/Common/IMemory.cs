//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    
    public interface IMemoryAddress
    {

    }
    
    public interface IMemory
    {

    }


    public interface IMemory<N> : IMemory
        where N : ITypeNat, new()
    {
        BitSize Size 
            => new N().value;

    }

    public interface IMemory<N,T> : IMemory<N>
        where N : ITypeNat, new()
    {
        T Content {get;}
    }

    public struct Mem8 : IMemory<N8, byte>
    {
        byte content;

        public Mem8(byte content)
            => this.content = content;

        public byte Content
            => content;
    }

    public struct Mem16 : IMemory<N16, ushort>
    {
        ushort content;

        public Mem16(ushort content)
            => this.content = content;

        public ushort Content
            => content;
    }

    public struct Mem32 : IMemory<N32, uint>
    {
        uint content;

        public Mem32(uint content)
            => this.content = content;

        public uint Content
            => content;
    }

    public struct Mem64 : IMemory<N64, ulong>
    {
        ulong content;

        public Mem64(ulong content)
            => this.content = content;

        public ulong Content
            => content;
    }

}