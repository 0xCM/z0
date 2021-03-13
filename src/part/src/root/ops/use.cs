//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct root
    {
        public static void use<T>(T resource, Action<T> worker)
            where T : IDisposable
        {
            try
            {
                worker(resource);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                resource.Dispose();
            }
        }
    }
}