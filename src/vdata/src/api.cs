//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;
    
    using static Seed;
    using static Memories;
 
    [ApiHost("api")]
    public static partial class Data
    {        
        const int IndexWidth = 8;

        const int ByteSwapIndex = 0*IndexWidth;

        const int DecIndex = 1*IndexWidth;

        const int IncIndex = 2*IndexWidth;

        const int PackIndex = 3*IndexWidth;

        const int UnitsIndex = 4*IndexWidth;

        const int LastIndex = UnitsIndex + IndexWidth;

        const int ResCount = LastIndex;

        static readonly BinaryResource[] Described = new BinaryResource[ResCount];
        
        static bool Initialized = false;

        
        public static IEnumerable<BinaryResource> Resources
        {
            get 
            {
                lock(Described)
                {
                    if(!Initialized)
                    {
                        try
                        {
                            iter(typeof(Data).DeclaredStaticMethods().Tagged<ResourceProviderAttribute>(), m => m.Invoke(null, new object[]{}));
                            Initialized = true;
                        }
                        catch(Exception e)
                        {
                            term.error(e);
                        }
                    }
                }

                if(Initialized)
                    foreach(var d in Described)
                        if(!d.IsEmpty)
                            yield return d;                        
            }
        }

        [MethodImpl(Inline)]
        static unsafe void Register(int index, string name, ReadOnlySpan<byte> src)
            => Described[index] = BinaryResource.Define(name, src); 
    }
}