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

    public readonly struct ResIdentity<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator ResIdentity(ResIdentity<T> src)
            => new ResIdentity(src.Name, MemRef.define(src.Location, src.ByteCount), Control.primal<T>());

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