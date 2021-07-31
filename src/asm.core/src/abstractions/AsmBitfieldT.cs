//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmBitfield
    {
        BitfieldModel Model {get;}
    }

    public abstract class AsmBitfield<T> : IAsmBitfield
        where T : ITokenSet, new()
    {
        protected AsmBitfield(string fieldname)
        {
            Model = BitfieldSpecs.bitfield(fieldname, new T().Types());
        }

        public BitfieldModel Model {get;}
    }
}