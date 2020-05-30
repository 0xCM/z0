//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Control;
    using static Seed;

    public readonly struct ResIdentity
    {
        [MethodImpl(Inline)]
        public static ResIdentity<T> Define<T>(string name, ulong location, int length)
            where T : unmanaged
                => new ResIdentity<T>(name,location,length);
        
        [MethodImpl(Inline)]
        public ResIdentity(string name, ulong location, int length, PrimalKind type, int cellsize, int bytecount)
        {
            Name = name;
            Location = location;
            CellCount = length;
            DataType = type;
            CellSize = cellsize;
            ByteCount = bytecount;
        }

        public string Name {get;}

        public ulong Location {get;}

        public int CellCount {get;}

        public PrimalKind DataType {get;}
        
        public int CellSize {get;}

        public int ByteCount {get;}
    }

    public readonly struct ResIdentity<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator ResIdentity(ResIdentity<T> src)
            => new ResIdentity(src.Name, src.Location, src.CellCount, default, src.CellSize, src.ByteCount);

        [MethodImpl(Inline)]
        public ResIdentity(string name, ulong location, int cells)
        {
            this.Name = name;
            this.Location = location;
            this.CellCount = cells;
        }

        public string Name {get;}

        public ulong Location {get;}

        public int CellCount {get;}

        public int CellSize 
        {
            [MethodImpl(Inline)]
            get => size<T>();
        }

        public int ByteCount 
        {
            [MethodImpl(Inline)]
            get => CellCount*CellSize;
        }
    }
}