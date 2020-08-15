//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost("api")]
    public readonly partial struct Flow
    {                            
        public static string AppName 
        {
            [MethodImpl(Inline), Op]
            get => Assembly.GetEntryAssembly().GetSimpleName();
        }        

        public static int Main(params string[] args)
        {
            try
            {
                return 0;
            }
            catch(Exception e)
            {
                term.error(e);
                return -1;
            }
        }
    }
}