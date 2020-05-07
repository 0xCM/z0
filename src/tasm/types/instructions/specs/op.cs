//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmSpecs
    {
        public interface op
        {
            
        }

        public interface op32 : op
        {
            
        }

        public interface op64 : op
        {
            
        }

        public interface op32x64 : op32, op64
        {
            
        }
    }
}