//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public abstract class Assets<T>
        where T : Assets<T>, new()
    {
        public static T create(IWfShell wf)
            => new T();

        public static Assembly DataSource => typeof(T).Assembly;

        public ResDescriptor Asset(ContentName id)
        {
            if(Resources.descriptor(DataSource, id, out ResDescriptor res))
                return res;
            else
                throw new Exception($"Resource {id} not found");
        }

        public ResDescriptors All()
            => Resources.descriptors(DataSource);
    }
}