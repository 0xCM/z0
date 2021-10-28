//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CellType
    {
        public static Outcome parse(string src, out CellType dst)
            => CellTypeParser.Service.Parse(src, out dst);

        public uint ContentWidth {get;}

        public uint StorageWidth {get;}

        public PrimalClass Class {get;}

        [MethodImpl(Inline)]
        public CellType(uint content, uint storage, PrimalClass @class)
        {
            ContentWidth = content;
            StorageWidth = storage;
            Class = @class;
        }

        public static CellType Empty => default;

        public string Format()
            => CellTypeFormatter.Service.Format(this);

        public override string ToString()
            => Format();
    }
}