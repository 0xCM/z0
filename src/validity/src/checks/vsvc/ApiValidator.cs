//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public abstract class ApiValidator<V> : AppService<V>, IApiValidator
        where V : ApiValidator<V>,new()
    {
        protected IDomainSource Source {get; private set;}

        public static V create(IWfRuntime wf, IDomainSource src)
        {
            var service = create(wf);
            service.Source = src;
            return service;
        }

        protected ApiValidator()
        {
            SampleCount = Pow2.T12;
        }

        protected uint SampleCount {get;}

        public abstract void Validate();
    }
}