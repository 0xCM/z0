//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        // public readonly struct VectorType : IRuleDataType<VectorType>
        // {
        //     public CellType CellType {get;}

        //     public uint CellCount {get;}

        //     [MethodImpl(Inline)]
        //     public VectorType(CellType type, uint length)
        //     {
        //         CellType = type;
        //         CellCount = length;
        //     }

        //     public BitWidth Width
        //     {
        //         [MethodImpl(Inline)]
        //         get => CellType.Width*CellCount;
        //     }

        //     [MethodImpl(Inline)]
        //     public static implicit operator VectorType((CellType type, uint length) src)
        //         => new VectorType(src.type, src.length);
        // }
    }
}