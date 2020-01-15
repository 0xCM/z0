//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    using static SurrogateD;
    using static DelegateSurrogates;

    public class t_opcatalog : t_gmath<t_opcatalog>
    {     
        void list_contracted()
        {

            foreach(var op in GX.Catalog.Contracted)
            foreach(var id in op.Reifications)
                Trace(id);
        }

        public void list_nongeneric()
        {

            foreach(var op in GX.Catalog.Direct)
                Trace(op.Id);
        }

        void list_generic()
        {

            foreach(var op in GX.Catalog.Generic)
            foreach(var id in op.Reifications)
                Trace(op.Id);
        }

    }
}