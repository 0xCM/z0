//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
       /// <summary>
        /// Characterizes a segment register
        /// </summary>
        public interface regS : reg
        {        
            RegisterKind reg.Kind => RegisterKind.Seg;
        }

        public interface regS<W> : regS, reg<W>
            where W : unmanaged, IDataWidth
        {

        }

    }
}