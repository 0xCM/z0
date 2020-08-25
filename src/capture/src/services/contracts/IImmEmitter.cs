//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IImmEmitter : IShellBase, IDisposable
    {
        void EmitLiteral(byte[] imm8, params PartId[] parts);

        void EmitRefined(params PartId[] parts);

        void ClearArchive(params PartId[] parts);
    }
}