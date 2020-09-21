//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static FS;

    partial struct FS
    {

        public interface IEntry : ITextual
        {
            PathPart Name {get;}    

            string ITextual.Format() 
                => Name.Format();
        }

        public interface IEntry<F> : IEntry 
            where F : struct, IEntry<F>
        {
            
        }
    }
}